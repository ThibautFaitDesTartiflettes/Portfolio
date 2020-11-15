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

            connection = Globale.Connexion();
        }  

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // mon visiteur à ajouter
            visiteur leVisiteur = new visiteur(tbMatriculeVisiteur.Text, tbNomVisiteur.Text, tbPrenomVisiteur.Text);
       

            // ma requête
            MySqlCommand maCommande = connection.CreateCommand();
            maCommande.CommandText = "insert into tb_visiteur (matriculeVisiteur,nomVisiteur,prenomVisiteur) values ('"+leVisiteur.getMatricule()+"','"+leVisiteur.getNom()+"','"+leVisiteur.getPrenom()+"' )";
            Console.WriteLine(maCommande.CommandText);
            connection.Open();
            maCommande.ExecuteReader();
            connection.Close();
            Globale.lesVisiteurs.Add(leVisiteur);
            MessageBox.Show("Le visiteur a bien été ajouté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVisiteurNouveau_Load(object sender, EventArgs e)
        {

        }
    }
}
