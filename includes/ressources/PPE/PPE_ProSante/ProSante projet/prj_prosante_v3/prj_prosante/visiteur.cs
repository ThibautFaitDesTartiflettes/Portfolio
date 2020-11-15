using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj_prosante
{
    class visiteur
    {
        private string matricule;    //matricule du visiteur
        private string nom;          //nom du visiteur
        private string prenom;       //prenom du visiteur
        private string numero;       //numero de téléphone
        private string secteur;      //secteur

        // constructeur
        public visiteur(string unMatricule, string unNom, string unPrenom,string numero,string secteur)
        {
            this.matricule = unMatricule; this.nom = unNom; this.prenom = unPrenom; this.numero = numero; this.secteur = secteur;
        }

        // accesseur :
        public string getMatricule() { return this.matricule; }
        public string getNom() { return this.nom; }
        public string getPrenom() { return this.prenom; }       
        public string getNumero() { return this.numero; }       
        public string getSecteur() { return this.secteur; }       
    }
}
