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
    public partial class frmClassementJoueurCommunaute : Form
    {
        public frmClassementJoueurCommunaute()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmClassementJoueurCommunaute
        }

        private void frmClassementJoueurCommunaute_Load(object sender, EventArgs e)
        {
            //On affiche toutes les communautés qui ont été créés
            foreach (Communaute uneCommunaute in Globale.lesCommunautes)
            {
                cbCommunaute.Items.Add(uneCommunaute.getNom());
            }
        }

        private void cbCommunaute_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvClassement.Items.Clear();             //On vide la listView car on change de communauté
            int numero = 1;                         //Variable utile au renseignement de la position du joueur
            Comparer.TrierNiveau();

            //On parcours tous les joueurs
            foreach (Joueur unJoueur in Globale.lesJoueurs)
            {
                //Si le joueur appartient à la communauté alors
                if (unJoueur.getCommunaute() == Globale.lesCommunautes.ElementAt(cbCommunaute.SelectedIndex).getNom())
                {
                    //affichage des joueurs
                    ListViewItem ligne = new ListViewItem();
                    ligne.Text = numero.ToString();
                    ligne.SubItems.Add(unJoueur.getPseudo());
                    ligne.SubItems.Add(unJoueur.getNom() + " " + unJoueur.getPrenom());
                    ligne.SubItems.Add(unJoueur.getNiveau().ToString());
                    ligne.SubItems.Add(unJoueur.getScore().ToString());
                    lvClassement.Items.Add(ligne);

                    numero++;
                }
            }
        }
    }
}
