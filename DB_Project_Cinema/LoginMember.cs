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
    public partial class LoginMember : UserControl
    {
        public LoginMember()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);
            /**OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;*/
            try
            {

                Conn.Open();
                
                string sql = "SELECT * FROM MEM WHERE MEM_ID = " + ID_INPUT.Text + " AND MEM_PW = " + PW_INPUT.Text;

                OracleCommand Comm = new OracleCommand(sql, Conn);
                OracleDataReader reader = Comm.ExecuteReader();


                while (reader.Read())
                {
                    /*회원정보없을경우 확인 메시지 방법 찾기*/
                    Program.memID = ID_INPUT.Text;
                    MessageBox.Show(ID_INPUT.Text+ "님 환영합니다!");
                    CinemaProgram c = new CinemaProgram();
                    c.Show();
                    
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
