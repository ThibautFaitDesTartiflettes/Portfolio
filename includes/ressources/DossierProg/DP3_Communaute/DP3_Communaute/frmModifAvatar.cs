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
    public partial class frmModifAvatar : Form
    {
        public frmModifAvatar()
        {
            InitializeComponent();
        }

        public void DeblocageBoutonValider()    //On définit si le bouton Valider peut être déverouillé
        {
            if (pbNvAvatar.Image != null)   //Si une image est chargée dans la PictureBox alors
            {
                btValider.Enabled = true;   //On débloque le bouton Valider
            }
            else
            {
                btValider.Enabled = false;  //Sinon il reste bloqué
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmModifAvatar
        }

        private void frmModifAvatar_Load(object sender, EventArgs e)
        {
            //On affiche tous les joueurs qui ont été créés
            foreach (Joueur unJoueur in Globale.lesJoueurs)
            {
                cbJoueur.Items.Add(unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")");
            }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            int position = cbJoueur.SelectedIndex;
            Globale.lesJoueurs.ElementAt(position).setAvatar(pbNvAvatar.Image);       //On stocke l'avatar à la place de l'ancien dans la collection lesJoueurs
            pbActAvatar.Image = Globale.lesJoueurs.ElementAt(position).getAvatar();   //On affiche l'avatar dans la textBox avatar actuel
            pbNvAvatar.Image = null;                                                  //On vide la PictureBox nouvel avatar
        }

        private void btAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();                                                               //On instancie un nouvel objet de la classe OpenFileDialog
            dialog.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";   //On filtre pour avoir uniquement les images
            if (dialog.ShowDialog() == DialogResult.OK)                                                                 //Si quelque chose à été ouvert alors
            {
                Image avatar = Image.FromFile(dialog.FileName); //On instancie un objet de la classe Image contenant l'image ouverte depuis l'ordinateur
                pbNvAvatar.Image = avatar;                      //On l'affiche dans la PictureBox
            }
            DeblocageBoutonValider();   //On appelle la méthode pour débloquer le bouton valider
        }

        private void cbJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = cbJoueur.SelectedIndex;  //On recupère l'index de l'élément choisi
            int idx = 0;                            //Variable utile au parcours
            bool trouve = false;                    //Variable utile à l'affichage

            //Tant que la collection n'as pas été parcourue totalement et que trouve est faux alors
            while (idx < Globale.lesJoueurs.Count && !trouve)
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
                pbActAvatar.Image = Globale.lesJoueurs.ElementAt(position).getAvatar();
            }
            //Sinon on informe l'utilisateur
            else
            {
                MessageBox.Show("Un problème est survenu avec ce joueur, veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
