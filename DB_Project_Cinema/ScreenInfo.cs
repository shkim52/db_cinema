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

            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);
            /**OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;*/
            try
            {

                Conn.Open();
                string sql = "SELECT * FROM SCREEN ORDER BY SCR_NO";

                OracleCommand Comm = new OracleCommand(sql, Conn);


                OracleDataReader reader = Comm.ExecuteReader();


                while (reader.Read())
                {
                    string ScrNM = reader.GetString(reader.GetOrdinal("SCR_NM"));
                    string ScrIntro = reader.GetString(reader.GetOrdinal("SCR_INTRO"));
                    int ScrSeatCnt = reader.GetInt32(reader.GetOrdinal("SCR_SEAT_CNT"));

                    dataGridView1.Rows.Add(ScrNM, ScrIntro, ScrSeatCnt);
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
