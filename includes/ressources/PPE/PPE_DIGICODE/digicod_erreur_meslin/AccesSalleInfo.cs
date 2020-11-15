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
    public partial class AccesSalleInfo : Form
    {
        public AccesSalleInfo()
        {
            InitializeComponent();
            pbVoyant.Image = ListeVoyant.Images[0]; //Voyant vide
        }
        public struct Erreur
        {
            public string matricule;    //Matricule de l'employé sur la porte
            public string date;         //Date de l'erreur
            public string heure;        //Heure de l'erreur (heure:minute)
            public string porte;        //Nom de la porte
        }

        Erreur[] listeerreurs = new Erreur[100]; //Initialisation du tableau listeerreurs de dimension 100

        public struct Personnel
        {
            public string matricule_perso;  //Matricule de l'employé
            public string nom;              //Nom de l'employé
            public string prenom;           //Prenom de l'employé
            public string authorisation;    //Authorisation du nom de porte (E,I ou T)
        }

        Personnel[] listepersonnel = new Personnel[100]; //Initialisation du tableau listepersonnel de dimension 100

        public struct MotDePasse
        {
            public string porte_mdp;        //Nom de porte
            public string date_debut;       //Date de debut de validité du mot de passe
            public string date_fin;         //Date de fin de validité du mot de passe
            public string motdepasse_mdp;   //Mot de passe de la porte
        }

        MotDePasse[] motdepasse = new MotDePasse[100]; //Initialisation du tableau motdepasse de dimension 100

        string ligne; //Variable pour la lecture du csv

        int i = 0; //Variable pour boucler
        int j = 0; //Variable pour boucler
        int nb_erreurs = 0; //Compteur des erreurs
        int nb_lettres = 0; //Compteur du nombre de lettres
        bool trouve_perso = false;  //Validité du matricule
        bool trouve_mdp = false;    //Validité du mot de passe

        public void BoutouBloque()
        {
            //Bloque les boutons quand il y a 10 lettres (4 matricules + 6 mot de passe)
            if (nb_lettres == 9)
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
            //Débloque le boutons si appui sur CANCEL ou erreur
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

        TextBox selectedTextBox; //Instanciation de la variable de choix de TextBox

        private void AccesSalleInfo_Load(object sender, EventArgs e)
        {
            selectedTextBox = tbMatricule; //TextBox avec le curseur au lancement

            StreamReader fichiersecure = new StreamReader("digicod_secure.csv");    //Lecture du csv secure
            StreamReader ficherpersonnel = new StreamReader("digicod_perso.csv");   //Lecture du csv perso

            while (!ficherpersonnel.EndOfStream) //On parcours tout le csv
            {
                ligne = ficherpersonnel.ReadLine(); //Lecture de la ligne
                string[] colonnes = new string[4];  //Création d'un tableau de dimension 4
                colonnes = ligne.Split(';');        //Création de 4 colonnes

                listepersonnel[i].matricule_perso = colonnes[0];
                listepersonnel[i].nom = colonnes[1];
                listepersonnel[i].prenom = colonnes[2];
                listepersonnel[i].authorisation = colonnes[3];
                i++;
            }

            while (!fichiersecure.EndOfStream) //Parcoursde de tout le csv
            {
                ligne = fichiersecure.ReadLine();   //Lecture de la ligne
                string[] colonnes = new string[4];  //Création d'un tableau de dimension 4
                colonnes = ligne.Split(';');        //Création de 4 colonnes

                motdepasse[j].porte_mdp = colonnes[0];
                motdepasse[j].date_debut = colonnes[1];
                motdepasse[j].date_fin = colonnes[2];
                motdepasse[j].motdepasse_mdp = colonnes[3];
                j++;
            }
        }

        private void btnum1_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "1"; //Ajout du caracrère "1" à la TextBox selectionnée
            BoutouBloque();              //Appel de la procédure de blocage des boutons
            nb_lettres++;                //Incrémentation de nb_lettres

            if (nb_lettres >= 4)    //Si nb_lettres = 4 alors on passe à la TextBox mdp
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btnum2_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "2";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btnum3_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "3";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btnum4_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "4";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btnum5_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "5";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btnum6_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "6";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btnum7_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "7";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btnum8_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "8";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btnum9_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "9";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btnum0_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "0";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreA_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "A";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreB_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "B";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreC_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "C";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreD_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "D";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreE_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "E";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreF_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "F";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreG_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "G";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreH_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "H";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreI_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "I";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreJ_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "J";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreK_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "K";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreL_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "L";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreM_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "M";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void NbtlettreN_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "N";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreO_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "O";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreP_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "P";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreQ_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "Q";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreR_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "R";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreS_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "S";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreT_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "T";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreU_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "U";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreV_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "V";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreW_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "W";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreX_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "X";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreY_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "Y";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres >= 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btlettreZ_Click(object sender, EventArgs e)
        {
            selectedTextBox.Text += "Z";
            BoutouBloque();
            nb_lettres++;

            if (nb_lettres == 4)
            {
                selectedTextBox = tbMdp;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbMdp.Text = "";                //Rien dans la tbMdp
            tbMatricule.Text = "";          //Rien dans la tbMatricule
            nb_erreurs = 0;                 //Réinitialisation du nombre d'erreur
            BoutonDebloque();               //Appel de la procédure de déblocage
            nb_lettres = 0;                 //Réinitialisation du nombre de lettres
            selectedTextBox = tbMatricule;  //On reselection la TextBox matricule
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            int parcours_matricule = 0;     //Variable pour parcourir les lignes du csv matricule
            int parcours_motdepasse = 0;    //Variable pour parcourir les lignes du csv motdepasse

            while (parcours_matricule < listepersonnel.Count() && !trouve_perso) //Tant que parcours est inférieur ou nombre de ligne dans listepersonnel et que le matricule n'est pas trouvé:
            {
            
                if (listepersonnel[parcours_matricule].matricule_perso == tbMatricule.Text) //Si le matricule correspond à un du csv alors :
                {
                    trouve_perso = true; //Matricule correct
                }
                else
                {
                    parcours_matricule++; //On passe à une autre ligne
                }
            }

            while (parcours_motdepasse < motdepasse.Count() && !trouve_mdp) //Tant que parcours est inférieur ou nombre de ligne de motdepasse et que trouve est faux alors:
            {
                //Si le mot de passe entré correspond à celui de csv et qui la porte est E ou T et que le mot de passe est valide alors:
                if (motdepasse[parcours_motdepasse].motdepasse_mdp == tbMdp.Text && motdepasse[parcours_motdepasse].porte_mdp != "E" && DateTime.Compare(DateTime.Parse(motdepasse[parcours_motdepasse].date_fin), DateTime.Today) > 0)
                {
                    trouve_mdp = true; //Mot de passe trouvé
                }
                else
                {
                    parcours_motdepasse++; //On passe à une autre ligne
                }
            }

            if (trouve_perso && trouve_mdp) //Si le Matricule est trouvé et que le mot de passe est correct
            {
                //Accès autirosé
                MessageBox.Show("Accès autorisé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //On informe l'utilisateur
                pbVoyant.Image = ListeVoyant.Images[2]; //Voyant vert
            }
            else
            {
                nb_erreurs++; //On incrémente nb_erreurs
                MessageBox.Show("Accès refusé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); //On informe l'utilisateur

                if (nb_erreurs == 3) //Si nb_erreur est égal à 3
                {
                    pbVoyant.Image = ListeVoyant.Images[1]; //Voyant rouge

                    StreamWriter refusacces = new StreamWriter("digicod_erreur.csv", true); //Ouverture du csv

                    string lignes = tbMatricule.Text + ";" + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + ";" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ";" + "E"; //Structure d'ecriture dans le csv
                    refusacces.WriteLine(lignes); //Ecriture dans le csv
                    refusacces.Close(); //Fermeture du csv
                }
            }
        }
    }
}
