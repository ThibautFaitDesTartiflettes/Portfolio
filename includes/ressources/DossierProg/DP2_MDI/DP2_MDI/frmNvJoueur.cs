using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP2_MDI
{
    public partial class frmNvJoueur : Form
    {
        public frmNvJoueur()
        {
            InitializeComponent();
        }

        public void DeblocageBoutonValider()    //On définit si le bouton Valider peut être déverouillé
        {   
            //Si les textBox ne sont pas vide et que tbMail contient un "." et un "@" et si la PictureBox n'est pas vide alors
            if (tbNom.Text != "" && tbPrenom.Text != "" && pbAvatar.Image != null && tbPseudo.Text != "" && tbMail.Text.Contains("@") == true && tbMail.Text.Contains(".") == true)
            {
                btValider.Enabled = true;   //On débloque le bouton
            }
            else
            {
                btValider.Enabled = false;  //On le vérouille
            }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            //On instance leJoueurTest présent dans la classe Globale avec le constructeur de la classe Joueur
            Globale.leJoueurTest = new Joueur(tbNom.Text, tbPrenom.Text, tbMail.Text, tbPseudo.Text, pbAvatar.Image);

            //On vide ensuite les textBox et la PictureBox
            tbNom.Clear();
            tbPrenom.Clear();
            tbMail.Clear();
            tbPseudo.Clear();
            pbAvatar.Image = null;
        }

        private void btAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();                                                               //On instancie un nouvel objet de la classe OpenFileDialog
            dialog.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";   //On filtre pour avoir uniquement les images
            if (dialog.ShowDialog() == DialogResult.OK)                                                                 //Si quelque chose à été ouvert alors
            {
                Image avatar = Image.FromFile(dialog.FileName); //On instancie un objet de la classe Image contenant l'image ouverte depuis l'ordinateur
                pbAvatar.Image = avatar;                        //On l'affiche dans la PictureBox
            }
            DeblocageBoutonValider();   //On appelle la méthode pour débloquer le bouton valider
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmNvJoueur
        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            DeblocageBoutonValider();   //On appelle la méthode pour débloquer le bouton valider
        }

        private void tbPrenom_TextChanged(object sender, EventArgs e)
        {
            DeblocageBoutonValider();   //On appelle la méthode pour débloquer le bouton valider
        }

        private void tbMail_TextChanged(object sender, EventArgs e)
        {
            DeblocageBoutonValider();   //On appelle la méthode pour débloquer le bouton valider
        }

        private void tbPseudo_TextChanged(object sender, EventArgs e)
        {
            DeblocageBoutonValider();   //On appelle la méthode pour débloquer le bouton valider
        }
    }
}
