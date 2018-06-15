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
        Connection connect;
        private string mem_id;
        
        
        public MyPageMyPoint(string id)
        {
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();
            mem_id = id;
        }

        private void MyPageMyPoint_Load(object sender, EventArgs e)
        {
            try
            {
               string sql = "SELECT SAVE_POINT FROM MEM WHERE MEM_ID = '" + mem_id + "'";
               Console.WriteLine(sql);
                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();


                while (reader.Read())
                {
                    point.Text = reader.GetInt32(reader.GetOrdinal("SAVE_POINT")).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                connect.con.Close();
            }
        }
            
    }
}

