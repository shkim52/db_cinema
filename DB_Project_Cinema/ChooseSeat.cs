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
        private Connection connect;
        public ChooseSeat()
        {
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();
            /**OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;*/
            try
            {
            
                string sql = "SELECT * FROM SCREEN WHERE SCR_NO=1";
                OracleCommand Comm = new OracleCommand(sql, connect.con);

               
                OracleDataReader reader = Comm.ExecuteReader();
              
                while (reader.Read())
                {

                    this.TOT_SEAT_CNT.Text = reader.GetDecimal(reader.GetOrdinal("SCR_SEAT_CNT")).ToString();

                }
                connect.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
               
            }
            finally
            {
                connect.con.Close();
            }
        }

        private void SEAT_CNT_Click(object sender, EventArgs e)
        {

        }
    }
}
