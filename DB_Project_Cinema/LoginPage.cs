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

            MemLoginTab.FlatAppearance.BorderColor = Color.Red;
            MemLoginTab.FlatAppearance.BorderSize = 1;
            CustLoginTab.FlatAppearance.BorderSize = 0;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            mem_panel.BringToFront();   
        }
        private void MemLoginTab_Click(object sender, EventArgs e)
        {
            mem_panel.BringToFront();

            MemLoginTab.FlatAppearance.BorderColor = Color.Red;
            MemLoginTab.FlatAppearance.BorderSize = 1;
            CustLoginTab.FlatAppearance.BorderSize = 0;     
        }

        private void CustLoginTab_Click(object sender, EventArgs e)
        {
            cust_panel.BringToFront();

            CustLoginTab.FlatAppearance.BorderColor = Color.Red;
            CustLoginTab.FlatAppearance.BorderSize = 1;
            MemLoginTab.FlatAppearance.BorderSize = 0;
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
                        string mem_id = ID_INPUT.Text;
                        MessageBox.Show(mem_id + "님 환영합니다!");

                        _parent.Login_Complete(mem_id);

                        // 없애야될것들
                        //MovieDetail.Instance.setMem_id(mem_id);
                        MyPageChangeInfo.Instance.setMem_id(mem_id);
                        MyPageChangePw.Instance.setMem_id(mem_id);
                        MyPageCheckResv.Instance.setMem_id(mem_id);
                        MyPageInterest.Instance.setMem_id(mem_id);
                        MyPageMyPoint.Instance.setMem_id(mem_id);
                        MyPageQuitMem.Instance.setMem_id(mem_id);
                        ReviewPage.Instance.setMem_id(mem_id);
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
                 // 기능추가해야됨
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
