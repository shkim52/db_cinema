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
    public partial class LoginPage : UserControl
    {    
        private Connection Connect;
        private CinemaProgram _parent;

        public LoginPage(CinemaProgram parent)
        {
            InitializeComponent();
            _parent = parent;
            MemLoginButton.FlatAppearance.BorderColor = Color.Red;
            MemLoginButton.FlatAppearance.BorderSize = 1;
            CustLoginButton.FlatAppearance.BorderSize = 0;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            Connect = new Connection();
            Connect.Connecting();
            mem_panel.BringToFront();   
        }

        private void MemLoginButton_Click_1(object sender, EventArgs e)
        {
            mem_panel.BringToFront();
            MemLoginButton.FlatAppearance.BorderColor = Color.Red;
            MemLoginButton.FlatAppearance.BorderSize = 1;
            CustLoginButton.FlatAppearance.BorderSize = 0;            
        }

        private void CustLoginButton_Click_1(object sender, EventArgs e)
        {
            cust_panel.BringToFront();
            CustLoginButton.FlatAppearance.BorderColor = Color.Red;
            CustLoginButton.FlatAppearance.BorderSize = 1;
            MemLoginButton.FlatAppearance.BorderSize = 0;
        }
        private void mem_loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM MEM WHERE MEM_ID = '" + ID_INPUT.Text + "' AND MEM_PW = '" + PW_INPUT.Text + "'";

                OracleCommand Comm = new OracleCommand(sql, Connect.con);
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
                        Program.memID = ID_INPUT.Text;
                        MessageBox.Show(ID_INPUT.Text + "님 환영합니다!");

                        _parent.Login_Complete();
                        MoviePage.Instance.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("탈퇴회원입니다.");
                    }
                }
                Connect.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void cust_loginButton_Click(object sender, EventArgs e)
        {
             try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
