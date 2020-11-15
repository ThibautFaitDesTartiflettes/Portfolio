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
    public partial class FrmVisiteurListe : Form
    {
        public FrmVisiteurListe()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmVisiteurListe_Load(object sender, EventArgs e)
        {
            // initialisation de ma liste
            foreach (visiteur leVisiteur in Globale.lesVisiteurs)
            {
                ListViewItem laLigne = new ListViewItem();

                laLigne.Text = leVisiteur.getMatricule().ToString();
                laLigne.SubItems.Add(leVisiteur.getNom());
                laLigne.SubItems.Add(leVisiteur.getPrenom());
    

                lvVisiteur.Items.Add(laLigne);

            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
