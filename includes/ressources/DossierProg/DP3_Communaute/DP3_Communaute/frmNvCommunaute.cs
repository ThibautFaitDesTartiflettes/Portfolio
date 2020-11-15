using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP3_Communaute
{
    public partial class frmNvCommunaute : Form
    {
        public frmNvCommunaute()
        {
            InitializeComponent();
        }

        public void DeblocageBoutonValider()
        {
            //Si toutes les informations sont remplies alors
            if (tbNom.Text != "" && pbLogo.Image != null && cbJoueur.Text != "")
            {
                btValider.Enabled = true;   //On débloque le bouton
            }
            else
            {
                btValider.Enabled = false;
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmNvCommunaute
        }

        private void btLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();                                                               //On instancie un nouvel objet de la classe OpenFileDialog
            dialog.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";   //On filtre pour avoir uniquement les images
            if (dialog.ShowDialog() == DialogResult.OK)                                                                 //Si quelque chose à été ouvert alors
            {
                Image avatar = Image.FromFile(dialog.FileName); //On instancie un objet de la classe Image contenant l'image ouverte depuis l'ordinateur
                pbLogo.Image = avatar;                        //On l'affiche dans la PictureBox
            }
            DeblocageBoutonValider();   //On appelle la méthode pour débloquer le bouton valider
        }

        private void frmNvCommunaute_Load(object sender, EventArgs e)
        {
            //On affiche tous les joueurs qui ont été créés
            foreach (Joueur unJoueur in Globale.lesJoueurs)
            {
                cbJoueur.Items.Add(unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")");
            }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            //On regarde si le joueur appartient déja à une communaute
            if (Globale.lesJoueurs.ElementAt(cbJoueur.SelectedIndex).getCommunaute() != "")
            {
                //On informe l'utilisateur
                MessageBox.Show("Ce joueur appartient déjà à une communauté, veuillez la quitter pour en créer une", "Impossible", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //On instancie un nouvel objet de la classe Communaute qui sera ajouté à la collection contenant les communautés
                Globale.lesCommunautes.Add(new Communaute(tbNom.Text, cbJoueur.Text, pbLogo.Image));
                //On ajoute le fondateur à sa communauté
                Globale.lesJoueurs.ElementAt(cbJoueur.SelectedIndex).setCommunaute(tbNom.Text);

                string nomCommu = Globale.lesJoueurs.ElementAt(cbJoueur.SelectedIndex).getCommunaute(); //On recupère le nom de la communaute du joueur
                int idx = 0;                                                                           //Variable utile au parcours
                bool trouve = false;                                                                   //Variable utile à l'affichage

                //Tant que la collection n'as pas été parcourue totalement et que trouve est faux alors
                while (idx < Globale.lesCommunautes.Count && !trouve)
                {
                    //Si l'index de l'élément choisi est égal à la variable de parcours alors
                    if (nomCommu == Globale.lesCommunautes.ElementAt(idx).getNom())
                    {
                        trouve = true;  //Trouve passe à true
                    }
                    else
                    {
                        idx++;  //On regarde l'élément suivant
                    }
                }

                //Si on à trouvé la communauté
                if (trouve)
                {
                    //On ajoute le membre à la liste des membres
                    Globale.lesCommunautes.ElementAt(idx).ajouterMembre(Globale.lesJoueurs.ElementAt(cbJoueur.SelectedIndex));
                }
                else
                {
                    //On informe une erreur
                    MessageBox.Show("Un problème est survenu, veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //On informe l'utilisateur que la communauté à bien été créée
                MessageBox.Show("La communauté à bien été créée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //On remet à zero
            tbNom.Clear();
            cbJoueur.Text = "";
            pbLogo.Image = null;
        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            DeblocageBoutonValider();

            int idx = 0;                            //Variable utile au parcours
            bool trouve = false;                    //Variable utile à l'affichage

            //Tant que la collection n'as pas été parcourue totalement et que trouve est faux alors
            while (idx < Globale.lesCommunautes.Count && !trouve)
            {
                //Si le nom existe dèjà alors
                if (tbNom.Text == Globale.lesCommunautes.ElementAt(idx).getNom())
                {
                    trouve = true;  //Trouve passe à true
                }
                else
                {
                    idx++;  //On regarde l'élément suivant
                }
            }

            //Si on à trouvé quelque chose alors on affiche
            if (trouve)
            {
                MessageBox.Show("Ce nom est déjà pris", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeblocageBoutonValider();
        }
    }
}
