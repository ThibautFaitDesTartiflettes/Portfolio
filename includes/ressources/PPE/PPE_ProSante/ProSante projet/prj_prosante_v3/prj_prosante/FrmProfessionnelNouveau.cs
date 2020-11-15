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
    public partial class FrmProfessionnelNouveau : Form
    {
        MySqlConnection connection;
        public FrmProfessionnelNouveau()
        {
            InitializeComponent();
            MySqlConnection connection = Globale.Connexion();
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // fait appel à la base de donnée
            MySqlCommand maCommande = connection.CreateCommand();
            //Insert dans la base de donnée les valeurs des textBox nom,prénom,spécialité,ville et année d'expérience
            maCommande.CommandText = "INSERT INTO tb_professionnel VALUES ('" + tbNomProfessionnel.Text + "', '" + tbPrenomProfessionnel.Text + "', '" + tbSpecialiteProfessionnel.Text + "', '" + tbProfessionnelVille.Text + "','" + tbProfessionnelAnnee.Text + "')";
            connection.Open();
            //Exécute la requête SQL
            maCommande.ExecuteReader();

            //Créer un nouveau professionnel à partir des information des TextBox
            Professionnel leProfessionnel = new Professionnel(tbNomProfessionnel.Text, tbPrenomProfessionnel.Text, tbSpecialiteProfessionnel.Text,tbProfessionnelVille.Text, Convert.ToInt32(tbProfessionnelAnnee.Text));
            Globale.lesProfessionnels.Add(leProfessionnel);
            //informe l'utilisateur que le professionnel à bien été créé
            MessageBox.Show("Le professionnel a bien été créé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            connection.Close();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            //Ferme la page
            this.Close();
        }

        private void FrmProfessionnelNouveau_Load(object sender, EventArgs e)
        {

        }
    }
}
