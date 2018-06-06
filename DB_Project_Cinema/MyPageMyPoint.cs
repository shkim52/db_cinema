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
    
    public partial class MyPageMyPoint : UserControl
    {
        private static MyPageMyPoint _instance;
        public static MyPageMyPoint Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MyPageMyPoint();
                }
                return _instance;
            }
        }

        private string mem_id;
        public void setMem_id(string s)
        {
            mem_id = s;
        }
        public MyPageMyPoint()
        {
            InitializeComponent();
            
        }

        private void MyPageMyPoint_Load(object sender, EventArgs e)
        {
            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);

            try
            {
                Conn.Open();

                string sql = "SELECT SAVE_POINT FROM MEM WHERE MEM_ID = '" + Program.memID + "'";

                OracleCommand Comm = new OracleCommand(sql, Conn);
                OracleDataReader reader = Comm.ExecuteReader();


                while (reader.Read())
                {
                    point.Text = reader.GetInt32(reader.GetOrdinal("SAVE_POINT")).ToString();
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

