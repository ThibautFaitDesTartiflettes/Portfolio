using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prj_prosante
{
    public partial class FrmProfessionnelListeVille : Form
    {
        MySqlConnection connection = Globale.Connexion();
        public FrmProfessionnelListeVille()
        {
            InitializeComponent();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            lvProfessionnelVille.Items.Clear(); //supprime tout les élément de la ListView

            //Crée une nouvelle collection
            List<Professionnel> liste = new List<Professionnel>();

            // fait appel à la base de donnée
            MySqlCommand maCommande = connection.CreateCommand();
            //selectionne dans la table professionnel la ville du professionnel qui est égal à la TextBox de la ville
            maCommande.CommandText = "select * from tb_professionnel where villePro = '" + tbVille.Text + "'"; 
            MySqlDataReader maLigne;
            connection.Open();
            //Execute la requête SQL
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                //selectionne les élément rechercher dans la base de donnée
                string[] valeurColonnes = new string[5];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();

                string nom = valeurColonnes[0];
                string prenom = valeurColonnes[1];
                string specialite = valeurColonnes[2];
                string ville = valeurColonnes[3];
                int annee = Convert.ToInt32(valeurColonnes[4]);

                //Créer un nouveau professionnel à partir des information de la base de donnée
                Professionnel unProfessionnel = new Professionnel(nom, prenom, specialite,ville, annee);
                liste.Add(unProfessionnel);
            }

            //recherche et affiche le prénom, la spécialité, la ville et le nombre d'année d'expérience de chaque professionnel
            foreach (Professionnel leProfessionnel in liste)
            {
                ListViewItem laLigne = new ListViewItem();

                laLigne.Text = leProfessionnel.NomPro;
                laLigne.SubItems.Add(leProfessionnel.getPrenomPro());
                laLigne.SubItems.Add(leProfessionnel.getSpecialite());
                laLigne.SubItems.Add(leProfessionnel.getVille());
                laLigne.SubItems.Add(leProfessionnel.getannee().ToString());

                lvProfessionnelVille.Items.Add(laLigne);
            }

            connection.Close();
        }

        private void FrmProfessionnelListeVille_Load(object sender, EventArgs e)
        {

        }
    }
}
