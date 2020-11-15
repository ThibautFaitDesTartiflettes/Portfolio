using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP3_Communaute
{
    class Comparer
    {
        public class comparerJoueurNiveauDecroissant : Comparer<Joueur>           //Permet de retourner un nombre en fonction du niveau du joueur
        {
            public override int Compare(Joueur x, Joueur y)
            {
                if (x.getNiveau() == y.getNiveau()) return 0;
                return (x.getNiveau() < y.getNiveau()) ? 1 : -1;
            }
        }

        public static void TrierNiveau()                                                 //Permet de trier les joueurs par niveau et ordre décroissant
        {
            IComparer<Joueur> critereTri = new comparerJoueurNiveauDecroissant();
            Globale.lesJoueurs.Sort(critereTri);
        }
    }
}
