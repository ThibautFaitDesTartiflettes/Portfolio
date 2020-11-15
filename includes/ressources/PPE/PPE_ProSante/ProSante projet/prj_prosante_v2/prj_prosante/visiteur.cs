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

        // constructeur
        public visiteur(string unMatricule, string unNom, string unPrenom)
        {
            this.matricule = unMatricule; this.nom = unNom; this.prenom = unPrenom;
        }

        // accesseur :
        public string getMatricule() { return this.matricule; }
        public string getNom() { return this.nom; }
        public string getPrenom() { return this.prenom; }       
    }
}
