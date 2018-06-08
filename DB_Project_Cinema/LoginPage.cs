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

            Connect = new Connection();
            Connect.Connecting();

            _parent = parent;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            mem_panel.BringToFront();   
        }
        private void MemLoginTab_Click(object sender, EventArgs e)
        {
            mem_panel.BringToFront();
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

                else
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(reader.GetOrdinal("QUIT_STAT")));
                        if (reader.GetString(reader.GetOrdinal("QUIT_STAT")) == "N")
                        {
                            string mem_id = ID_INPUT.Text;
                            MessageBox.Show(mem_id + "님 환영합니다!");

                            _parent.Login_Complete(mem_id);

                            MoviePage.Instance.BringToFront();
                        }
                        else
                        {
                            MessageBox.Show("탈퇴회원입니다.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
