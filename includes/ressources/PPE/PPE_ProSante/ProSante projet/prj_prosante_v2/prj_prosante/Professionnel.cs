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

        //Constructeur
        public Professionnel(string unnompro, string unprenompro, string unespec)
        {
            this.NomPro = unnompro;
            this.PrenomPro = unprenompro;
            this.Specialite = unespec;
        }

        //Accesseurs
        public string getNomPro() { return this.NomPro; }
        public string getPrenomPro() { return this.PrenomPro; }
        public string getSpecialite() { return this.Specialite; }

        //Change la spécialité 
        public void ChangerSpecialite(string unespec)
        {
            this.Specialite = unespec;
        }
    }
}
