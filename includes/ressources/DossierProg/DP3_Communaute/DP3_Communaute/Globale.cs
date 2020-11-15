using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP3_Communaute
{
    class Globale
    {
        public static int nbMaxNiveaux = 5;                                     //Nombre maximum de niveaux
        public static int plafondScore = 10;                                    //Score maximum par niveau
        public static List<Joueur> lesJoueurs = new List<Joueur>();             //Collection contenant les joueurs
        public static List<Communaute> lesCommunautes = new List<Communaute>(); //Collection contenant les communautes
        public static List<Message> lesMessages = new List<Message>();          //Collection contenant les messages de chat
    }
}
