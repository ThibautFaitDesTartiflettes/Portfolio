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
    public partial class frmVoirJoueur : Form
    {
        public frmVoirJoueur()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmVoirJoueur
        }

        private void cbJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = cbJoueur.SelectedIndex;  //On recupère l'index de l'élément choisi
            int idx = 0;                            //Variable utile au parcours
            bool trouve = false;                    //Variable utile à l'affichage

            //Tant que la collection n'as pas été parcourue totalement et que trouve est faux alors
            while (idx < Globale.lesJoueurs.Count && !trouve)
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
                tbNom.Text = Globale.lesJoueurs.ElementAt(position).getNom();
                tbPrenom.Text = Globale.lesJoueurs.ElementAt(position).getPrenom();
                tbMail.Text = Globale.lesJoueurs.ElementAt(position).getMail();
                tbPseudo.Text = Globale.lesJoueurs.ElementAt(position).getPseudo();
                pbAvatar.Image = Globale.lesJoueurs.ElementAt(position).getAvatar();
                tbNiveau.Text = Globale.lesJoueurs.ElementAt(position).getNiveau().ToString();
                tbScore.Text = Globale.lesJoueurs.ElementAt(position).getScore().ToString();
                tbCommunaute.Text = Globale.lesJoueurs.ElementAt(position).getCommunaute();

                //Si le joueur n'appartient pas à une communaute
                if (tbCommunaute.Text == "")
                {
                    tbCommunaute.Text = "AUCUNE";   //On affiche aucune
                }
            }
            //Sinon on informe l'utilisateur
            else
            {
                MessageBox.Show("Un problème est survenu avec ce joueur, veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmVoirJoueur_Load(object sender, EventArgs e)
        {
            //On affiche tous les joueurs qui ont été créés
            foreach (Joueur unJoueur in Globale.lesJoueurs)
            {
                cbJoueur.Items.Add(unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
