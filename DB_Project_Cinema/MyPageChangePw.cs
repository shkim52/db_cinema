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
        public MyPageChangePw()
        {
            InitializeComponent();
        }

        private void ChangePWButton_Click(object sender, EventArgs e)
        {
            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);

            try
            {
                OracleCommand Cmd = new OracleCommand();
                Cmd.Connection = Conn;
                Conn.Open();
                
                string s = "SELECT * FROM MEM WHERE MEM_ID = '" + Program.memID + "'";
                OracleCommand Comm = new OracleCommand(s, Conn);

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
