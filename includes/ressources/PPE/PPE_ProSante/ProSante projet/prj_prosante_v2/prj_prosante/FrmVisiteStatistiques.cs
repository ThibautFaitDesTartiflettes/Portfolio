using MySql.Data.MySqlClient;
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
    public partial class FrmVisiteStatistiques : Form
    {
        MySqlConnection connection;
        public FrmVisiteStatistiques()
        {
            InitializeComponent();
            MySqlConnection connection = Globale.Connexion();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVisiteStatistiques_Load(object sender, EventArgs e)
        {
            int NbTotalPdtPresentes = 0;
            int NbTotalPdtRetenus = 0;
            foreach (visite uneVisite in Globale.lesVisites)
            {
                NbTotalPdtPresentes += uneVisite.getnbProduitsPresentes();
                NbTotalPdtRetenus += uneVisite.getnbProduitsRetenus();
            }
            Single PctPdtRetenus = ((Single)NbTotalPdtRetenus / (Single)NbTotalPdtPresentes) * 100;

            tbNbTotalVisites.Text = Globale.lesVisites.Count.ToString();
            tbNbProduitsPresentes.Text = NbTotalPdtPresentes.ToString();
            tbNbProduitsRetenus.Text = NbTotalPdtRetenus.ToString();
            tbPctProduitsRetenus.Text = Math.Round(PctPdtRetenus, 2).ToString() + "%";

            foreach (Professionnel unProfessionnel in Globale.lesProfessionnels)
            {
                cbProfessionnel.Items.Add(unProfessionnel.getNomPro() + "  " + unProfessionnel.getPrenomPro());
            }

            foreach (visiteur unVisiteur in Globale.lesVisiteurs)
            {
                cbVisiteur.Items.Add(unVisiteur.getNom() + "  " + unVisiteur.getPrenom());
            }
        }

        private void btnAfficherNbVisitesProfessionnel_Click(object sender, EventArgs e)
        {
            string nomProSelec = cbProfessionnel.SelectedItem.ToString();
            string NbTotalVisitePro = "";

      

            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "SELECT COUNT(*) FROM tb_visite WHERE nomPro = '" + nomProSelec + "'";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[1];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();

                NbTotalVisitePro = valeurColonnes[0];
            }
            connection.Close();

            tbNbVisitesProfessionnel.Text = NbTotalVisitePro;
        }

        private void btnAfficherNbVisitesVisiteur_Click(object sender, EventArgs e)
        {
            int idVisiteurSelec = cbVisiteur.SelectedIndex;
            string matriculeVisiteur = "";

            int idx = 0;
            bool trouve = false;
            visiteur unVisiteur = Globale.lesVisiteurs.ElementAt(idx);
            while (idx < Globale.lesVisiteurs.Count && !trouve)
            {
                if (idVisiteurSelec == idx)
                {
                    trouve = true;
                }
                else
                {
                    idx++;
                }
            }
            if (trouve)
            {
                matriculeVisiteur = Globale.lesVisiteurs[idx].getMatricule();
            }
            else
            {
                MessageBox.Show("Un problème est survenu avec ce visiteur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string NbTotalVisiteVisiteur = "";


            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "SELECT COUNT(*) FROM tb_visite WHERE matriculeVisiteur = '" + matriculeVisiteur + "'";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[1];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();

                NbTotalVisiteVisiteur = valeurColonnes[0];
            }
            connection.Close();

            tbNbVisitesVisiteur.Text = NbTotalVisiteVisiteur;
        }

        private void btnAfficherNbVisitesSpecialite_Click(object sender, EventArgs e)
        {
            string specialiteSelec = tbSpecialite.Text;
            string NbTotalVisiteSpe = "";


            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "SELECT COUNT(*) FROM tb_visite INNER JOIN tb_professionnel on tb_visite.nomPro = tb_professionnel.nomPro WHERE specialitePro = '" + specialiteSelec + "'";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[1];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();

                NbTotalVisiteSpe = valeurColonnes[0];
            }
            connection.Close();

            tbNbVisitesSpecialite.Text = NbTotalVisiteSpe;
        }
    }
}
