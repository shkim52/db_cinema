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
    public partial class Payment : UserControl
    {
        private Connection connect;
        private string[] Tel_NM = new string[10];

        public Payment()
        {
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();

            TelNM_View();
        
        }

       
        private void TelNM_View()
        {
            try
            {
                string sql = "SELECT * FROM TEL_DC";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                int index = 0;

                while (reader.Read())
                {
                    Tel_NM[index++] = Convert.ToString(reader["TEL_NM"]); // select문으로 받아온 영화번호를 배열에 저장해둔다
                }

                for (int i = 0; i < Tel_NM.Length; i++)
                {
                    TelNM.Items.Add(Tel_NM[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }     
        }

        private void TelNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력해주세요!");
            }
        }

        private void PhoneVerification_Click(object sender, EventArgs e)
        {
            MessageBox.Show("휴대폰 인증이 완료되었습니다!");
        }

        private void Point_View()
        {
            try
            {
                string sql = "SELECT SAVE_POINT FROM MEM WHERE MEM_ID = '" + Program.memID + "'";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    SavePoint.Text = reader.GetInt32(reader.GetOrdinal("SAVE_POINT")).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void UsePoint_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SavePoint.Text) < 1000)
            {
                MessageBox.Show("1000Point 이상부터 사용 가능합니다!");
            }
        }

       


        
    }
}
