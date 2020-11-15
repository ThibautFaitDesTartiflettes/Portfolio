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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void nouveauJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNvJoueur laForm = new frmNvJoueur(); //Instanciation d'un nouvel objet de classe frmNvJoueur
            laForm.MdiParent = this;                //Le parent de cet objet est frmMenu
            laForm.Show();                          //Ouverture de frmNvJoueur
        }

        private void voirJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVoirJoueur laForm = new frmVoirJoueur(); //Instanciation d'un nouvel objet de classe frmVoirJoueur
            laForm.MdiParent = this;                    //Le parent de cet objet est frmMenu
            laForm.Show();                              //Ouverture de frmVoirJoueur
        }

        private void modifierMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifMail laForm = new frmModifMail();   //Instanciation d'un nouvel objet de classe frmModifMail
            laForm.MdiParent = this;                    //Le parent de cet objet est frmMenu
            laForm.Show();                              //Ouverture de frmModifMail
        }

        private void modifierAvatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifAvatar laForm = new frmModifAvatar();   //Instanciation d'un nouvel objet de classe frmModifAvatar
            laForm.MdiParent = this;                        //Le parent de cet objet est frmMenu
            laForm.Show();                                  //Ouverture de frmModifAvatar
        }

        private void evoluerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvoluer laForm = new frmEvoluer();   //Instanciation d'un nouvel objet de classe frmEvoluer
            laForm.MdiParent = this;                //Le parent de cet objet est frmMenu
            laForm.Show();                          //Ouverture de frmEvoluer
        }

        private void pointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPoints laForm = new frmPoints(); //Instanciation d'un nouvel objet de classe frmPoints
            laForm.MdiParent = this;            //Le parent de cet objet est frmMenu
            laForm.Show();                      //Ouverture de frmPoints
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
