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
    public partial class frmInfluenceurCommunaute : Form
    {
        public frmInfluenceurCommunaute()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmInfluenceurCommunaute
        }

        private void frmInfluenceurCommunaute_Load(object sender, EventArgs e)
        {
            //On affiche toutes les communautés qui ont été créés
            foreach (Communaute uneCommunaute in Globale.lesCommunautes)
            {
                cbCommunaute.Items.Add(uneCommunaute.getNom());
            }
        }

        private void cbCommunaute_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Membre le plus loquace
            int nbMessageLoquace = -1;      //Variable utile à la recherche
            string identiteLoquace = "";   //Variable utile à l'affichage

            //Membre le plus inactif
            int nbMessageInactif = 1000000;      //Variable utile à la recherche
            string identiteInactif = "";         //Variable utile à l'affichage

            //Membre le plus injurieu
            int nbMessageInjure = -1;      //Variable utile à la recherche
            string identiteInjure = "";   //Variable utile à l'affichage

            //On parcours tous les joueurs
            foreach (Joueur unJoueur in Globale.lesJoueurs)
            {
                //Si le joueur appartient à la communauté alors
                if (unJoueur.getCommunaute() == Globale.lesCommunautes.ElementAt(cbCommunaute.SelectedIndex).getNom())
                {
                    //Si le nombre de message posté par le joueur est supérieur à celui renseigné
                    if (nbMessageLoquace < unJoueur.getNbMessage())
                    {
                        //On assimile son nombre de messages posté à la variable de recherche et on stocke son identité
                        nbMessageLoquace = unJoueur.getNbMessage();
                        identiteLoquace = unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")";
                    }

                    //Si le nombre de message posté par le joueur est inférieur à celui renseigné
                    else if (nbMessageInactif > unJoueur.getNbMessage())
                    {
                        //On assimile son nombre de messages posté à la variable de recherche et on stocke son identité
                        nbMessageInactif = unJoueur.getNbMessage();
                        identiteInactif = unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")";
                    }
                    
                    //Si le nombre d'injure tentées par le joueur est supérieur à celui renseigné
                    if (nbMessageInjure < unJoueur.getNbInjureEssaye())
                    {
                        //On assimile son nombre d'injure tenté à la variable de recherche et on stocke son identité
                        nbMessageInjure = unJoueur.getNbInjureEssaye();
                        identiteInjure = unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")";
                    }
                }
            }

            //On affiche dans les textBox
            tbLoquace.Text = identiteLoquace;
            tbInactif.Text = identiteInactif;
            tbInjure.Text = identiteInjure;
        }
    }
}
