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
    public partial class FrmMenu : Form
    {
        private int childFormNumber = 0;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Fenêtre " + childFormNumber++;
            childForm.Show();
        }

        private visiteur rechercherVisiteurVisite(string matricule)
        {
            //recherche d'un visiteur connaissant son matricule
            Boolean trouve = false;
            int idx = 0;
            while (idx < Globale.lesVisiteurs.Count && !trouve)
            {
                if (Globale.lesVisiteurs[idx].getMatricule() == matricule)
                    trouve = true;
                else
                    idx++;
            }
            if (trouve) return Globale.lesVisiteurs[idx]; else return null;
        }

        private Professionnel rechercherProfessionnelVisite(string nom, string prenom)
        {
            //recherche d'un professionnel connaissant son nom et son prénom
            Boolean trouve = false;
            int idx = 0;
            while (idx < Globale.lesProfessionnels.Count && !trouve)
            {
                if (Globale.lesProfessionnels[idx].NomPro == nom)
                    trouve = true;
                else
                    idx++;
            }
            if (trouve) return Globale.lesProfessionnels[idx]; else return null;
        }

        private void OpenFile(object sender, EventArgs e)
        {
            //chargement des données de la base BD_ProSante_V1 dans les collections
            // --> lesVisiteurs
            Globale.lesVisiteurs = new List<visiteur>() ;

          
            MySqlConnection connection = Globale.Connexion();
            
            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "select * from tb_visiteur";
            connection.Open();     
            maLigne = maCommande.ExecuteReader();
         
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[maLigne.FieldCount];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString() ;

                string matricule = valeurColonnes[0];
                string nom = valeurColonnes[1];
                string prenom = valeurColonnes[2];
                visiteur unVisiteur = new visiteur(matricule, nom, prenom);
                Globale.lesVisiteurs.Add(unVisiteur);
            }
            connection.Close();

            // --> lesProfessionnels
            Globale.lesProfessionnels = new List<Professionnel>();

            maCommande = connection.CreateCommand();
            maCommande.CommandText = "select * from tb_professionnel";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[maLigne.FieldCount]; 
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();

                string nom = valeurColonnes[0];
                string prenom = valeurColonnes[1];
                string specialite = valeurColonnes[2];
                Professionnel unProfessionnel = new Professionnel(nom, prenom, specialite);
                Globale.lesProfessionnels.Add(unProfessionnel);
            }
            connection.Close();

            // --> lesVisites
            Globale.lesVisites = new List<visite>();

            maCommande = connection.CreateCommand();
            maCommande.CommandText = "select * from tb_visite";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[maLigne.FieldCount];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();
  
                int numero = int.Parse(valeurColonnes[0]);
                DateTime dateVisite = DateTime.Parse(valeurColonnes[1]);
                int nbProdPres = int.Parse(valeurColonnes[2]);
                int nbProdRet = int.Parse(valeurColonnes[3]);
                string matricule = valeurColonnes[4];
                string nom = valeurColonnes[5];
                string prenom = valeurColonnes[6];

                visiteur leVisiteur = rechercherVisiteurVisite(matricule);
                Professionnel leProfessionnel = rechercherProfessionnelVisite(nom, prenom);

                visite uneVisite = new visite(dateVisite, nbProdRet, nbProdPres,leProfessionnel,leVisiteur);
                Globale.lesVisites.Add(uneVisite);
            
            }
            connection.Close();

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }




       

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void visiteurNouveauOptionMenu_Click(object sender, EventArgs e)
        {
            FrmVisiteurNouveau maFenetre = new FrmVisiteurNouveau();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void visiteurListeOptionMenu_Click(object sender, EventArgs e)
        {
            FrmVisiteurListe maFenetre = new FrmVisiteurListe();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void professionnelNouveauOptionMenu_Click(object sender, EventArgs e)
        {
            FrmProfessionnelNouveau maFenetre = new FrmProfessionnelNouveau();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void professionnelListeTousOptionMenu_Click(object sender, EventArgs e)
        {
            FrmProfessionnelListeTous maFenetre = new FrmProfessionnelListeTous();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void professionnelListeSpecialiteOptionMenu_Click(object sender, EventArgs e)
        {
            FrmProfessionnelListeSpecialite maFenetre = new FrmProfessionnelListeSpecialite();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void visiteSaisirOptionMenu_Click(object sender, EventArgs e)
        {
            FrmVisiteSaisir maFenetre = new FrmVisiteSaisir();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void visiteConsulterOptionMenu_Click(object sender, EventArgs e)
        {
            FrmVisiteConsulter maFenetre = new FrmVisiteConsulter();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void visiteStatistiquesOptionMenu_Click(object sender, EventArgs e)
        {
            FrmVisiteStatistiques maFenetre = new FrmVisiteStatistiques();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAPropos maFenetre = new FrmAPropos();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
