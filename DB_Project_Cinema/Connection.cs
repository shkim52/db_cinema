 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace DB_Project_Cinema
{
    class Connection
    {
        public OracleConnection con = new OracleConnection();

        public void Connecting()
        {
            try
            {
                string conString = "User Id=cinema;Password=1234;" + "Data Source=localhost:1521/xe;";
                con.ConnectionString = conString;
                con.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
