using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Gestion
{
    class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private string ConString;   
        public Functions()
        {
            ConString = @"Data Source=.\sqlexpress;Initial Catalog=Gestion;Integrated Security=True";
            Con = new SqlConnection(ConString);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }
        public DataTable RecupererDonnees(string Requete)
        {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Requete,ConString);
            Sda.Fill(dt); 
            return dt;
        }
        public int EnvoyerDonnees(string Requete)
        {
            int Cnt = 0;
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Requete;
            Cnt = Cmd.ExecuteNonQuery();
            return Cnt;
        }
            

    }

}
