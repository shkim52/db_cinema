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
using System.Data.SqlClient;

namespace DB_Project_Cinema
{
    
    public partial class FindPW : UserControl
    {
        private Connection Connect;
        public FindPW()
        {
            InitializeComponent();
            
        }

        private void FindPWButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sql = "SELECT * FROM MEM WHERE MEM_SID_NO = '" + SID_INPUT.Text + "' AND MEM_ID = '" + ID_INPUT.Text+"'";

                OracleCommand Comm = new OracleCommand(sql, Connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                if (SID_INPUT.Text.Length != 6)
                {
                    MessageBox.Show("생년월일의 입력이 잘못되었습니다!!!");
                }

                else if (!reader.HasRows)
                {
                    MessageBox.Show("해당 정보와 일치하는 회원이 없습니다!");
                }
                while (reader.Read())
                {
                     MessageBox.Show("회원님의 비밀번호는 " + reader.GetString(reader.GetOrdinal("MEM_PW")) + "  입니다!");
                }
                Connect.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Connect.con.Close();
            }
        }

        private void FindPW_Load(object sender, EventArgs e)
        {
            Connect = new Connection();
            Connect.Connecting();
        }

        
    }
}
