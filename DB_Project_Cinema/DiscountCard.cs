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
    public partial class DiscountCard : UserControl
    {
        private static DiscountCard _instance;
        private Connection connect;
        public static DiscountCard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DiscountCard();
                }
                return _instance;
            }
        }
        public DiscountCard()
        {
            InitializeComponent();
        }

        private void DiscountCard_Load(object sender, EventArgs e)
        {
            connect = new Connection();
            connect.Connecting();
            try
            {
                string sql = "SELECT * FROM TEL_DC" ;
                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();
                
                reader.Read();
                SKTlb.Text = reader.GetString(reader.GetOrdinal("TEL_NM"));
                DClb1.Text = reader.GetString(reader.GetOrdinal("DC_RATE"));
               
                reader.Read();
                KTlb.Text = reader.GetString(reader.GetOrdinal("TEL_NM"));
                DClb2.Text = reader.GetString(reader.GetOrdinal("DC_RATE"));
               
                reader.Read();
                LGlb.Text = reader.GetString(reader.GetOrdinal("TEL_NM"));
                DClb3.Text = reader.GetString(reader.GetOrdinal("DC_RATE"));

                connect.con.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
