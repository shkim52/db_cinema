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
    public partial class MyPageChangePw : UserControl
    {
        Connection connect;

        private static MyPageChangePw _instance;
        public static MyPageChangePw Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MyPageChangePw();
                }
                return _instance;
            }
        }

        private string mem_id;
        public void setMem_id(string s)
        {
            mem_id = s;
        }
        public MyPageChangePw()
        {
            InitializeComponent();
        }
        
        private void ChangePWButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                OracleCommand Cmd = new OracleCommand();
                Cmd.Connection = connect.con;
                
                string s = "SELECT * FROM MEM WHERE MEM_ID = '" + mem_id + "'";
                OracleCommand Comm = new OracleCommand(s, connect.con);

                OracleDataReader reader = Comm.ExecuteReader();
                reader.Read();
                
                if (reader.GetString(reader.GetOrdinal("MEM_PW")) != PWD_INPUT.Text)
                {
                    MessageBox.Show("기존의 비밀번호가 일치하지 않습니다!");
                }
                else if (NEW_PWD_INPUT.Text == "" && NEW_PWD2_INPUT.Text == "")
                {
                    MessageBox.Show("비밀번호가 입력되지 않았습니다.");
                } else if (NEW_PWD_INPUT.Text != NEW_PWD2_INPUT.Text)
                {
                    MessageBox.Show("비밀번호가 일치하지 않습니다. 비밀번호를 다시 입력해주세요.");
                }
                else
                {
                    string sql = "UPDATE MEM SET MEM_PW = '"+NEW_PWD2_INPUT.Text+"'";
                    Cmd.CommandText = sql;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("비밀번호가 성공적으로 변경되었습니다.");

                }
                connect.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void MyPageChangePw_Load(object sender, EventArgs e)
        {
            connect = new Connection();
            connect.Connecting();
        }

    }
}
