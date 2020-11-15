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
    public partial class frmModifMail : Form
    {
        public frmModifMail()
        {
            InitializeComponent();
        }

        public void DeblocageBoutonValider()    //On définit si le bouton Valider peut être déverouillé
        {
            if (tbNvMail.Text != "")  //S'il y a du texte dans la PictureBox du nouveau mail alors
            {
                btValider.Enabled = true;   //On débloque le bouton Valider
            }
            else
            {
                btValider.Enabled = false;  //Il reste bloqué
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmModifMail
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            int position = cbJoueur.SelectedIndex;
            if (tbNvMail.Text.Contains("@") == true && tbNvMail.Text.Contains(".") == true) //Si le nouveau mail contient un "." et un "@" alors il est valide donc
            {
                Globale.lesJoueurs.ElementAt(position).setMail(tbNvMail.Text);        //On stocke le nouveau mail à la place de l'ancien
                tbActMail.Text = Globale.lesJoueurs.ElementAt(position).getMail();    //On affiche le nouveau mail dans la textBox du mail actuel
                tbNvMail.Clear();                                                     //On vide la textBox nouveau mail
            }
            else
            {
                //Sinon on prévient l'utilisateur que sont adresse email n'est pas valide
                MessageBox.Show("Le mail ne répond pas aux critères de validités, veuillez vérifier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmModifMail_Load(object sender, EventArgs e)
        {
            //On affiche tous les joueurs qui ont été créés
            foreach (Joueur unJoueur in Globale.lesJoueurs)
            {
                cbJoueur.Items.Add(unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")");
            }
        }

        private void tbNvMail_TextChanged(object sender, EventArgs e)
        {
            DeblocageBoutonValider();   //On appelle la méthode de déblocage
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
                tbActMail.Text = Globale.lesJoueurs.ElementAt(position).getMail();
            }
            //Sinon on informe l'utilisateur
            else
            {
                MessageBox.Show("Un problème est survenu avec ce joueur, veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
