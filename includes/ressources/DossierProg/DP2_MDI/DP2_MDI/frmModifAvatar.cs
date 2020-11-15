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

        private void frmModifAvatar_Load(object sender, EventArgs e)
        {
            pbActAvatar.Image = Globale.leJoueurTest.getAvatar();   //On charge l'avatar stocké dans leJoueurTest
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

        private void btValider_Click(object sender, EventArgs e)
        {
            Globale.leJoueurTest.setAvatar(pbNvAvatar.Image);       //On stocke l'avatar à la place de l'ancien dans leJoueurTest
            pbActAvatar.Image = Globale.leJoueurTest.getAvatar();   //On affiche l'avatar dans la textBox avatar actuel
            pbNvAvatar.Image = null;                                //On vide la PictureBox nouvel avatar
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frModifAvatar
        }
    }
}
