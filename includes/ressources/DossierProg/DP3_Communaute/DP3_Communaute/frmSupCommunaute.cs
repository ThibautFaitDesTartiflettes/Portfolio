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
    public partial class frmSupCommunaute : Form
    {
        public frmSupCommunaute()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmSupCommunaute
        }

        private void frmSupCommunaute_Load(object sender, EventArgs e)
        {
            //On affiche toutes les communautées qui ont été créés
            foreach (Communaute uneCommunaute in Globale.lesCommunautes)
            {
                cbCommunaute.Items.Add(uneCommunaute.getNom());
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            int position = cbCommunaute.SelectedIndex;

            //On parcours tous les joueurs
            foreach (Joueur unJoueur in Globale.lesJoueurs)
            {
                //Si le joueur appartient à la communautée selectionnée alors
                if (unJoueur.getCommunaute() == Globale.lesCommunautes.ElementAt(position).getNom())
                {
                    //On le retire de la communauté
                    unJoueur.setCommunaute("");
                }
            }

            //On supprime la communautée sélectionnée
            Globale.lesCommunautes.Remove(Globale.lesCommunautes.ElementAt(position));
            //On informe la réussite
            MessageBox.Show("La communauté à bien été supprimée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
