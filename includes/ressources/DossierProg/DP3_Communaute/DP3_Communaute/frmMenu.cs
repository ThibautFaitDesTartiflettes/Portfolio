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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void jeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvoluer maForm = new frmEvoluer();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void pointsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPoints maForm = new frmPoints();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void nouveauJoueurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNvJoueur maForm = new frmNvJoueur();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void voirJoueurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVoirJoueur maForm = new frmVoirJoueur();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void modifierMailToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModifMail maForm = new frmModifMail();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void modifierAvatarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModifAvatar maForm = new frmModifAvatar();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void voirCommunauteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVoirCommunaute maForm = new frmVoirCommunaute();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void nouvelleCommunauteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNvCommunaute maForm = new frmNvCommunaute();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void voirCommunauteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVoirCommunaute maForm = new frmVoirCommunaute();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void modifierCommunauteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModifCommunaute maForm = new frmModifCommunaute();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void supprimerCommunauteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSupCommunaute maForm = new frmSupCommunaute();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void rejoindreUneCommunauteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRejoindreCommunaute maForm = new frmRejoindreCommunaute();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void quitterSaCommunauteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuitterCommunaute maForm = new frmQuitterCommunaute();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void classementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassementJoueurCommunaute maForm = new frmClassementJoueurCommunaute();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChatCommunaute maForm = new frmChatCommunaute();
            maForm.MdiParent = this;
            maForm.Show();
        }

        private void influenceursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfluenceurCommunaute maForm = new frmInfluenceurCommunaute();
            maForm.MdiParent = this;
            maForm.Show();
        }
    }
}
