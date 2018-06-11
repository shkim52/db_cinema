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
    public partial class ScreenInfo : UserControl
    {
        private static ScreenInfo _instance;
        private Connection connect;
        public static ScreenInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ScreenInfo();
                }
                return _instance;
            }
        }
        public ScreenInfo()
        {
            InitializeComponent();

            connect = new Connection();
            connect.Connecting();
        }

        private void ScreenInfo_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM SCREEN ORDER BY SCR_NO";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    string ScrNM = reader.GetString(reader.GetOrdinal("SCR_NM"));
                    string ScrIntro = reader.GetString(reader.GetOrdinal("SCR_INTRO"));
                    int ScrSeatCnt = reader.GetInt32(reader.GetOrdinal("SCR_SEAT_CNT"));

                    dataGridView1.Rows.Add(ScrNM, ScrIntro, ScrSeatCnt);
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
