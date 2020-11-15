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
    public partial class frmModifCommunaute : Form
    {
        public frmModifCommunaute()
        {
            InitializeComponent();
        }

        public void Verification()
        {
            //On verifie que rien n'est vide ou non renseingé
            if (tbNom.Text == "" || pbLogo.Image == null || cbNvFondateur.Text == "" || dtpDateCreation.Value == null)
            {
                btValider.Enabled = false;
            }
            else
            {
                btValider.Enabled = true;
            }
        }

        public void DeblocageModification()
        {
            if (cbCommunaute.Text != "" && cbJoueur.Text != "")
            {
                tbNom.Enabled = true;
                cbNvFondateur.Enabled = true;
                btLogo.Enabled = true;
                dtpDateCreation.Enabled = true;
            }
            else
            {
                tbNom.Enabled = false;
                cbNvFondateur.Enabled = false;
                btLogo.Enabled = false;
                dtpDateCreation.Enabled = false;
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmModifCommunaute
        }

        private void frmModifCommunaute_Load(object sender, EventArgs e)
        {
            //On affiche toutes les communautés qui ont été créés
            foreach (Communaute uneCommunaute in Globale.lesCommunautes)
            {
                cbCommunaute.Items.Add(uneCommunaute.getNom());
            }

            //On affiche tous les joueurs qui ont été créés
            foreach (Joueur unJoueur in Globale.lesJoueurs)
            {
                cbJoueur.Items.Add(unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")");
            }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            //Si le joueur est le fonateur de la commuanauté
            if (Globale.lesCommunautes.ElementAt(cbCommunaute.SelectedIndex).getFondateur() == Globale.lesJoueurs.ElementAt(cbJoueur.SelectedIndex).getPseudo() + "  (" +
                                                                                               Globale.lesJoueurs.ElementAt(cbJoueur.SelectedIndex).getNom() + " " +
                                                                                               Globale.lesJoueurs.ElementAt(cbJoueur.SelectedIndex).getPrenom() + ")")
            {
                int positionCommu = cbCommunaute.SelectedIndex;     //Variable utile pour la recherche dans lesCommunautes
                int positionFonda = cbNvFondateur.SelectedIndex;         //Variable utile pour la recherche dans lesJoueurs

                //On parcours tous les joueurs
                foreach (Joueur unJoueur in Globale.lesJoueurs)
                {
                    //Si le joueur appartient à la communauté alors
                    if (unJoueur.getCommunaute() == Globale.lesCommunautes.ElementAt(positionCommu).getNom())
                    {
                        //On change le nom de communauté des joueurs appartenant à celle-ci
                        unJoueur.setCommunaute(tbNom.Text);
                    }
                }

                Globale.lesCommunautes.ElementAt(positionCommu).setNom(tbNom.Text);                                                     //Modification du nom
                Globale.lesCommunautes.ElementAt(positionCommu).setFondateur(Globale.lesJoueurs.ElementAt(positionFonda).getPseudo());  //Modification du créateur
                Globale.lesCommunautes.ElementAt(positionCommu).setLogo(pbLogo.Image);                                                  //Modification du logo
                Globale.lesCommunautes.ElementAt(positionCommu).setDateCreation(dtpDateCreation.Value);                                 //Modification de la date de création

                //On affiche les nouvelles informations
                tbNom.Text = Globale.lesCommunautes.ElementAt(positionCommu).getNom();
                cbNvFondateur.Text = Globale.lesCommunautes.ElementAt(positionCommu).getFondateur();
                pbLogo.Image = Globale.lesCommunautes.ElementAt(positionCommu).getLogo();
                tbDateCreation.Text = Globale.lesCommunautes.ElementAt(positionCommu).getDateCreation().ToString("d");

                //On informe de la réussite
                MessageBox.Show("Les informations ont bien été modifiés", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Il n'est pas fondateur donc pas autorisé à modifier
                MessageBox.Show("Vous n'êtes pas autorisé à modifier ces informations", "Refus", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            //On enleve l'élément sélectionné de la vue
            cbNvFondateur.Items.Clear();
            cbNvFondateur.Text = "";
            cbCommunaute.Text = "";
            cbJoueur.Text = "";
            tbNom.Clear();
            tbFondateur.Clear();
            tbDateCreation.Clear();
            tbDateCreation.Clear();
        }

        private void cbCommunaute_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeblocageModification();

            int position = cbCommunaute.SelectedIndex;  //On recupère l'index de l'élément choisi
            int idx = 0;                            //Variable utile au parcours
            bool trouve = false;                    //Variable utile à l'affichage

            //Tant que la collection n'as pas été parcourue totalement et que trouve est faux alors
            while (idx < Globale.lesCommunautes.Count && !trouve)
            {
                //Si l'index de l'élément choisi est égal à la variable de parcours alors
                if (position == idx)
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
                tbNom.Text = Globale.lesCommunautes.ElementAt(position).getNom();
                tbFondateur.Text = Globale.lesCommunautes.ElementAt(position).getFondateur();
                pbLogo.Image = Globale.lesCommunautes.ElementAt(position).getLogo();
                tbDateCreation.Text = Globale.lesCommunautes.ElementAt(position).getDateCreation().ToString("d");
            }
            //Sinon on informe l'utilisateur
            else
            {
                MessageBox.Show("Un problème est survenu avec cette communautée, veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //On parcours tous les joueurs
            foreach (Joueur unJoueur in Globale.lesJoueurs)
            {
                //Si le joueur appartient à la communauté alors
                if (unJoueur.getCommunaute() == Globale.lesCommunautes.ElementAt(position).getNom())
                {
                    //On ajoute le joueur à la comboBox
                    cbNvFondateur.Items.Add(unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")");
                }
            }
        }

        private void btLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();                                                               //On instancie un nouvel objet de la classe OpenFileDialog
            dialog.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";   //On filtre pour avoir uniquement les images
            if (dialog.ShowDialog() == DialogResult.OK)                                                                 //Si quelque chose à été ouvert alors
            {
                Image avatar = Image.FromFile(dialog.FileName); //On instancie un objet de la classe Image contenant l'image ouverte depuis l'ordinateur
                pbLogo.Image = avatar;                          //On l'affiche dans la PictureBox
            }

            Verification();
        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            Verification();
        }

        private void cbJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            Verification();
        }

        private void dtpDateCreation_ValueChanged(object sender, EventArgs e)
        {
            Verification();
        }

        private void cbJoueur_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DeblocageModification();
        }
    }
}
