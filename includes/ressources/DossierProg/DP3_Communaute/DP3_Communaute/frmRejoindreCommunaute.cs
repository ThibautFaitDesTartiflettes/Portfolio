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
    public partial class frmRejoindreCommunaute : Form
    {
        public frmRejoindreCommunaute()
        {
            InitializeComponent();
        }

        public void DeblocageBoutonRejoindre()
        {
            if (cbCommunaute.Text != "" && cbJoueur.Text != "")
            {
                btRejoindre.Enabled = true;
            }
            else
            {
                btRejoindre.Enabled = false;
            }
        }

        private void frmRejoindreCommunaute_Load(object sender, EventArgs e)
        {
            //On affiche toutes les communautés qui ont été créés
            foreach (Communaute uneCommunaute in Globale.lesCommunautes)
            {
                cbCommunaute.Items.Add(uneCommunaute.getNom());
            }

            //On affiche tous les joueurs
            foreach (Joueur unJoueur in Globale.lesJoueurs)
            {
                cbJoueur.Items.Add(unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")");
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmRejoindreCommunaute
        }

        private void btRejoindre_Click(object sender, EventArgs e)
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

            //Si on à trouvé le joueur alors
            if (trouve)
            {
                //Si le joueur n'a pas de communauté alors
                if (Globale.lesJoueurs.ElementAt(position).getCommunaute() != "")
                {
                    //On informe l'utilisateur
                    MessageBox.Show("Ce joueur appartient déjà une communauté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //On renseinge le nom de la communauté dans l'objet
                    Globale.lesJoueurs.ElementAt(position).setCommunaute(Globale.lesCommunautes.ElementAt(cbCommunaute.SelectedIndex).getNom());
                    //On l'ajoute à la liste des membres
                    Globale.lesCommunautes.ElementAt(cbCommunaute.SelectedIndex).ajouterMembre(Globale.lesJoueurs.ElementAt(position));
                    //On informe l'utilisateur
                    MessageBox.Show("Vous avez rejoint la communauté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //Sinon on informe l'utilisateur
            else
            {
                MessageBox.Show("Un problème est survenu avec ce joueur, veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeblocageBoutonRejoindre();
        }

        private void cbCommunaute_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeblocageBoutonRejoindre();
        }
    }
}
