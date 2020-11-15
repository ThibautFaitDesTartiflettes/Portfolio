using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace digicod_erreur_meslin
{
    public partial class ErreurConnexion : Form
    {
        public ErreurConnexion()
        {
            InitializeComponent();
        }

        public struct Erreur
        {
            public string matricule;    //Matricule de la personne essayant d'entrer
            public string date;         //Date de l'erreur
            public string heure;        //Heure de l'erreur (heure:minute)
            public string porte;        //Nom de la porte
        }

        Erreur[] listeerreurs = new Erreur[100]; //Initialisation du tableau listeerreurs de dimension 100

        int i = 0; //Variable pour boucler

        string ligne;   //Variable pour lecture du csv

        private void ErreurConnexion_Load(object sender, EventArgs e)
        {
            StreamReader fichiererreur = new StreamReader("digicod_erreur.csv");    //Lecture csv erreur

            while (!fichiererreur.EndOfStream) //On parcours tout le csv
            {
                ligne = fichiererreur.ReadLine();   //Lecture de la ligne
                string[] colonnes = new string[4];  //Initialisation d'un tableau à 4 colonnes
                colonnes = ligne.Split(';');        //Création des colonnes

                listeerreurs[i].matricule = colonnes[0];
                listeerreurs[i].date = colonnes[1];
                listeerreurs[i].heure = colonnes[2];
                listeerreurs[i].porte = colonnes[3];
                i++;
            }

            for (int j = 0; j < listeerreurs.Length; j++) //Affichage des lignes
            {
                ListViewItem ligne = new ListViewItem();    //Instanciation d'une ListView

                ligne.Text = listeerreurs[j].ToString(); //Conversion en string

                ligne.Text = listeerreurs[j].matricule;
                ligne.SubItems.Add(listeerreurs[j].date);
                ligne.SubItems.Add(listeerreurs[j].heure);
                ligne.SubItems.Add(listeerreurs[j].porte);

                lvErreur.Items.Add(ligne); //Ajout de la ligne au tableau
            }
        }
    }
}
