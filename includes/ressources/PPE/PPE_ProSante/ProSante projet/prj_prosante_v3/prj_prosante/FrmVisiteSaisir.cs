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
    public partial class ud : Form
    {
        MySqlConnection connection;
        public ud()
        {
            InitializeComponent();
            connection = Globale.Connexion();   //Initialisation de la connexion
        }

        int NumeroVisite ;              //Numero de la visite
        string DateSelectionnee ;       //Date selectionnée
        int NbProduitsPresentes ;       //Nombre de produits présentés
        int NbProduitsRetenus;          //Nombre de produits retenus
        int IdVisiteur ;                //Identifiant du visiteur
        int IdProfessionnel ;           //Identifiant du professionnel
        string MatriculeVisiteur = "";  //Matricule du visiteur
        string NomProfessionnel = "";   //Nom du professionnel
        string PrenomProfessionnel = "";//Prenom du professionnel
        int note;                       //Note de la visite
        string temps = "";              //Temps de la visite
        int idx2;                       //Index utile à la recherche bis
        int idx;                        //Index utile à la recherche
        private void btnAjouter_Click(object sender, EventArgs e)
        {
             NumeroVisite = Globale.lesVisites.Count + 1;                               //On récupère le numéro de la visite et on l'incrémente
             DateSelectionnee = mcDateVisite.SelectionStart.ToString("yyyy-MM-dd");     //On récupère la date de la visite selectionnée
             NbProduitsPresentes = int.Parse(udNbProduitsPresentes.Value.ToString());   //On récupère le nombre de produits présentés
             NbProduitsRetenus = int.Parse(udNbProduitsRetenus.Value.ToString());       //On récupère le nombre de produits retenus
             IdVisiteur = cbVisiteur.SelectedIndex;                                     //On récupère l'index du visiteur selectionné dans la comboBox
             IdProfessionnel = cbProfessionnel.SelectedIndex;                           //On récupère l'index du professionnel selectionné dans la comboBox
             MatriculeVisiteur = "";                                                    //On réinitilise le contenu de la variable
             NomProfessionnel = "";                                                     //On réinitilise le contenu de la variable
             PrenomProfessionnel = "";                                                  //On réinitilise le contenu de la variable
             note = int.Parse(udNote.Value.ToString());                                 //On récupère la note
             temps = "";                                                                //On réinitilise le contenu de la variable

            idx = 0;                //On initialise la variable à zéro
            bool trouve = false;    //On initialise la variable de découverte
            visiteur unVisiteur = Globale.lesVisiteurs.ElementAt(idx);      //On créé un visiteur
            while (idx < Globale.lesVisiteurs.Count && !trouve)             //On parcours la collection des visiteurs et tant que trouve est faux
            {
                if (IdVisiteur == idx)  //Si l'identifiant du visiteur est égal à l'identifiant récupéré dans la comboBox
                {
                    trouve = true;  //Trouve devient vrau
                }
                else
                {
                    idx++;  //On incrémente l'index
                }
            }
            if (trouve) //Si quelque chose à été trouvé
            {
                MatriculeVisiteur =Globale.lesVisiteurs[idx].getMatricule();    //On récupère le matricule du visiteur
            }
            else //Sinon on informe l'utilisateur
            {
                MessageBox.Show("Un problème est survenu avec cet utilisateur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            idx2 = 0;               //On initialise la variable à zéro
            bool trouve2 = false;   //On initialise trouve à false
            Professionnel unProfessionnel = Globale.lesProfessionnels.ElementAt(idx2);  //On créé un professionnel
            while (idx2 < Globale.lesProfessionnels.Count && !trouve2)  //On parcours la collection des professionnels et tant que trouve est faux
            {
                if (IdProfessionnel == idx2)    //Si l'identifiant du professionnel est égal à l'identifiant récupéré dans la comboBox
                {
                    trouve2 = true; //Trouve devient vrau
                }
                else
                {
                    idx2++; //On incrémente l'index
                }
            }
            if (trouve2)    //Si quelque chose à été trouvé
            {
                NomProfessionnel = Globale.lesProfessionnels[idx2].getNomPro();         //On récupère le nom du professionnel
                PrenomProfessionnel = Globale.lesProfessionnels[idx2].getPrenomPro();   //On récupère le prénom du professionnel
            }
            else //Sinon on informe l'utilisateur
            {
                MessageBox.Show("Un problème est survenu avec ce professionnel", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Si les informations d'heure et de minutes sont des entiers et que les critères de temps sont respéctés
            if (int.TryParse(tbHeure.Text, out int result) && int.TryParse(tbMinute.Text, out int result2) && int.Parse(tbHeure.Text) < 24 && int.Parse(tbHeure.Text) > 0 && int.Parse(tbMinute.Text) > 0 && int.Parse(tbMinute.Text) < 60)
            {
                temps = tbHeure.Text + " : " + tbMinute.Text;   //On implémente le format HH : mm
                requete();                                      //On appelle la fonction requete
            }
            else  //Sinon on informe l'utilisateur
            {
                MessageBox.Show("Veuillez entrer un temps correct", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public void requete()   //Contient l'implémentation de la base de donnée avec les informations de la textBox
        {
            //On créé un visite avec les informations rentrées
            visite laVisite = new visite(mcDateVisite.SelectionStart, (int)udNbProduitsRetenus.Value, (int)udNbProduitsPresentes.Value, (Professionnel)Globale.lesProfessionnels[idx2], (visiteur)Globale.lesVisiteurs[idx], (int)udNote.Value, temps);
            Globale.lesVisites.Add(laVisite);   //On l'ajoute à la collection des visites

          

            MySqlCommand maCommande = connection.CreateCommand();   //On se connecte à la base de donnée
            //On écrit la commande
            maCommande.CommandText = "insert into tb_visite values( " + NumeroVisite + ", '" + DateSelectionnee + "', " + NbProduitsPresentes + ", " + NbProduitsRetenus + ",'" + MatriculeVisiteur + "', '" + NomProfessionnel + "', '" + PrenomProfessionnel + "', " + note + ", '" + temps + "')";
            connection.Open();  //On se connecte à la base de donnée
            maCommande.ExecuteReader(); //On execute la commande
            connection.Close(); //On ferme la connexion

            //On informe l'utilisateur du succès
            MessageBox.Show("La visite a bien été ajoutée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmVisiteSaisir_Load(object sender, EventArgs e)
        {
            //On rempli la comboBox des visiteurs
            foreach (visiteur unVisiteur in Globale.lesVisiteurs)
            {
                cbVisiteur.Items.Add(unVisiteur.getNom());
            }
            //On rempli la comboBox des professionnels
            foreach (Professionnel unProfessionnel in Globale.lesProfessionnels)
            {
                cbProfessionnel.Items.Add(unProfessionnel.getNomPro());
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme la fenêtre
        }
    }
}
