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
    public partial class LoginCustomer : UserControl
    {
        private static LoginCustomer _instance;
        public static LoginCustomer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoginCustomer();
                }
                return _instance;
            }
        }
        public LoginCustomer()
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
                /*
                string sql = "SELECT * FROM CUST WHERE CUST_ID = '" + CustNameTextbox.Text + "' AND CUST_PW = '" + CustPwdTextbox.Text + "'";

                OracleCommand Comm = new OracleCommand(sql, Conn);
                OracleDataReader reader = Comm.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("아이디 혹은 비밀번호를 잘못 입력하였습니다!");
                }

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(reader.GetOrdinal("QUIT_STAT")));
                    if (reader.GetString(reader.GetOrdinal("QUIT_STAT")) == "N")
                    {
                        Program.custID = CustNameTextbox.Text;
                        MessageBox.Show(CustNameTextbox.Text + "님 환영합니다!");
                        CinemaProgram c = new CinemaProgram();
                        c.Show();
                    }
                }*/
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
