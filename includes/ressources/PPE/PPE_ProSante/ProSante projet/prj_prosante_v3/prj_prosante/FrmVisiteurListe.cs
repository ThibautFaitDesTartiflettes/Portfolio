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
    public partial class FrmVisiteurListe : Form
    {
        List<visiteur> liste; // liste des visiteurs
        public FrmVisiteurListe()
        {
            InitializeComponent();
            liste = new List<visiteur>();
            btNrecherche.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmVisiteurListe_Load(object sender, EventArgs e)
        {
            // initiliser la listView
            foreach (visiteur leVisiteur in Globale.lesVisiteurs)
            {
                ListViewItem laLigne = new ListViewItem();

                laLigne.Text = leVisiteur.getMatricule().ToString();
                laLigne.SubItems.Add(leVisiteur.getNom());
                laLigne.SubItems.Add(leVisiteur.getPrenom());
                laLigne.SubItems.Add(leVisiteur.getNumero());
                laLigne.SubItems.Add(leVisiteur.getSecteur());
    

                lvVisiteur.Items.Add(laLigne);

            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRechercher_Click(object sender, EventArgs e)
        {
            if (cbSecteur.Text != "")
            {
                lvVisiteur.Items.Clear(); // j'efface la liste 


               // connexion;
                MySqlConnection connection = Globale.Connexion();
                liste = new List<visiteur>(); 

          
                MySqlCommand maCommande = connection.CreateCommand();
                MySqlDataReader maLigne;
                maCommande.CommandText = "select * from tb_visiteur where vctVisiteur = '" + cbSecteur.Text+"'";       // requête sql
                connection.Open();
                maLigne = maCommande.ExecuteReader();

                // lire le résultat de la requête
                while (maLigne.Read())
                {
                    string[] valeurColonnes = new string[maLigne.FieldCount];
                    for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();

                    string matricule = valeurColonnes[0];
                    string nom = valeurColonnes[1];
                    string prenom = valeurColonnes[2];
                    string num = valeurColonnes[3];
                    string secteur = valeurColonnes[4];
                    visiteur unVisiteur = new visiteur(matricule, nom, prenom, num, secteur);
                    liste.Add(unVisiteur);
                }
                connection.Close();

                // lire la liste 
                foreach (visiteur leVisiteur in liste)
                {
                    ListViewItem laLigne = new ListViewItem();

                    laLigne.Text = leVisiteur.getMatricule().ToString();
                    laLigne.SubItems.Add(leVisiteur.getNom());
                    laLigne.SubItems.Add(leVisiteur.getPrenom());
                    laLigne.SubItems.Add(leVisiteur.getNumero());
                    laLigne.SubItems.Add(leVisiteur.getSecteur());


                    lvVisiteur.Items.Add(laLigne);

                }

                btNrecherche.Enabled = true;





            }
        }

        private void btNrecherche_Click(object sender, EventArgs e)
        {
            lvVisiteur.Items.Clear(); // je rinitialise le listeView
            foreach (visiteur leVisiteur in Globale.lesVisiteurs)
            {
                ListViewItem laLigne = new ListViewItem();

                laLigne.Text = leVisiteur.getMatricule().ToString();
                laLigne.SubItems.Add(leVisiteur.getNom());
                laLigne.SubItems.Add(leVisiteur.getPrenom());
                laLigne.SubItems.Add(leVisiteur.getNumero());
                laLigne.SubItems.Add(leVisiteur.getSecteur());


                lvVisiteur.Items.Add(laLigne);

            }
            btNrecherche.Enabled = false;
        }
    }
}
