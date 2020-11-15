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
    public partial class FrmVisiteConsulter : Form
    {
        public FrmVisiteConsulter()
        {
            InitializeComponent();
        }

        private void FrmVisiteConsulter_Load(object sender, EventArgs e)
        {
            foreach (visite laVisite in Globale.lesVisites)
            {
                ListViewItem laLigne = new ListViewItem();

                laLigne.Text = laVisite.getnumVisite().ToString();
                laLigne.SubItems.Add(laVisite.getDateVisiteAffichage());
                laLigne.SubItems.Add(laVisite.getVisiteur().getNom());  //Nom du visiteur    
                laLigne.SubItems.Add(laVisite.getProfessionnel().getNomPro());  //Nom du professionnel
                laLigne.SubItems.Add(laVisite.getnbProduitsPresentes().ToString());
                laLigne.SubItems.Add(laVisite.getnbProduitsRetenus().ToString());

                lvVisiteToutes.Items.Add(laLigne);

            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
