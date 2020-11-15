using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_prosante
{
    public partial class FrmProfessionnelListeTous : Form
    {
        public FrmProfessionnelListeTous()
        {
            InitializeComponent();
        }

        private void FrmProfessionnelListeTous_Load(object sender, EventArgs e)
        {
            //recherche et affiche le prénom, la spécialité, la ville et le nombre d'année d'expérience de chaque professionnel
            foreach (Professionnel leProfessionnel in Globale.lesProfessionnels)
            {
                ListViewItem laLigne = new ListViewItem();

                laLigne.Text = leProfessionnel.NomPro;
                laLigne.SubItems.Add(leProfessionnel.getPrenomPro());
                laLigne.SubItems.Add(leProfessionnel.getSpecialite());
                laLigne.SubItems.Add(leProfessionnel.getVille());
                laLigne.SubItems.Add(leProfessionnel.getannee().ToString());
                lvProfessionnelTous.Items.Add(laLigne);

            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
