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
    public partial class frmModifMail : Form
    {
        public frmModifMail()
        {
            InitializeComponent();
        }

        public void DeblocageBoutonValider()    //On définit si le bouton Valider peut être déverouillé
        {
            if (tbNvMail.Text != "")  //S'il y a du texte dans la PictureBox du nouveau mail alors
            {
                btValider.Enabled = true;   //On débloque le bouton Valider
            }
            else
            {
                btValider.Enabled = false;  //Il reste bloqué
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmModiMail
        }

        private void frmModifMail_Load(object sender, EventArgs e)
        {
            tbActMail.Text = Globale.leJoueurTest.getMail();    //On affiche le mail actuel stocké dans leJoueurTest
        }

        private void tbNvMail_TextChanged(object sender, EventArgs e)
        {
            DeblocageBoutonValider();   //On appelle la méthode de déblocage
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (tbNvMail.Text.Contains("@") == true && tbNvMail.Text.Contains(".") == true) //Si le nouveau mail contient un "." et un "@" alors il est valide donc
            {
                Globale.leJoueurTest.setMail(tbNvMail.Text);        //On stocke le nouveau mail à la place de l'ancien
                tbActMail.Text = Globale.leJoueurTest.getMail();    //On affiche le nouveau mail dans la textBox du mail actuel
                tbNvMail.Clear();                                   //On vide la textBox nouveau mail
            }
            else
            {
                //Sinon on prévient l'utilisateur que sont adresse email n'est pas valide
                MessageBox.Show("Le mail ne répond pas aux critères de validités, veuillez vérifier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
