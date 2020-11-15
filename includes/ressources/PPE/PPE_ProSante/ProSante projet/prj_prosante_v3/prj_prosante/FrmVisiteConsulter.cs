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
            //On charge dans la listView toutes les visites effectuées
            foreach (visite laVisite in Globale.lesVisites)
            {
                ListViewItem laLigne = new ListViewItem();

                laLigne.Text = laVisite.getnumVisite().ToString();                  //Numéro de la visite
                laLigne.SubItems.Add(laVisite.getDateVisiteAffichage());            //Date de la visite
                laLigne.SubItems.Add(laVisite.getVisiteur().getNom());              //Nom du visiteur    
                laLigne.SubItems.Add(laVisite.getProfessionnel().getNomPro());      //Nom du professionnel
                laLigne.SubItems.Add(laVisite.getnbProduitsPresentes().ToString()); //Nombre de produits présentés
                laLigne.SubItems.Add(laVisite.getnbProduitsRetenus().ToString());   //Nombre de produits retenus
                laLigne.SubItems.Add(laVisite.getNote().ToString());                //Note de la visite
                laLigne.SubItems.Add(laVisite.getTemps());                          //Temps de la visite

                lvVisiteToutes.Items.Add(laLigne);  //Ajout de la ligne à la listView

            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme la fenêtre
        }
    }
}
