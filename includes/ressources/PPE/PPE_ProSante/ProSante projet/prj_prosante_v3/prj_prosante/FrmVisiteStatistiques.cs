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
            connection = Globale.Connexion();   //On créé la connexion
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme la fenêtre
        }

        private void FrmVisiteStatistiques_Load(object sender, EventArgs e)
        {
            int NbTotalPdtPresentes = 0;    //Nombre total de produit présenté
            int NbTotalPdtRetenus = 0;      //Nombre total de produit retenu

            //On incrémente les variables avec tous les nombres de visites
            foreach (visite uneVisite in Globale.lesVisites)
            {
                NbTotalPdtPresentes += uneVisite.getnbProduitsPresentes();
                NbTotalPdtRetenus += uneVisite.getnbProduitsRetenus();
            }
            Single PctPdtRetenus = ((Single)NbTotalPdtRetenus / (Single)NbTotalPdtPresentes) * 100; //On calcule le pourcentage
            Single MoyDuree = 0;    //Durée moyenne d'une visite
            Single MoyNote = 0;     //Note moyenne d'une visite

            
           

            MySqlCommand maCommande = connection.CreateCommand();   //On créé la commande
            MySqlDataReader maLigne;                                //On initialise la variable maLigne
            maCommande.CommandText = "SELECT AVG(dureePrestation) from tb_visite";  //Contenu de la requête
            connection.Open();  //On créé la connexion
            maLigne = maCommande.ExecuteReader();   //On exécute la commande
            while (maLigne.Read())  //Tant qu'on a pas lu tous les résultats
            {
                string[] valeurColonnes = new string[1];    //On créé un tableau de string à une colonne
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();    //On récupre la valeure contenue dans maLigne et on la convertie en string

                MoyDuree = Single.Parse(valeurColonnes[0]); //On met le résulat dans la variable MoyDuree
            }
            connection.Close(); //On ferme la connexion

            maCommande.CommandText = "SELECT AVG(notePrestation) from tb_visite";   //Contenu de la requête
            connection.Open();  //On créé la connexion
            maLigne = maCommande.ExecuteReader();   //On exécute la commande
            while (maLigne.Read()) //Tant qu'on a pas lu tous les résultats
            {
                string[] valeurColonnes = new string[1];    //On créé un tableau de string à une colonne
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();    //On récupre la valeure contenue dans maLigne et on la convertie en string

                MoyNote = Single.Parse(valeurColonnes[0]);  //On met le résulat dans la variable MoyNote
            }
            connection.Close(); //On ferme la connexion

            tbNbTotalVisites.Text = Globale.lesVisites.Count.ToString();    //On affiche le nombre total de visite
            tbNbProduitsPresentes.Text = NbTotalPdtPresentes.ToString();    //On affiche le nombre total de produits présenté
            tbNbProduitsRetenus.Text = NbTotalPdtRetenus.ToString();        //On affiche le nombre total de produits retenus
            tbPctProduitsRetenus.Text = Math.Round(PctPdtRetenus, 2).ToString() + "%";  //On affiche le pourcentage de produits retenus
            tbMoyTemps.Text =Math.Round((double)MoyDuree,2).ToString(); //On affiche la moyenne du temps des visites
            tbMoyNote.Text =Math.Round((double)MoyNote,2).ToString();   //On affiche la moyenne des notes des visites

            //On rempli la comboBox des professionnels
            foreach (Professionnel unProfessionnel in Globale.lesProfessionnels)
            {
                cbProfessionnel.Items.Add(unProfessionnel.getNomPro() + "  " + unProfessionnel.getPrenomPro());
            }

            //On rempli la comboBox des visiteurs
            foreach (visiteur unVisiteur in Globale.lesVisiteurs)
            {
                cbVisiteur.Items.Add(unVisiteur.getNom() + "  " + unVisiteur.getPrenom());
            }
        }

        private void btnAfficherNbVisitesProfessionnel_Click(object sender, EventArgs e)
        {
            string nomProSelec = cbProfessionnel.SelectedItem.ToString();   //On récupère le nom du professionnel selectionné
            string NbTotalVisitePro = "";   //On initialise le nombre total de visite des professionnels à zéro

           
        

            MySqlCommand maCommande = connection.CreateCommand();   //On créé la commande
            MySqlDataReader maLigne;    //On instancie la variable maLigne
            maCommande.CommandText = "SELECT COUNT(*) FROM tb_visite WHERE nomPro = '" + nomProSelec + "'"; //Contenu de la requête
            connection.Open();  //On créé la connexion
            maLigne = maCommande.ExecuteReader();   //On execute la requête
            while (maLigne.Read())  //Tant qu'on a pas lu tous les résultats
            {
                string[] valeurColonnes = new string[1];    //On créé un tableau de string à une colonne
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();    //On récupre la valeure contenue dans maLigne et on la convertie en string

                NbTotalVisitePro = valeurColonnes[0];   //On met le résulat dans la variable NbTotalVisitePro
            }
            connection.Close(); //On ferme la connexion

            tbNbVisitesProfessionnel.Text = NbTotalVisitePro;   //On affiche le nombre total de visites
        }

        private void btnAfficherNbVisitesVisiteur_Click(object sender, EventArgs e)
        {
            int idVisiteurSelec = cbVisiteur.SelectedIndex; //On récupère l'identifiant du visiteur 
            string matriculeVisiteur = "";  //Matricule du visiteur

            int idx = 0;    //Varibale utile à la recherche
            bool trouve = false;    //Trouve est faux
            visiteur unVisiteur = Globale.lesVisiteurs.ElementAt(idx);  //On créé un visiteur
            while (idx < Globale.lesVisiteurs.Count && !trouve) //Tant que la liste des visiteur n'est pas totalement parcourue et que trouve est faux
            {
                if (idVisiteurSelec == idx) //Si l'identifiant du visiteur est égal à l'index
                {
                    trouve = true;  //trouve passe à vrai
                }
                else
                {   
                    idx++;  //On incrémente l'index
                }
            }
            if (trouve) //Si trouve est vrai
            {
                matriculeVisiteur = Globale.lesVisiteurs[idx].getMatricule();   //On récupère le matricule du visiteur
            }
            else //Sinon on informe l'utilisteur
            {
                MessageBox.Show("Un problème est survenu avec ce visiteur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string NbTotalVisiteVisiteur = "";  //Nombre total de visite du visiteur


            MySqlCommand maCommande = connection.CreateCommand();   //On créé la commande
            MySqlDataReader maLigne;    //On instancie la variable maLigne
            maCommande.CommandText = "SELECT COUNT(*) FROM tb_visite WHERE matriculeVisiteur = '" + matriculeVisiteur + "'";    //Contenu de la requête
            connection.Open();  //On créé la connexion
            maLigne = maCommande.ExecuteReader();   //On execute la commande
            while (maLigne.Read())  //Tant qu'on a pas lu tous les résultats
            {
                string[] valeurColonnes = new string[1];    //On créé un tableau de string à une colonne
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();    //On récupre la valeure contenue dans maLigne et on la convertie en string

                NbTotalVisiteVisiteur = valeurColonnes[0];  //On stocke le résultat dans la variable NbTotalVisiteVisiteur
            }
            connection.Close(); //On ferme la connexion

            tbNbVisitesVisiteur.Text = NbTotalVisiteVisiteur;   //On affiche le nombre total de visite du visiteur
        }

        private void btnAfficherNbVisitesSpecialite_Click(object sender, EventArgs e)
        {
            string specialiteSelec = tbSpecialite.Text; //On récupère la specialite de la textBox
            string NbTotalVisiteSpe = "";   //Nombre total de visite de la specialite

       
     

            MySqlCommand maCommande = connection.CreateCommand();   //On créé la commande
            MySqlDataReader maLigne;    //On instancie la variable ma ligne
            maCommande.CommandText = "SELECT COUNT(*) FROM tb_visite INNER JOIN tb_professionnel on tb_visite.nomPro = tb_professionnel.nomPro WHERE specialitePro = '" + specialiteSelec + "'";    //Contenu de la commande
            connection.Open();  //On créé la connexion
            maLigne = maCommande.ExecuteReader();   //On éxécute la commande
            while (maLigne.Read())  //Tant qu'on a pas lu tous les résultats
            {
                string[] valeurColonnes = new string[1];    //On créé un tableau de string à une colonne
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();    //On récupre la valeure contenue dans maLigne et on la convertie en string

                NbTotalVisiteSpe = valeurColonnes[0]; //On stocke le résultat dans la variable NbTotalVisiteSpe
            }
            connection.Close(); //On ferme la connexion

            tbNbVisitesSpecialite.Text = NbTotalVisiteSpe;  //On affiche le nombre total de visite de la specialite
        }
    }
}
