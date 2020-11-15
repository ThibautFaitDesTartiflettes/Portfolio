using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP2_MDI
{
    class Joueur
    {
        private string nom;     //Nom du joueur
        private string prenom;  //Prenom du joueur
        private string mail;    //Mail du joueur
        private string pseudo;  //Pseudo du joueur
        private Image avatar;   //Avatar du joueur
        private int niveau;     //Niveau du joueur
        private int score;      //Score du joueur

        //Constructeur
        public Joueur(string leNom, string lePrenom, string leMail, string lePseudo, Image lAvatar) //Définition de l'instanciation d'un objet de classe Joueur
        {
            this.nom = leNom;
            this.prenom = lePrenom;
            this.mail = leMail;
            this.pseudo = lePseudo;
            this.avatar = lAvatar;
            this.niveau = 1;        //On initialise le niveau à 1
            this.score = 0;         //On initialise le score à 0
        }

        //Accesseurs
        public string getNom() { return nom; }          //Retourner le nom du joueur
        public string getPrenom() { return prenom; }    //Retourner le prénom du joueur
        public string getMail() { return mail; }        //Retourner le mail du joueur
        public string getPseudo() { return pseudo; }    //Retourner le pseudo du joueur
        public Image getAvatar() { return avatar; }     //Retourner l'avatar du joueur
        public int getNiveau() { return niveau; }       //Retourner le niveau du joueur
        public int getScore() { return score; }         //Retourner le score du joueur


        //Mutateurs
        public void setNom(string leNom) { this.nom = leNom; }              //Définir le nouveau nom du joueur
        public void setPrenom(string lePrenom) { this.prenom = lePrenom; }  //Définir le nouveau prenom du joueur
        public void setMail(string leMail) { this.mail = leMail; }          //Définir le nouveau mail du joueur
        public void setPseudo(string lePseudo) { this.pseudo = lePseudo; }  //Définir le nouveau pseudo du joueur
        public void setAvatar(Image lAvatar) { this.avatar = lAvatar; }     //Définir le nouvel avatar du joueur
        public void setNiveau(int leNiveau) { this.niveau = leNiveau; }     //Définir le nouveau niveau du joueur

        //Autres
        public void AugmenterNiveau() { this.niveau++; }                    //Incrémenter le niveau
        public void AugmenterScore(int leScore) { this.score = leScore; }   //Définir le nouveau score
        public bool NiveauMaxAtteint()  //Savoir si le niveau maximum est atteint
        {
            if (Globale.nbMaxNiveaux <= niveau) //Si le niveau est supérieur ou égale au niveau maximum alors on retourne vrai sinon on retourne faux
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
