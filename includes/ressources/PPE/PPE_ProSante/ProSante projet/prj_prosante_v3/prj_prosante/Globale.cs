using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj_prosante
{
    class Globale
    {
        public static List<visite> lesVisites;
        public static List<visiteur> lesVisiteurs;
        public static List<Professionnel> lesProfessionnels;

        public static MySqlConnection Connexion()
        {
            string chaineDeconnexion = "SERVER=localhost;" + "PORT=3306;" + "DATABASE=prosante;" + "USER ID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
            return connection;
        }

    }
}
