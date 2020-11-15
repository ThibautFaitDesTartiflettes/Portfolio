using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP3_Communaute
{
    public partial class frmVoirCommunaute : Form
    {
        public frmVoirCommunaute()
        {
            InitializeComponent();
        }

        private void frmVoirCommunaute_Load(object sender, EventArgs e)
        {
            //On affiche tous les joueurs qui ont été créés
            foreach (Communaute uneCommunaute in Globale.lesCommunautes)
            {
                cbCommunaute.Items.Add(uneCommunaute.getNom());
            }
        }

        private void cbJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = cbCommunaute.SelectedIndex;  //On recupère l'index de l'élément choisi
            int idx = 0;                            //Variable utile au parcours
            bool trouve = false;                    //Variable utile à l'affichage

            //Tant que la collection n'as pas été parcourue totalement et que trouve est faux alors
            while (idx < Globale.lesCommunautes.Count && !trouve)
            {
                //Si l'index de l'élément choisi est égal à la variable de parcours alors
                if (position == idx)
                {
                    trouve = true;  //Trouve passe à true
                }
                else
                {
                    idx++;  //On regarde l'élément suivant
                }
            }

            //Si on à trouvé quelque chose alors on affiche
            if (trouve)
            {
                tbNom.Text = Globale.lesCommunautes.ElementAt(position).getNom();
                tbFondateur.Text = Globale.lesCommunautes.ElementAt(position).getFondateur();
                pbLogo.Image = Globale.lesCommunautes.ElementAt(position).getLogo();
                tbDateCreation.Text = Globale.lesCommunautes.ElementAt(position).getDateCreation().ToString("d");
                tbNbMembres.Text = Globale.lesCommunautes.ElementAt(position).nombreMembre().ToString();

                foreach (Joueur unJoueur in Globale.lesCommunautes.ElementAt(position).getLesMembres())
                {
                    cbMembres.Items.Add(unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")");
                }
            }
            //Sinon on informe l'utilisateur
            else
            {
                MessageBox.Show("Un problème est survenu avec ce joueur, veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmVoirCommunaute
        }
    }
}
