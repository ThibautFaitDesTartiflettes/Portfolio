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
    public partial class frmPoints : Form
    {
        public frmPoints()
        {
            InitializeComponent();
        }

        public void DeblocageBoutonValider()    //On appelle la méthode pour débloquer le bouton valider
        {
            if (tbNvPoint.Text != "")   //S'il y a du texte dans la textBox nouveau point alors
            {
                btValider.Enabled = true;   //On débloque le bouton Valider
            }
            else
            {
                btValider.Enabled = false;  //Sinon on le laisse bloqué
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmPoints
        }

        private void tbNvPoint_TextChanged(object sender, EventArgs e)
        {
            DeblocageBoutonValider();   //On appelle la méthode de déblocage
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            int position = cbJoueur.SelectedIndex;
            //Si le score en entré est supérieur ou égal au score maximum
            if (int.Parse(tbNvPoint.Text) >= Globale.plafondScore)
            {
                //Si le joueur à atteint le niveau maximum
                if (Globale.lesJoueurs.ElementAt(position).NiveauMaxAtteint())
                {
                    //On l'en informe
                    MessageBox.Show("Vous avez atteint le dernier niveau, vous avez gagné", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Globale.lesJoueurs.ElementAt(position).AugmenterScore(Globale.plafondScore);        //On met son score au maximum
                    tbActPoint.Text = Globale.lesJoueurs.ElementAt(position).getScore().ToString();     //On affiche le nouveau niveau
                    tbNvPoint.Clear();  //On vide la textBox nouveau point
                }
                else
                {
                    //Sinon on le fait passer au niveau supérieur et on remet son score à zéro et on l'informe
                    MessageBox.Show("Vous avez dépassé le plafond de score vous avez monté d'un niveau", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Globale.lesJoueurs.ElementAt(position).AugmenterScore(0);                                                   //On remet son score à zéro
                    Globale.lesJoueurs.ElementAt(position).setNiveau(Globale.lesJoueurs.ElementAt(position).getNiveau() + 1);   //On augmente son niveau de 1
                    tbActPoint.Text = Globale.lesJoueurs.ElementAt(position).getScore().ToString();                             //On affiche le nouveau niveau
                    tbNvPoint.Clear();                                                                                          //On vide la textBox nouveau point
                }
            }
            else
            {
                //Sinon on remplace juste les points
                Globale.lesJoueurs.ElementAt(position).AugmenterScore(int.Parse(tbNvPoint.Text)); //On remplace le score du joueur par le score en entré
                tbActPoint.Text = Globale.lesJoueurs.ElementAt(position).getScore().ToString();   //On affiche le nouveau score
                tbNvPoint.Clear();                                                                //On vide la textBox nouveau point
            }
        }

        private void frmPoints_Load(object sender, EventArgs e)
        {
            //On affiche tous les joueurs qui ont été créés
            foreach (Joueur unJoueur in Globale.lesJoueurs)
            {
                cbJoueur.Items.Add(unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")");
            }
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
                tbActPoint.Text = Globale.lesJoueurs.ElementAt(position).getScore().ToString();
            }
            //Sinon on informe l'utilisateur
            else
            {
                MessageBox.Show("Un problème est survenu avec ce joueur, veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
