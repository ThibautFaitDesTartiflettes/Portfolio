using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj_prosante
{
    class visite
    {
        private int NumVisite;              //Numéro de la visite
        private DateTime DateVisite;        //Date de la visite
        private int NbProduitsPresentes;    //Nombre de produits présentés
        private int NbProduitsRetenus;      //Nombre de produits retenus
        private Professionnel professionnel;//Professionnel visité
        private visiteur visiteur;          //Visteur qui visite

        //Constructeur
        public visite(DateTime uneDateVisite, int unNbProduitsRetenus, int unNbProduitsPresentes, Professionnel leProfessionnel, visiteur leVisiteur)
        {
            this.NumVisite = Globale.lesVisites.Count;
            this.DateVisite = uneDateVisite;
            this.NbProduitsPresentes = unNbProduitsPresentes;
            this.NbProduitsRetenus = unNbProduitsRetenus;
            this.professionnel = leProfessionnel;
            this.visiteur = leVisiteur;
        }

        //Accesseurs
        public int getnumVisite() { return this.NumVisite; }
        public String getDateVisiteAffichage() { return this.DateVisite.ToShortDateString(); }
        public int getnbProduitsPresentes() { return this.NbProduitsPresentes ; }
        public int getnbProduitsRetenus() { return this.NbProduitsRetenus ; }
        public Professionnel getProfessionnel() { return this.professionnel; }
        public visiteur getVisiteur() { return this.visiteur; }
    }
}
