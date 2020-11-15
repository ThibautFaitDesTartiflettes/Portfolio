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
    public partial class frmQuitterCommunaute : Form
    {
        public frmQuitterCommunaute()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmQuitterCommunaute
        }

        private void frmQuitterCommunaute_Load(object sender, EventArgs e)
        {
            //On affiche tous les joueurs qui ont été créés
            foreach (Joueur unJoueur in Globale.lesJoueurs)
            {
                cbJoueur.Items.Add(unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")");
            }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            int position = cbJoueur.SelectedIndex;  //On recupère l'index de l'élément choisi
            int idx = 0;                            //Variable utile au parcours
            bool trouve = false;                    //Variable utile à l'affichage

            string nomCommu = Globale.lesJoueurs.ElementAt(position).getCommunaute();   //On recupère le nom de la communaute du joueur
            int idx2 = 0;                                                               //Variable utile au parcours
            bool trouve2 = false;                                                       //Variable utile à l'affichage

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

            //Tant que la collection n'as pas été parcourue totalement et que trouve2 est faux alors
            while (idx2 < Globale.lesCommunautes.Count && !trouve2)
            {
                //Si l'index de l'élément choisi est égal à la variable de parcours alors
                if (nomCommu == Globale.lesCommunautes.ElementAt(idx2).getNom())
                {
                    trouve2 = true;  //Trouve passe à true
                }
                else
                {
                    idx2++;  //On regarde l'élément suivant
                }
            }

            //Si on à trouvé le joueur alors
            if (trouve)
            {
                //Si le joueur n'a pas de communauté alors
                if (Globale.lesJoueurs.ElementAt(position).getCommunaute() == "")
                {
                    //On informe l'utilisateur
                    MessageBox.Show("Ce joueur n'a pas de communauté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //On met sa communaute à rien
                    Globale.lesJoueurs.ElementAt(position).setCommunaute("");
                    //On le retire de la liste des membres
                    Globale.lesCommunautes.ElementAt(idx2).retirerMembre(Globale.lesJoueurs.ElementAt(position));
                    //On informe l'utilisateur
                    MessageBox.Show("Vous avez quitté votre communauté", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //On vide son nombre de message postés et d'injures tentées
                    Globale.lesJoueurs.ElementAt(position).ResetNbMessage();
                    Globale.lesJoueurs.ElementAt(position).ResetNbInjure();
                }
            }
            //Sinon on informe l'utilisateur
            else
            {
                MessageBox.Show("Un problème est survenu avec ce joueur, veuillez réessayer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Si on à trouvé la communauté
            if (trouve2)
            {
                //Si la communaute est vide alors
                if (Globale.lesCommunautes.ElementAt(idx2).nombreMembre() == 0)
                {
                    //On la supprime
                    Globale.lesCommunautes.Remove(Globale.lesCommunautes.ElementAt(idx2));
                    //On informe
                    MessageBox.Show("La communauté étant vide elle à été supprimé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Si le joueur était fondateur de la communaute
                else if (Globale.lesCommunautes.ElementAt(idx2).getFondateur() == Globale.lesJoueurs.ElementAt(position).getPseudo() + "  (" + 
                                                                                  Globale.lesJoueurs.ElementAt(position).getNom() + " " + 
                                                                                  Globale.lesJoueurs.ElementAt(position).getPrenom() + ")")
                {
                    //On désigne aléatoirement un joueur de la communauté comme nouveau fondateur
                    Random rdn = new Random();
                    int nouveau = rdn.Next(Globale.lesCommunautes.ElementAt(idx2).nombreMembre());
                    Globale.lesCommunautes.ElementAt(idx2).setFondateur(Globale.lesCommunautes.ElementAt(idx2).getLesMembres().ElementAt(nouveau).getPseudo() + "  (" + 
                                                                        Globale.lesCommunautes.ElementAt(idx2).getLesMembres().ElementAt(nouveau).getNom() + " " + 
                                                                        Globale.lesCommunautes.ElementAt(idx2).getLesMembres().ElementAt(nouveau).getPrenom() + ")");
                    //On informe du nouveau fondateur
                    MessageBox.Show("Le nouveau fondateur est : " + Globale.lesCommunautes.ElementAt(idx2).getFondateur(), "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void cbJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            btValider.Enabled = true;

            //Si l'utilisateur désélectionne le joueur
            if (cbJoueur.Text == "")
            {
                //On verrouille le bouton
                btValider.Enabled = false;
            }
        }
    }
}
