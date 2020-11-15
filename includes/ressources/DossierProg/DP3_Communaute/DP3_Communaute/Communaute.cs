using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DP3_Communaute
{
    class Communaute
    {
        private string nom;                 //Nom de la communaute
        private string fondateur;           //Pseudo du fondateur
        private Image logo;                 //Logo de la communaute
        private DateTime dateCreation;      //Date de création de la communaute
        private List<Joueur> lesMembres;    //Collections contenant les membres de la communaute    

        //Construteur
        public Communaute(string leNom, string leFondateur, Image leLogo)
        {
            this.nom = leNom;
            this.fondateur = leFondateur;
            this.logo = leLogo;
            this.dateCreation = DateTime.Now.Date;  //Initialisé à la date du système
            this.lesMembres = new List<Joueur>();
        }

        //Accesseurs
        public string getNom() { return this.nom; }                             //Retourne le nom de la communaute
        public string getFondateur() { return this.fondateur; }                 //Retourne le fondateur de la communaute    
        public Image getLogo() { return this.logo; }                            //Retourne le logo de la communaute
        public DateTime getDateCreation() { return this.dateCreation.Date; }    //Retourne la date de creation de la communaute
        public List<Joueur> getLesMembres() { return this.lesMembres; }         //Retourne la collection contenant les membres de la communaute

        //Mutateurs
        public void setNom(string leNom) { this.nom = leNom; }                              //Définir le nouveau nom de la communaute
        public void setFondateur(string leFondateur) { this.fondateur = leFondateur; }      //Définir le nouveau fondateur de la communaute
        public void setLogo(Image leLogo) { this.logo = leLogo; }                           //Définir le nouveau logo de la communaute
        public void setDateCreation(DateTime laDate) { this.dateCreation = laDate.Date; }   //Défninir la nouvelle date de création de la communaute

        //Autres
        public void ajouterMembre(Joueur leJoueur) { lesMembres.Add(leJoueur); }            //Ajouter un membre à la collection des membres de la communaute
        public void retirerMembre(Joueur leJoueur) { lesMembres.Remove(leJoueur); }         //Retirer un membre à la collection des membres de la communaute
        public int nombreMembre() { return lesMembres.Count; }
    }
}
