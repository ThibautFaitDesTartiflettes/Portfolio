using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP1_Personnage
{
    class Personnage_Mechant
    {
        private string nom;             //Nom du personnage
        private int widht;              //Largeur du personnage
        private int height;             //Hauteur du personnage
        private int X;                  //Position sur X
        private int Y;                  //Postition sur Y
        private PictureBox nomPicture;  //Nom de la pb contenant le personnage

        //Constructeur
        public Personnage_Mechant(string LeNom, int LaWidht, int LaHeight, PictureBox LeNomPicture)
        {
            this.nom = LeNom;
            this.widht = LaWidht;
            this.height = LaHeight;
            this.X = 0; //On instancie les coordonnées du méchant en 0,0 (il n'y sera en réalité jamais)
            this.Y = 0;
            this.nomPicture = LeNomPicture;
        }

        //Mutateurs
        public int getPositionMechantX() { return X; }  //Permet de savoir la position du méchant sur X
        public int getPositionMechantY() { return Y; }  //Permet de savoir la position du méchant sur Y

        //Accesseurs
        public void setPositionMechantX()   //Générer une coordonnée aléatoire sur X
        {
            Random posX = new Random(Guid.NewGuid().GetHashCode()); //Génère un nouveau domaine d'aléatoire
            X = posX.Next(0, 680);  //Génère un nombre entre 0 et 680
        }
        public void setPositionMechantY()   //Générer une coordonnéé aléatoire sur Y
        {
            Random posY = new Random(Guid.NewGuid().GetHashCode()); //Génère un nouveau domaine d'aléatoire
            Y = posY.Next(0, 620);  //Génère un nombre entre 0 et 620
        }


        //Autres mutateurs / accesseurs
        public void ActualiserMechant() { this.nomPicture.Top = Y; this.nomPicture.Left = X; }  //Permet d'actualiser le méchant à ses coordonnées
    }
}
