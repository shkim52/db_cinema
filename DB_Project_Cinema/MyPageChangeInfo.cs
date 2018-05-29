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
    public partial class MyPageChangeInfo : UserControl
    {
        public MyPageChangeInfo()
        {
            InitializeComponent(); 
            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);
            /**OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;*/
            try
            {

                Conn.Open();


                string sql = "SELECT * FROM MEM WHERE MEM_ID = '" + Program.memID + "'";

                OracleCommand Comm = new OracleCommand(sql, Conn);

                OracleDataReader reader = Comm.ExecuteReader();
                
                while (reader.Read())
                {
                    ID.Text = reader.GetString(reader.GetOrdinal("MEM_ID"));
                    SID.Text = reader.GetString(reader.GetOrdinal("MEM_SID_NO"));
                    NAME.Text = reader.GetString(reader.GetOrdinal("MEM_NM"));
                    EMAIL.Text = reader.GetString(reader.GetOrdinal("MEM_EMAIL"));
                    TELNO.Text = reader.GetString(reader.GetOrdinal("MEM_TELNO"));
                }
                
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

        private void ChangeInfoButton_Click(object sender, EventArgs e)
        {
            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);

            try
            {
                OracleCommand Cmd = new OracleCommand();
                Cmd.Connection = Conn;
                Conn.Open();


                string sql = "UPDATE MEM SET MEM_EMAIL = '" + EMAIL.Text + "' , MEM_TELNO = '" + TELNO.Text + "'";
                Cmd.CommandText = sql;
                Cmd.ExecuteNonQuery();
                MessageBox.Show("정보를 수정하였습니다.");

                
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
