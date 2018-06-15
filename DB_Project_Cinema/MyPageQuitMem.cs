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
        private Connection connect;
        private MyPage _parent;

        private string mem_id;
        public void setMem_id(string s)
        {
            mem_id = s;
        }
        public MyPageQuitMem(MyPage parent)
        {
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();
            _parent = parent;
        }

        private void QuitMemButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                string sql = "SELECT P.PAY_STAT FROM PAYMENT P, BOOKING B WHERE B.MEM_ID = '" + mem_id + "' AND B.TK_BK_NO = P.PAY_NO";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();
                bool stat = false;

                while (reader.Read())
                {
                    if (reader.GetString(reader.GetOrdinal("PAY_STAT")).ToString() == "N")
                    {
                        stat = true;
                        break;
                    }
                }
                if (stat)
                {
                    MessageBox.Show("에매 되어있는 영화가 존재하므로 탈퇴가 불가능합니다!");
                }
                else
                {
                    OracleCommand Cmd = new OracleCommand();
                    Cmd.Connection = connect.con;

                    string input_sql = "UPDATE MEM SET QUIT_STAT = 'Y' WHERE MEM_ID ='" + mem_id + "'";
                    Cmd.CommandText = input_sql;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("탈퇴가 완료되었습니다.");
                    _parent.click_logout();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
