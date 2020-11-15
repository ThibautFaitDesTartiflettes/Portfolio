using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP2_MDI
{
    public partial class frmPoints : Form
    {
        public frmPoints()
        {
            InitializeComponent();

            tbActPoint.Text = Globale.leJoueurTest.getScore().ToString();   //On affiche le score stocké dans leJoueurTest
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

        private void frmPoints_Load(object sender, EventArgs e)
        {
            
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            //Si le score en entré est supérieur ou égal au score maximum
            if (int.Parse(tbNvPoint.Text) >= Globale.plafondScore)
            {
                //Si le joueur à atteint le niveau maximum
                if (Globale.leJoueurTest.NiveauMaxAtteint())
                {
                    //On l'en informe
                    MessageBox.Show("Vous avez atteint le dernier niveau, vous avez gagné", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbNvPoint.Clear();  //On vide la textBox nouveau point
                }
                else
                {
                    //Sinon on le fait passer au niveau supérieur et on remet son score à zéro et on l'informe
                    MessageBox.Show("Vous avez dépassé le plafond de score vous avez monté d'un niveau", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Globale.leJoueurTest.AugmenterScore(0);                                 //On remet son score à zéro
                    Globale.leJoueurTest.setNiveau(Globale.leJoueurTest.getNiveau() + 1);   //On augmente son niveau de 1
                    tbActPoint.Text = Globale.leJoueurTest.getScore().ToString();           //On affiche le nouveau niveau
                    tbNvPoint.Clear();                                                      //On vide la textBox nouveau point
                }
            }
            else
            {
                //Sinon on remplace juste les points
                Globale.leJoueurTest.AugmenterScore(int.Parse(tbNvPoint.Text)); //On remplace le score du joueur par le score en entré
                tbActPoint.Text = Globale.leJoueurTest.getScore().ToString();   //On affiche le nouveau score
                tbNvPoint.Clear();                                              //On vide la textBox nouveau point
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

        private void frmPoints_Load_1(object sender, EventArgs e)
        {

        }
    }
}
