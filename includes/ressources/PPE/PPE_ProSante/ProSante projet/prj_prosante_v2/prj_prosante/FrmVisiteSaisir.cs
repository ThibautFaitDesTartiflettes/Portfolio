using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prj_prosante
{
    public partial class FrmVisiteSaisir : Form
    {
        MySqlConnection connection;
        public FrmVisiteSaisir()
        {
            InitializeComponent();
            connection = Globale.Connexion();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int NumeroVisite = Globale.lesVisites.Count + 1;
            string DateSelectionnee = mcDateVisite.SelectionStart.ToString("yyyy-MM-dd");
            int NbProduitsPresentes = int.Parse(udNbProduitsPresentes.Value.ToString());
            int NbProduitsRetenus = int.Parse(udNbProduitsRetenus.Value.ToString());
            int IdVisiteur = cbVisiteur.SelectedIndex;
            int IdProfessionnel = cbProfessionnel.SelectedIndex;
            string MatriculeVisiteur = "";
            string NomProfessionnel = "";
            string PrenomProfessionnel = "";

            int idx = 0;
            bool trouve = false;
            visiteur unVisiteur = Globale.lesVisiteurs.ElementAt(idx);
            while (idx < Globale.lesVisiteurs.Count && !trouve)
            {
                if (IdVisiteur == idx)
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
                MatriculeVisiteur =Globale.lesVisiteurs[idx].getMatricule();
            }
            else
            {
                MessageBox.Show("Un problème est survenu avec cet utilisateur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int idx2 = 0;
            bool trouve2 = false;
            Professionnel unProfessionnel = Globale.lesProfessionnels.ElementAt(idx2);
            while (idx2 < Globale.lesProfessionnels.Count && !trouve2)
            {
                if (IdProfessionnel == idx2)
                {
                    trouve2 = true;
                }
                else
                {
                    idx2++;
                }
            }
            if (trouve2)
            {
                NomProfessionnel = Globale.lesProfessionnels[idx2].getNomPro();
                PrenomProfessionnel = Globale.lesProfessionnels[idx2].getPrenomPro();
            }
            else
            {
                MessageBox.Show("Un problème est survenu avec ce professionnel", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            visite laVisite = new visite(mcDateVisite.SelectionStart, (int) udNbProduitsRetenus.Value, (int) udNbProduitsPresentes.Value, (Professionnel) Globale.lesProfessionnels[idx2], (visiteur) Globale.lesVisiteurs[idx]);
            Globale.lesVisites.Add(laVisite);



            MySqlCommand maCommande = connection.CreateCommand();
            maCommande.CommandText = "insert into tb_visite(numVisite, dateVisite, nbProduitsPresentes, nbProduitsRetenus, matriculeVisiteur, nomPro, prenomPro) " +
                                     "values( " + NumeroVisite + ", '" + DateSelectionnee + "', " + NbProduitsPresentes + ", " + NbProduitsRetenus + ",'" + MatriculeVisiteur + "', '" + NomProfessionnel + "', '" + PrenomProfessionnel + "')";
            connection.Open();
            maCommande.ExecuteReader();
            connection.Close();

            MessageBox.Show("La visite a bien été ajoutée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmVisiteSaisir_Load(object sender, EventArgs e)
        {
            foreach (visiteur unVisiteur in Globale.lesVisiteurs)
            {
                cbVisiteur.Items.Add(unVisiteur.getNom());
            }

            foreach (Professionnel unProfessionnel in Globale.lesProfessionnels)
            {
                cbProfessionnel.Items.Add(unProfessionnel.getNomPro());
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
