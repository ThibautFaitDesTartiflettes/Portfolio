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

        private void frmEvoluer_Load(object sender, EventArgs e)
        {
            tbActNiveau.Text = Globale.leJoueurTest.getNiveau().ToString(); //On affiche le niveau stocké dans leJoueurTest
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmEvoluer
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            //Si le nombre rentré est inférieur ou égal au nombre maximum de niveau alors
            if (int.Parse(tbNvNiveau.Text) <= Globale.nbMaxNiveaux)
            {
                Globale.leJoueurTest.setNiveau(int.Parse(tbNvNiveau.Text));     //On stocke la nouvelle valeur du niveau dans LeJoueurTest
                tbActNiveau.Text = Globale.leJoueurTest.getNiveau().ToString(); //On affiche la nouvelle valeur dans la textBox niveau actuel
                tbNvNiveau.Clear();                                             //On vide la textBox nouveau niveau
            }
            else
            {
                //Sinon on informe l'utilisateur que la valeur entrée est incorrecte ou excelle le nombre prévu de niveau
                MessageBox.Show("Le nombre entré dépasse le nombre maximum de niveaux", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNvNiveau.Clear(); //On vide la textBox nouveau niveau
            }
        }

        private void tbNvNiveau_TextChanged(object sender, EventArgs e)
        {
            DeblocageBoutonValider();   //On appelle la méthode de déblocage
        }

        private void btPasserUnNiveau_Click(object sender, EventArgs e)
        {
            //si le niveau stocké dans leJoueurTest est inférieur au nombre maximum de niveau alors
            if (Globale.leJoueurTest.getNiveau() < Globale.nbMaxNiveaux)
            {
                Globale.leJoueurTest.AugmenterNiveau();                         //On appelle la méthode pour augmenter de 1 niveau
                tbActNiveau.Text = Globale.leJoueurTest.getNiveau().ToString(); //On affiche le nouveau niveau
            }
            else
            {
                //Sinon on informe l'utilisateur que la valeur entrée est incorrecte ou excelle le nombre prévu de niveau
                MessageBox.Show("Le nombre entré dépasse le nombre maximum de niveaux", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
