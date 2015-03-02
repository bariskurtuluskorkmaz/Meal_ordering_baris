using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.net_CEN_331_.Class
{
    
    class meal
    {
        
        public int  mealid { get; set; }
        public string mealname{ get; set; }
        public string mealprice { get; set; }
        
        
        public meal()
        {

        }
        public meal(int id)
        {

        }


        public static DataTable listele()
        {

            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = "server=HP;database=project;Trusted_Connection=true";
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = sqlcon;
            sqlcmd.CommandText = "Select * from meal";
            sqlcon.Open();
            SqlDataReader sdr = sqlcmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(sdr);
            sqlcon.Close();
            return table;
        }
    }
}
