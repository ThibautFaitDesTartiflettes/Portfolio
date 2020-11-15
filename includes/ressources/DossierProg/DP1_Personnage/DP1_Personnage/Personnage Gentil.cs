using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP1_Personnage
{
    class Personnage_Gentil
    {
        private string nom;             //Nom du personnage
        private int widht;              //Largeur du personnage
        private int height;             //Hauteur du personnage
        private int X;                  //Position sur X
        private int Y;                  //Postition sur Y
        private PictureBox nomPicture;  //Nom de la pb contenant le personnage
        private int vitesse;            //Definit la vitesse du personnage

        //Constructeur
        public Personnage_Gentil(string LeNom, int LaWidht, int LaHeight, PictureBox LeNomPicture)
        {
            this.nom = LeNom;
            this.widht = LaWidht;
            this.height = LaHeight;
            this.X = LeNomPicture.Location.X;   //La coordonnée en X est égale à la coordonnée en X de la PictureBox contenant le personnage
            this.Y = LeNomPicture.Location.Y;   //La coordonnée en Y est égale à la coordonnée en Y de la PictureBox contenant le personnage
            this.nomPicture = LeNomPicture;
            this.vitesse = 10;                  //On instancie la vitesse du personnage à 10
        }

        //Accesseurs
        public int getPositionGentilX() { return X; }   //Permet de savoir la coordonnée du personnage sur l'axe horizontal
        public int getPositionGentilY() { return Y; }   //Permet de savoir la coordonnée du personnage sur l'axe vertical


        //Mutateurs
        //Mouvements
        public void setAllerDroite() { this.X = X + vitesse; }  //Permet le déplacement à droite
        public void setAllerGauche() { this.X = X - vitesse; }  //Permet le déplacement à gauche
        public void setAllerBas() { this.Y = Y + vitesse; }     //Permet le déplacement en  bas
        public void setAllerHaut() { this.Y = Y - vitesse; }    //Permet le déplacement en haut

        //Teleportation
        public void setTpHaut() { this.Y = -49; this.X = nomPicture.Location.X; }   //Permet la téléportation du personnage en haut
        public void setTpBas() { this.Y = 689; this.X = nomPicture.Location.X; }    //Permet la téléportation du personnage en bas
        public void setTpDroite() { this.X = 739; this.Y = nomPicture.Location.Y; } //Permet la téléportation du personnage à droite
        public void setTpGauche() { this.X = -49; this.Y = nomPicture.Location.Y; } //Permet la téléportation du personnage en gauche


        //Actualiser
        public void ActualiserGentil() { this.nomPicture.Top = Y; this.nomPicture.Left = X; }   //Permet d'actualiser le personnage à ses coordonnées
    }
}
