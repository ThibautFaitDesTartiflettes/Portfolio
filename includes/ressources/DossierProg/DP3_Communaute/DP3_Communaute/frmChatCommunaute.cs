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
    public partial class frmChatCommunaute : Form
    {
        public frmChatCommunaute()
        {
            InitializeComponent();
        }

        //Verifier que toutes les informations sont remplies
        public void DeblocageBoutonEnvoyer()
        {
            if (cbCommunaute.Text != "" && cbJoueur.Text != "" && rtbMessage.Text != "")
            {
                btEnvoyer.Enabled = true;
            }
            else
            {
                btEnvoyer.Enabled = false;
            }
        }

        //On modère le chat pour qu'aucune insulte ne soit dite
        public void FiltreAObscenite()
        {
            bool trouve = false;
            //Si le texte du controle (remis en min pour identifier même si il y a une maj) contient le mot entre parenthèse alors
            if (rtbMessage.Text.ToLower().Contains("putain") || rtbMessage.Text.ToLower().Contains("connard") || 
                rtbMessage.Text.ToLower().Contains("merde") || rtbMessage.Text.ToLower().Contains("fils de pute")
                || rtbMessage.Text.ToLower().Contains("enculé") || rtbMessage.Text.ToLower().Contains("batard")
                || rtbMessage.Text.ToLower().Contains("salope") || rtbMessage.Text.ToLower().Contains("gourgandine")) //etc...
            {
                trouve = true;
            }
            //Si une insulte à été trouvée
            if (trouve)
            {
                MessageBox.Show("Veuillez utiliser un langage correct", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                rtbMessage.Clear();
                //On incrémente le nombre d'injures tentées
                Globale.lesJoueurs.ElementAt(cbJoueur.SelectedIndex).AugmenterNbInjure();
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();   //On ferme frmChatCommunaute
        }

        private void frmChatCommunaute_Load(object sender, EventArgs e)
        {
            //On affiche toutes les communautés qui ont été créés
            foreach (Communaute uneCommunaute in Globale.lesCommunautes)
            {
                cbCommunaute.Items.Add(uneCommunaute.getNom());
            }
        }

        private void cbCommunaute_SelectedIndexChanged(object sender, EventArgs e)
        {
            //On parcours tous les joueurs
            foreach (Joueur unJoueur in Globale.lesJoueurs)
            {
                //Si le joueur appartient à la communauté alors
                if (unJoueur.getCommunaute() == Globale.lesCommunautes.ElementAt(cbCommunaute.SelectedIndex).getNom())
                {
                    //On ajoute le joueur à la comboBox
                    cbJoueur.Items.Add(unJoueur.getPseudo() + "  (" + unJoueur.getNom() + " " + unJoueur.getPrenom() + ")");
                }
            }

            DeblocageBoutonEnvoyer();

            //Si on change de communauté
            if (rtbChat.Text != "")
            {
                //On vide la RichTextBox et la comboBox joueurs
                rtbChat.Clear();
                cbJoueur.Items.Clear();
                cbJoueur.Text = "";
            }
        }

        private void rtbMessage_TextChanged(object sender, EventArgs e)
        {
            FiltreAObscenite();
            DeblocageBoutonEnvoyer();
        }

        private void cbJoueur_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeblocageBoutonEnvoyer();
        }

        private void btEnvoyer_Click(object sender, EventArgs e)
        {
            //On copie le message écrit dans la RichTextBox de chat
            rtbChat.AppendText(rtbMessage.Text + "\n");

            //On change la police pour afficher les informations
            rtbChat.AppendText(cbJoueur.Text + ", " + DateTime.Now.ToString("MM/dd/yyyy HH:mm"));

            //On evite que les message soient collés
            rtbChat.Text += "\n";              //On saute une ligne
            rtbChat.Text += "\n";              //On saute une ligne

            //On ajoute le message dans la collection LesMessages de la classe Globale
            Globale.lesMessages.Add(new Message(cbJoueur.Text, rtbMessage.Text));

            //On incrémente le nombre de messages postés du membre
            Globale.lesJoueurs.ElementAt(cbJoueur.SelectedIndex).AugmenterNbMessage();

            //On remet les informations à zero sauf la communaute et les membres (voir cbCommunaute_SelectedIndexChanged)
            rtbMessage.Text = "";
        }
    }
}
