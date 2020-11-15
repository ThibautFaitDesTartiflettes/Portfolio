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
    public partial class FrmVisiteurNouveau : Form
    {
        MySqlConnection connection;
        public FrmVisiteurNouveau()
        {
            InitializeComponent();
            // connexion au serveur;      
            connection = Globale.Connexion();
        }  

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // création du visiteur à ajouter
            visiteur leVisiteur = new visiteur(tbMatriculeVisiteur.Text, tbNomVisiteur.Text, tbPrenomVisiteur.Text,tbNum.Text,cbSecteur.Text);
            
            // requête sql
            MySqlCommand maCommande = connection.CreateCommand();
            maCommande.CommandText = "insert into tb_visiteur (matriculeVisiteur,nomVisiteur,prenomVisiteur,numVisiteur,vctVisiteur) values ('"+leVisiteur.getMatricule()+"','"+leVisiteur.getNom()+"','"+leVisiteur.getPrenom()+"','"+leVisiteur.getNumero()+"','"+leVisiteur.getSecteur()+"')";
            connection.Open();
            maCommande.ExecuteReader(); // j'éxecute ma requête
            connection.Close();
            Globale.lesVisiteurs.Add(leVisiteur); // j'ajoute mon visiteur dans ma liste
            MessageBox.Show("Le visiteur a bien été ajouté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ;

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
