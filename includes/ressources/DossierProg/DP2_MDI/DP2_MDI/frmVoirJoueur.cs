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
    public partial class frmVoirJoueur : Form
    {
        public frmVoirJoueur()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close(); //On ferme frmVoirJoueur
        }

        private void frmVoirJoueur_Load(object sender, EventArgs e)
        {
            tbNom.Text = Globale.leJoueurTest.getNom();                     //On affiche le nom stocké dans leJoueurTest
            tbPrenom.Text = Globale.leJoueurTest.getPrenom();               //On affiche le prenom stocké dans leJoueurTest
            tbMail.Text = Globale.leJoueurTest.getMail();                   //On affiche le mail stocké dans leJoueurTest
            tbPseudo.Text = Globale.leJoueurTest.getPseudo();               //On affiche le pseudo stocké dans leJoueurTest
            pbAvatar.Image = Globale.leJoueurTest.getAvatar();              //On affiche l'avatar stocké dans leJoueurTest
            tbNiveau.Text = Globale.leJoueurTest.getNiveau().ToString();    //On affiche le niveau stocké dans leJoueurTest
            tbScore.Text = Globale.leJoueurTest.getScore().ToString();      //On affiche le score stocké dans leJoueurTest
        }
    }
}
