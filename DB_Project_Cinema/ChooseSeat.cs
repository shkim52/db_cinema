using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace DB_Project_Cinema
{
    public partial class ChooseSeat : UserControl
    {
        public ChooseSeat()
        {
            InitializeComponent();
            string str = "data source=localhost:1521/xe;user id=YUN; password=1234";
            OracleConnection Conn = new OracleConnection(str);
            /**OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;*/
            try
            {
            
                Conn.Open();
                string sql = "SELECT * FROM MOVIE";
                OracleCommand Comm = new OracleCommand(sql,Conn);

                Console.WriteLine("=================================");
                OracleDataReader reader = Comm.ExecuteReader();
              
                while (reader.Read())
                {
                    Console.WriteLine("111111111111111111111111");
                    this.TOT_SEAT_CNT.Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));

                }
                Conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.Write("++++++++++++++++++++++++++++++++++++");
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
