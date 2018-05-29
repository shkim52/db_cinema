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
    public partial class MyPageInterest : UserControl
    {
        public MyPageInterest()
        {
            InitializeComponent();
            
            
            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);
            
            try
            {

                Conn.Open();

                string sql = "SELECT COUNT(*) FROM MOVIE M, INTEREST_LIST I WHERE M.MOVIE_NO = I.MOVIE_NO AND I.MEM_ID = '"+Program.memID+"'";

                OracleCommand Comm = new OracleCommand(sql, Conn);

                OracleDataReader reader = Comm.ExecuteReader();
                if (!reader.HasRows)
                {
                    dataGridView1.Visible = false;
                }
                while (reader.Read())
                {

                }
                Conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
