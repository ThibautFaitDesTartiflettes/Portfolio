using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DP3_Communaute
{
    class Joueur
    {
        private string nom;         //Nom du joueur
        private string prenom;      //Prenom du joueur
        private string mail;        //Mail du joueur
        private string pseudo;      //Pseudo du joueur
        private Image avatar;       //Avatar du joueur
        private int niveau;         //Niveau du joueur
        private int score;          //Score du joueur
        private string communaute;  //Communauté à laquelle appartient le joueur (si aucune "")
        private int nbMessage;      //Nombre de messages postés
        private int nbInjureEssaye; //Nombre d'injures voulant êtres postées

        //Constructeur
        public Joueur(string leNom, string lePrenom, string leMail, string lePseudo, Image lAvatar) //Définition de l'instanciation d'un objet de classe Joueur
        {
            this.nom = leNom;
            this.prenom = lePrenom;
            this.mail = leMail;
            this.pseudo = lePseudo;
            this.avatar = lAvatar;
            this.niveau = 1;            //On initialise le niveau à 1
            this.score = 0;             //On initialise le score à 0
            this.communaute = "";       //On initialise à vide
            this.nbMessage = 0;         //On initialise le nombre de message posté à 0
            this.nbInjureEssaye = 0;    //On initialise le nombre d'injures essayées à 0
        }

        //Accesseurs
        public string getNom() { return nom; }                      //Retourner le nom du joueur
        public string getPrenom() { return prenom; }                //Retourner le prénom du joueur
        public string getMail() { return mail; }                    //Retourner le mail du joueur
        public string getPseudo() { return pseudo; }                //Retourner le pseudo du joueur
        public Image getAvatar() { return avatar; }                 //Retourner l'avatar du joueur
        public int getNiveau() { return niveau; }                   //Retourner le niveau du joueur
        public int getScore() { return score; }                     //Retourner le score du joueur
        public string getCommunaute() { return communaute; }        //Retourne la communaute du joueur
        public int getNbMessage() { return nbMessage; }             //Retourne le nombre de messages postés par le joueur
        public int getNbInjureEssaye() { return nbInjureEssaye; }   //Retourne le nombre d'injures essayées


        //Mutateurs
        public void setNom(string leNom) { this.nom = leNom; }                              //Définir le nouveau nom du joueur
        public void setPrenom(string lePrenom) { this.prenom = lePrenom; }                  //Définir le nouveau prenom du joueur
        public void setMail(string leMail) { this.mail = leMail; }                          //Définir le nouveau mail du joueur
        public void setPseudo(string lePseudo) { this.pseudo = lePseudo; }                  //Définir le nouveau pseudo du joueur
        public void setAvatar(Image lAvatar) { this.avatar = lAvatar; }                     //Définir le nouvel avatar du joueur
        public void setNiveau(int leNiveau) { this.niveau = leNiveau; }                     //Définir le nouveau niveau du joueur
        public void setCommunaute(string laCommunaute) { this.communaute = laCommunaute; }  //Définir la nouvelle communaute du joueur
        public void setNbMessage(int leNbMessage) { this.nbMessage = leNbMessage; }         //Définir le nouveau nombre de message du joueur
        public void setNbInjurEssaye(int leNbInjure) { this.nbInjureEssaye = leNbInjure; }  //Définir le nouveau nombre d'injures essayées

        //Autres
        public void AugmenterNiveau() { this.niveau++; }                    //Incrémenter le niveau
        public void AugmenterScore(int leScore) { this.score = leScore; }   //Définir le nouveau score
        public bool NiveauMaxAtteint()                                      //Savoir si le niveau maximum est atteint
        {
            if (Globale.nbMaxNiveaux <= niveau)                             //Si le niveau est supérieur ou égale au niveau maximum alors on retourne vrai sinon on retourne faux
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AugmenterNbMessage() { this.nbMessage++; }              //Ajoute un message au nombre de messages postés
        public void ResetNbMessage() { this.nbMessage = 0; }                //Met à 0 le nombre de messages postés
        public void AugmenterNbInjure() { this.nbInjureEssaye++; }          //Ajoute une injure au nombre d'injures essayées
        public void ResetNbInjure() { this.nbInjureEssaye = 0; }            //Met à 0 le nombre d'injures essayées
    }
}
