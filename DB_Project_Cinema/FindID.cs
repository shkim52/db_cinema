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
    public partial class FindID : UserControl
    {
        public FindID()
        {
            InitializeComponent();
            
        }

        private void FindIDButton_Click(object sender, EventArgs e)
        {
            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);
            /**OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;*/
            try
            {

                Conn.Open();
                if (SID_INPUT.Text.Length != 13)
                {
                    MessageBox.Show("주민등록번호의 입력이 잘못되었습니다!!!");
                }

                string sql = "SELECT * FROM MEM WHERE MEM_SID_NO = " + SID_INPUT.Text + " AND MEM_TELNO = " + TELNO_INPUT.Text;

                OracleCommand Comm = new OracleCommand(sql, Conn);

                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show("회원님의 ID는 "+ reader.GetString(reader.GetOrdinal("Mem_ID"))+"  입니다!");
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
