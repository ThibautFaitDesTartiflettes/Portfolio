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
    public partial class AccesBatimentM2L : Form
    {
        public AccesBatimentM2L()
        {
            InitializeComponent();
            pbVoyant.Image = ListeVoyant.Images[0]; //Initialise le voyant à gris
        }

        public struct MotDePasse
        {
            public string porte_mdp;        //Nom de la porte
            public string date_debut;       //Debut de validite du mot de passe
            public string date_fin;         //Fin de validite du mot de passe
            public string motdepasse_mdp;   //Mot de passe pour la porte
        }

        MotDePasse[] motdepasse = new MotDePasse[100]; //Initialisation d'un tableau contenant les mots de passes

        string ligne_secure;    //variable pour lecture du csv

        int k = 0;              //Variable pour boucler
        int nb_erreurs = 0;     //Variable utile pour compter le nombre d'erreur : 3 erreuse = écriture
        int nb_lettres = 0;     //Variable utile pour le blocage des touches et la longueur du mot de passe
        bool trouve =false;     //Booléen pour la validité du mot de passe

        public void BoutouBloque()
        {
            //Procédure pour le blocage des boutons une fois que le mot de passe à atteint 6 caractères
            if (nb_lettres == 5)
            {
                btlettreA.Enabled = false;
                btlettreB.Enabled = false;
                btlettreC.Enabled = false;
                btlettreD.Enabled = false;
                btlettreE.Enabled = false;
                btlettreF.Enabled = false;
                btlettreG.Enabled = false;
                btlettreH.Enabled = false;
                btlettreI.Enabled = false;
                btlettreJ.Enabled = false;
                btlettreK.Enabled = false;
                btlettreL.Enabled = false;
                btlettreM.Enabled = false;
                btlettreN.Enabled = false;
                btlettreO.Enabled = false;
                btlettreP.Enabled = false;
                btlettreQ.Enabled = false;
                btlettreR.Enabled = false;
                btlettreS.Enabled = false;
                btlettreT.Enabled = false;
                btlettreU.Enabled = false;
                btlettreV.Enabled = false;
                btlettreW.Enabled = false;
                btlettreX.Enabled = false;
                btlettreY.Enabled = false;
                btlettreZ.Enabled = false;
                btnum0.Enabled = false;
                btnum1.Enabled = false;
                btnum2.Enabled = false;
                btnum3.Enabled = false;
                btnum4.Enabled = false;
                btnum5.Enabled = false;
                btnum6.Enabled = false;
                btnum7.Enabled = false;
                btnum8.Enabled = false;
                btnum9.Enabled = false;
                btEnter.Enabled = true;
            }
        }

        public void BoutonDebloque()
        {
            //Procédure de déblocage des boutons si il y a erreur ou appui sur CANCEL
            btlettreA.Enabled = true;
            btlettreB.Enabled = true;
            btlettreC.Enabled = true;
            btlettreD.Enabled = true;
            btlettreE.Enabled = true;
            btlettreF.Enabled = true;
            btlettreG.Enabled = true;
            btlettreH.Enabled = true;
            btlettreI.Enabled = true;
            btlettreJ.Enabled = true;
            btlettreK.Enabled = true;
            btlettreL.Enabled = true;
            btlettreM.Enabled = true;
            btlettreN.Enabled = true;
            btlettreO.Enabled = true;
            btlettreP.Enabled = true;
            btlettreQ.Enabled = true;
            btlettreR.Enabled = true;
            btlettreS.Enabled = true;
            btlettreT.Enabled = true;
            btlettreU.Enabled = true;
            btlettreV.Enabled = true;
            btlettreW.Enabled = true;
            btlettreX.Enabled = true;
            btlettreY.Enabled = true;
            btlettreZ.Enabled = true;
            btnum0.Enabled = true;
            btnum1.Enabled = true;
            btnum2.Enabled = true;
            btnum3.Enabled = true;
            btnum4.Enabled = true;
            btnum5.Enabled = true;
            btnum6.Enabled = true;
            btnum7.Enabled = true;
            btnum8.Enabled = true;
            btnum9.Enabled = true;
        }

        private void AccesBatimentM2L_Load(object sender, EventArgs e)
        {

            //Initialisation du tableau fichiersecure afin de recréer le csv
            StreamReader fichiersecure = new StreamReader("digicod_secure.csv");
            while (!fichiersecure.EndOfStream) //On parcours tout le csv
            {
                ligne_secure = fichiersecure.ReadLine();    //Lecture de la ligne
                string[] colonne = new string[4];           //tableau avec le nombre de colonnes = 4
                colonne = ligne_secure.Split(';');          //Séparation en 4 colonnes

                motdepasse[k].porte_mdp = colonne[0];
                motdepasse[k].date_debut = colonne[1];
                motdepasse[k].date_fin = colonne[2];
                motdepasse[k].motdepasse_mdp = colonne[3];
                k++;
            }
            fichiersecure.Close();  //Fermeture du fichier csv
        }

        private void pbVoyant_Click(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            //Réinitialisation du mot de passe, nombre d'erreur, nombre de lettres et déblocage des boutons
            tbMdp.Text = "";
            nb_erreurs = 0;
            BoutonDebloque();
            nb_lettres = 0;
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            int parcours = 0; //Variable pour parcourir les lignes

            while (parcours < motdepasse.Count() && !trouve) //Tant que parcours est inférieur ou nombre de ligne de motdepasse et que trouve est faux alors:
            {
                //Si le mot de passe entré correspond à celui de csv et qui la porte est E ou T et que le mot de passe est valide alors:
                if (motdepasse[parcours].motdepasse_mdp == tbMdp.Text && motdepasse[parcours].porte_mdp != "I" && DateTime.Compare(DateTime.Parse(motdepasse[parcours].date_fin), DateTime.Today) > 0)
                {
                    //Validation OK
                    trouve = true;
                }
                else
                {
                    //On passe à une autre ligne
                    parcours++;
                }
            }

            if (trouve)
            {
                //Accès autorisé
                MessageBox.Show("Accès autorisé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //Informer l'utilisateur
                pbVoyant.Image = ListeVoyant.Images[2];     //Voyant vert
                AccesSalleInfo settingsForm = new AccesSalleInfo();     //Ouverte du digicode de la salle informatique
                settingsForm.Show();
            }
            else
            {
                nb_erreurs++; //On incrémente nb_erreurs
                MessageBox.Show("Accès refusé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); //On informe de l'erreur

                if (nb_erreurs == 3)
                {
                    //Accès refusé
                    pbVoyant.Image = ListeVoyant.Images[1]; //Voyant rouge

                    StreamWriter refusacces = new StreamWriter("digicod_erreur.csv", true); //Ouverture pour écriture du csv erreur

                    string lignes = "" + ";" + DateTime.Now.Day + "/" + DateTime.Now.Month +"/" + DateTime.Now.Year + ";" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ";" + "E"; //Structure des colonnes et informations à rentrer
                    refusacces.WriteLine(lignes); //Ecriture dans le csv
                    refusacces.Close(); //Fermeture du csv
                }
            }
        }

        private void btnum1_Click(object sender, EventArgs e)
        {
            BoutouBloque();     //Appel de la procédure pour bloquer les boutons
            tbMdp.Text += "1";  //Ajout du caractère "1" dans la TextBox
            nb_lettres++;       //Incrémentation de nb_lettres
        }

        private void btnum2_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "2";
            nb_lettres++;
        }

        private void btnum3_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "3";
            nb_lettres++;
        }

        private void btnum4_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "4";
            nb_lettres++;
        }

        private void btnum5_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "5";
            nb_lettres++;
        }

        private void btnum6_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "6";
            nb_lettres++;
        }

        private void btnum7_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "7";
            nb_lettres++;
        }

        private void btnum8_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "8";
            nb_lettres++;
        }

        private void btnum9_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "9";
            nb_lettres++;
        }

        private void btnum0_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "0";
            nb_lettres++;
        }

        private void btlettreA_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "A";
            nb_lettres++;
        }

        private void btlettreB_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "B";
            nb_lettres++;
        }

        private void btlettreC_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "C";
            nb_lettres++;
        }

        private void btlettreD_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "D";
            nb_lettres++;
        }

        private void btlettreE_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "E";
            nb_lettres++;
        }

        private void btlettreF_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "F";
            nb_lettres++;
        }

        private void btlettreG_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "G";
            nb_lettres++;
        }

        private void btlettreH_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "H";
            nb_lettres++;
        }

        private void btlettreI_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "I";
            nb_lettres++;
        }

        private void btlettreJ_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "J";
            nb_lettres++;
        }

        private void btlettreK_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "K";
            nb_lettres++;
        }

        private void btlettreL_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "L";
            nb_lettres++;
        }

        private void btlettreM_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "M";
            nb_lettres++;
        }

        private void NbtlettreN_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "N";
            nb_lettres++;
        }

        private void btlettreO_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "O";
            nb_lettres++;
        }

        private void btlettreP_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "P";
            nb_lettres++;
        }

        private void btlettreQ_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "Q";
            nb_lettres++;
        }

        private void btlettreR_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "R";
            nb_lettres++;
        }

        private void btlettreS_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "S";
            nb_lettres++;
        }

        private void btlettreT_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "T";
            nb_lettres++;
        }

        private void btlettreU_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "U";
            nb_lettres++;
        }

        private void btlettreV_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "V";
            nb_lettres++;
        }

        private void btlettreW_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "W";
            nb_lettres++;
        }

        private void btlettreX_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "X";
            nb_lettres++;
        }

        private void btlettreY_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "Y";
            nb_lettres++;
        }

        private void btlettreZ_Click(object sender, EventArgs e)
        {
            BoutouBloque();
            tbMdp.Text += "Z";
            nb_lettres++;
        }

        private void tbMdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbDigicode_Enter(object sender, EventArgs e)
        {

        }
    }
}
