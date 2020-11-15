using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP3_Communaute
{
    class Message
    {
        private DateTime datePublication;   //Date de publication du message
        private string joueur;              //Joueur qui a publié
        private string contenu;             //Contenu du message

        //Constructeur
        public Message(string leJoueur, string leContenu)
        {
            this.datePublication = DateTime.Now;
            this.joueur = leJoueur;
            this.contenu = leContenu;
        }

        //Accesseur
        public DateTime getDatePublication() { return datePublication; }
        public string getJoueur() { return joueur; }
        public string getContenu() { return contenu; }

        //Mutateur
        public void setDatePublication(DateTime laDatePublication) { this.datePublication = laDatePublication; }
        public void setJoueur(string leJoueur) { this.joueur = leJoueur; }
        public void setContenu(string leContenu) { this.contenu = leContenu; }
    }
}
