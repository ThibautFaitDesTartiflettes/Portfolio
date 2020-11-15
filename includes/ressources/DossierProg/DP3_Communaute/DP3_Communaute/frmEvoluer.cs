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
    public partial class frmEvoluer : Form
    {
        public frmEvoluer()
        {
            InitializeComponent();
        }

        public void DeblocageBoutonValider()    //On appelle la méthode pour débloquer le bouton valider
        {
            if (tbNvNiveau.Text != "")  //S'il y a du texte dans la textBox nouveau niveau alors
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
            this.Close();   //On ferme frmEvoluer
        }

        private void frmEvoluer_Load(object sender, EventArgs e)
        {
            //On affiche tous les joueurs qui ont été créés
            foreach (Joueur unJoueur in Globale.lesJoueurs)
            {
                cbJoueur.Items.Add(unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")");
            }
        }

        private void btPasserUnNiveau_Click(object sender, EventArgs e)
        {
            int position = cbJoueur.SelectedIndex;
            //si le niveau stocké dans leJoueurTest est inférieur au nombre maximum de niveau alors
            if (Globale.lesJoueurs.ElementAt(position).getNiveau() < Globale.nbMaxNiveaux)
            {
                Globale.lesJoueurs.ElementAt(position).AugmenterNiveau();                         //On appelle la méthode pour augmenter de 1 niveau
                tbActNiveau.Text = Globale.lesJoueurs.ElementAt(position).getNiveau().ToString(); //On affiche le nouveau niveau
            }
            else
            {
                //Sinon on informe l'utilisateur que la valeur entrée est incorrecte ou excelle le nombre prévu de niveau
                MessageBox.Show("Le nombre entré dépasse le nombre maximum de niveaux", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNvNiveau_TextChanged(object sender, EventArgs e)
        {
            DeblocageBoutonValider();   //On appelle la méthode de déblocage
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            int position = cbJoueur.SelectedIndex;
            //Si le nombre rentré est inférieur ou égal au nombre maximum de niveau alors
            if (int.Parse(tbNvNiveau.Text) <= Globale.nbMaxNiveaux)
            {
                Globale.lesJoueurs.ElementAt(position).setNiveau(int.Parse(tbNvNiveau.Text));     //On stocke la nouvelle valeur du niveau dans LeJoueurTest
                tbActNiveau.Text = Globale.lesJoueurs.ElementAt(position).getNiveau().ToString(); //On affiche la nouvelle valeur dans la textBox niveau actuel
                tbNvNiveau.Clear();                                                               //On vide la textBox nouveau niveau
            }
            else
            {
                //Sinon on informe l'utilisateur que la valeur entrée est incorrecte ou excelle le nombre prévu de niveau
                MessageBox.Show("Le nombre entré dépasse le nombre maximum de niveaux", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNvNiveau.Clear(); //On vide la textBox nouveau niveau
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
                tbActNiveau.Text = Globale.lesJoueurs.ElementAt(position).getNiveau().ToString();
            }
            //Sinon on informe l'utilisateur
            else
            {
                MessageBox.Show("Un problème est survenu avec ce joueur, veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
