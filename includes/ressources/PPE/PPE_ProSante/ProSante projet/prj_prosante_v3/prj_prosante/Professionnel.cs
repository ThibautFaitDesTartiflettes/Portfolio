using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj_prosante
{
    class Professionnel
    {
        public string NomPro;              //Nom du professionnel
        private string PrenomPro;          //Prénom du professionnel
        private string Specialite;         //Spécialité du professionnel
        private string ville;              //Ville du professionnel
        private int annee;                 //Année d'expérience du professionnel

        //Constructeur
        public Professionnel(string unnompro, string unprenompro, string unespec, string uneville, int uneannee)
        {
            this.NomPro = unnompro;
            this.PrenomPro = unprenompro;
            this.Specialite = unespec;
            this.ville = uneville;
            this.annee = uneannee;
        }

        //Accesseurs
        public string getNomPro() { return this.NomPro; }
        public string getPrenomPro() { return this.PrenomPro; }
        public string getSpecialite() { return this.Specialite; }
        public string getVille() { return this.ville; }
        public int getannee() { return this.annee; }

        //Change la spécialité 
        public void ChangerSpecialite(string unespec)
        {
            this.Specialite = unespec;
        }
    }
}
