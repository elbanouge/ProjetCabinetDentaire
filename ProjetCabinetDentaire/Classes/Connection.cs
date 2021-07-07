using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetCabinetDentaire.Classes
{
    public class Connection
    {
        public cabinet_dentaireEntities cabinet_Dentaire = new cabinet_dentaireEntities();

        public MySqlConnection con = new MySqlConnection();
        public MySqlCommand cmd = new MySqlCommand();
        public MySqlParameter parameter = new MySqlParameter();
        public MySqlDataReader dr;

        public void Connecter()
        {
            if (con.State == System.Data.ConnectionState.Closed || con.State == System.Data.ConnectionState.Broken)
            {
                con.ConnectionString = @"server=localhost;Uid=root;database=cabinet_dentaire;persistsecurityinfo=True;Pwd=admin";
                con.Open();
            }
        }

        public void Deconnecter()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
