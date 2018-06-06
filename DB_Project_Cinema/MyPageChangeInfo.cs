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
        private Connection connect;

        private static MyPageChangeInfo _instance;
        public static MyPageChangeInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MyPageChangeInfo();
                }
                return _instance;
            }
        }
        
        private string mem_id;
        public void setMem_id(string s)
        {
            mem_id = s;
        }
        
        public MyPageChangeInfo()
        {
            InitializeComponent();
            Console.WriteLine(mem_id);
        }
        public void MyPageChangeInfo_test()
        {
            try
            {
                string sql = "SELECT * FROM MEM WHERE MEM_ID = '" + mem_id + "'";
                Console.WriteLine(sql);
                OracleCommand Comm = new OracleCommand(sql, connect.con);

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
        }
        private void ChangeInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand Cmd = new OracleCommand();
                Cmd.Connection = connect.con;

                string sql = "UPDATE MEM SET MEM_EMAIL = '" + EMAIL.Text + "' , MEM_TELNO = '" + TELNO.Text + "'";
                Cmd.CommandText = sql;
                Cmd.ExecuteNonQuery();
                MessageBox.Show("정보를 수정하였습니다.");

                connect.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void MyPageChangeInfo_Load(object sender, EventArgs e)
        {
            connect = new Connection();
            connect.Connecting();
            
        }
    }
}
