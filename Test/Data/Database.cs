using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.SQLite;

namespace Data
{
    public class Database
    {
        private SQLiteConnection con;

        public Database()
        {
            string route = @"C:\\Users\\Lucas\\Source\\Repos\\PokemonTCG\\Test\\Data\\TCGPokemonDB.db";
            con = new SQLiteConnection(route);
        }

        /*public DataTable selectQuery(string query)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();

            try
            {
                SQLiteCommand cmd;
                this.con..Open();  //Initiate connection to the db
                cmd = con.CreateCommand();
                cmd.CommandText = query;  //set the passed query
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt); //fill the datasource
            }
            catch (SQLiteException ex)
            {
                //Add your exception code here.
            }
            con.Close();
            return dt;
        }*/
    }
}
