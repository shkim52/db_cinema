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
    public partial class MyPageQuitMem : UserControl
    {
        public MyPageQuitMem()
        {
            InitializeComponent();
        }

        private void QuitMemButton_Click(object sender, EventArgs e)
        {
            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);

            try
            {
                OracleCommand Cmd = new OracleCommand();
                Cmd.Connection = Conn;
                Conn.Open();

                string input_sql = "UPDATE MEM SET QUIT_STAT = 'Y'";
                Cmd.CommandText = input_sql;
                Cmd.ExecuteNonQuery();
                MessageBox.Show("탈퇴가 완료되었습니다.");


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
