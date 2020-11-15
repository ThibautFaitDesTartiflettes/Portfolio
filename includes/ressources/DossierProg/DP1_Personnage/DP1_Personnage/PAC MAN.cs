using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP1_Personnage
{
    public partial class DP1_form : Form
    {
        Personnage_Gentil PacMan;   //Déclaration d'un objet PAC MAN
        Personnage_Mechant Blinky;  //Déclaration d'un fantôme rouge
        Personnage_Mechant Inky;    //Déclaration d'un fantôme bleu
        Personnage_Mechant Pinky;   //Déclaration d'un fantôme rose
        Personnage_Mechant Pokey;   //Déclaration d'un fantôme orange

        public DP1_form()
        {
            InitializeComponent();

            PacMan = new Personnage_Gentil("PacMan", 64, 64, pb_gentil);    //Instanciation de PAC MAN
            Blinky = new Personnage_Mechant("Blinky", 64, 64, pbBlinky);    //Instanciation du fantôme rouge
            Inky = new Personnage_Mechant("Inky", 64, 64, pbInky);          //Instanciation du fantôme bleu
            Pinky = new Personnage_Mechant("Pinky", 64, 64, pbPinky);       //Instanciation du fantôme rose
            Pokey = new Personnage_Mechant("Pokey", 64, 64, pbPokey);       //Instanciation du fantôme orange

            pb_gentil.Image = ilPacMan.Images[1];   //Image de base de PAC MAN

            //Mettre PAC MAN au dessus des autres entités
            pb_gentil.BringToFront();
            //Mettre les informations au dessus
            lbPoint.BringToFront();
            lbTextPoint.BringToFront();
            lbTimer.BringToFront();
            lbTextTimer.BringToFront();

            lbPoint.Text = score.ToString(); //Initialisation du label point
        }

        int secondes;   //Variable utile pour le timer
        int score;      //Variable utlie pour les points
        bool perdu;     //Variable utile pour le résultat

        private void DP1_form_Load(object sender, EventArgs e)
        {
            //Position fantome
            Blinky.setPositionMechantX();   //Positionnement aléatoire en X
            Blinky.setPositionMechantY();   //Positionnement aléatoire en Y
            Blinky.ActualiserMechant();     //Actualisation du personnage à sa nouvelle position

            Inky.setPositionMechantX();     
            Inky.setPositionMechantY();
            Inky.ActualiserMechant();

            Pinky.setPositionMechantX();      
            Pinky.setPositionMechantY();
            Pinky.ActualiserMechant();

            Pokey.setPositionMechantX();
            Pokey.setPositionMechantY();
            Pokey.ActualiserMechant();

            //Temps de jeu
            TimerJeu.Start();   //Démarrage du timer
        }

        private void DP1_form_KeyDown(object sender, KeyEventArgs e)
        {
            
            //Déplacement du personnage
            //Aller en haut
            if (e.KeyCode == Keys.Up)
            {
                PacMan.setAllerHaut();                  //Appel du setter AllerHaut
                pb_gentil.Image = ilPacMan.Images[0];   //Image de PACMAN vers le haut
                PacMan.ActualiserGentil();              //Appel du setter ActualiserPersonnage
            }
            //Aller à droite
            if (e.KeyCode == Keys.Right)
            {
                PacMan.setAllerDroite();
                pb_gentil.Image = ilPacMan.Images[1];
                PacMan.ActualiserGentil();
            }
            //Aller à gauche
            if (e.KeyCode == Keys.Down)
            {
                PacMan.setAllerBas();
                pb_gentil.Image = ilPacMan.Images[2];
                PacMan.ActualiserGentil();
            }
            //Aller en bas
            if (e.KeyCode == Keys.Left)
            {
                PacMan.setAllerGauche();
                pb_gentil.Image = ilPacMan.Images[3];
                PacMan.ActualiserGentil();
            }

            //Teleportation du personnage
            //Teleportation en haut
            if (pb_gentil.Location.Y > 690)     //Si le personnage depasse la coordonnée 690 sur l'axe vertical
            {
                PacMan.setTpHaut(); //On le téléporte en haut
            }
            //Teleportation en bas
            if (pb_gentil.Location.Y < -50)
            {
                PacMan.setTpBas();  //Appel du mutateur TpBas
            }
            //Teleportation à droite
            if (pb_gentil.Location.X < -50)
            {
                PacMan.setTpDroite();
            }
            //Teleportation à gauche
            if (pb_gentil.Location.X > 740)     //Si le personnage depasse la coordonnée 740 sur l'axe horizontal
            {
                PacMan.setTpGauche();   //On le téléporte à gauche
            }

            //Attraper un mechant
            if (Blinky != null) //Si le méchant est sur la grille
            {
                //Si le point au milieu de l'axe horizontal la pb_gentil contient celui de la pbBlinky
                if (pb_gentil.Location.X + pb_gentil.Width/2 > pbBlinky.Location.X && pb_gentil.Location.X < pbBlinky.Location.X + pbBlinky.Width)
                {
                    //Et si le point au milieu de l'axe vertical de la pb-gentil contient celui de la pbBlinky
                    if (pb_gentil.Location.Y + pb_gentil.Height/2 > pbBlinky.Location.Y && pb_gentil.Location.Y < pbBlinky.Location.Y + pbBlinky.Height)
                    {
                        Blinky = null;                      //Le méchant est null car "attrapé"
                        pbBlinky.Visible = false;           //On cache ce méchant
                        score++;                            //On incrémente le score
                        lbPoint.Text = score.ToString();    //On affiche le score
                    }
                }
            }


            if (Blinky == null) //Si le personnage n'est plus sur la grille
            {
                Blinky = new Personnage_Mechant("Blinky", 64, 64, pbBlinky); //On en instancie un noveau Blinky

                pbBlinky.Visible = true;    //On le rend visible

                Blinky.setPositionMechantX();   //On lui attribue des coordonnées aléatoires sur X et Y
                Blinky.setPositionMechantY();
                Blinky.ActualiserMechant();     //On actualise sa position pour le faire apparaître
            }

            if (Inky != null)
            {
                if (pb_gentil.Location.X + pb_gentil.Width / 2 > pbInky.Location.X && pb_gentil.Location.X < pbInky.Location.X + pbInky.Width)
                {
                    if (pb_gentil.Location.Y + pb_gentil.Height / 2 > pbInky.Location.Y && pb_gentil.Location.Y < pbInky.Location.Y + pbInky.Height)
                    {
                        Inky = null;
                        pbInky.Visible = false;
                        score++;
                        lbPoint.Text = score.ToString();
                    }
                }
            }

            if (Inky == null)
            {
                Inky = new Personnage_Mechant("Blinky", 64, 64, pbInky);

                pbInky.Visible = true;

                Inky.setPositionMechantX();
                Inky.setPositionMechantY();
                Inky.ActualiserMechant();
            }

            if (Pinky != null)
            {
                if (pb_gentil.Location.X + pb_gentil.Width / 2 > pbPinky.Location.X && pb_gentil.Location.X < pbPinky.Location.X + pbPinky.Width)
                {
                    if (pb_gentil.Location.Y + pb_gentil.Height / 2 > pbPinky.Location.Y && pb_gentil.Location.Y < pbPinky.Location.Y + pbPinky.Height)
                    {
                        Pinky = null;
                        pbPinky.Visible = false;
                        score++;
                        lbPoint.Text = score.ToString();
                    }
                }
            }

            if (Pinky == null)
            {
                Pinky = new Personnage_Mechant("Blinky", 64, 64, pbPinky);

                pbPinky.Visible = true;

                Pinky.setPositionMechantX();
                Pinky.setPositionMechantY();
                Pinky.ActualiserMechant();
            }

            if (Pokey != null)
            {
                if (pb_gentil.Location.X + pb_gentil.Width / 2 > pbPokey.Location.X && pb_gentil.Location.X < pbPokey.Location.X + pbPokey.Width)
                {
                    if (pb_gentil.Location.Y + pb_gentil.Height / 2 > pbPokey.Location.Y && pb_gentil.Location.Y < pbPokey.Location.Y + pbPokey.Height)
                    {
                        Pokey = null;
                        pbPokey.Visible = false;
                        score++;
                        lbPoint.Text = score.ToString();
                    }
                }
            }

            if (Pokey == null)
            {
                Pokey = new Personnage_Mechant("Blinky", 64, 64, pbPokey);

                pbPokey.Visible = true;

                Pokey.setPositionMechantX();
                Pokey.setPositionMechantY();
                Pokey.ActualiserMechant();
            }

            //Gestion du jeu
            if (perdu) //Si le booléen perdu est vrai
            {
                //On dit au joueur qu'il à perdu et son nombre de point
                MessageBox.Show("Perdu. Votre score est de : " + score + " points", "Fin de partie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();   //On ferme la fenêtre
            }

            //Si l'objectif est atteint
            if (lbPoint.Text == "25" && !perdu)
            {
                //On dit au joueur qu'il à gagné et en combien de temps
                MessageBox.Show("Gagné Votre score est de 25 et vous avez gagné en : " + secondes + " secondes", "Fin de partie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();   //On ferme la fenêtre
            }
        }

        private void lbPoint_Click(object sender, EventArgs e)
        {
            
        }

        private void TimerJeu_Tick(object sender, EventArgs e)
        {
            secondes++; //A chaque tick on incrémente seconde de 1 (1000 ticks = 1 seconde)
            lbTimer.Text = (60 - secondes).ToString();  //On affiche le temps restant

            if (secondes >= 60) //Si on dépasse une minute
            {
                perdu = true;   //Le booléen perdu passe à vrai on entre dans la boucle au dessus
            }
        }
    }
}
