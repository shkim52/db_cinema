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
    public partial class MyPageCheckResv : UserControl
    {
        private Connection connect;
        private static MyPageCheckResv _instance;
        public static MyPageCheckResv Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MyPageCheckResv();
                }
                return _instance;
            }
        }

        private string mem_id;
        public void setMem_id(string s)
        {
            mem_id = s;
        }
        public MyPageCheckResv()
        {
            InitializeComponent();
        }
        private void MyPageCheckResv_Load(object sender, EventArgs e)
        {
            connect = new Connection();
            connect.Connecting();
            get_resveration();
        }
        //에매내역 불러오기 함수
        public void get_resveration()
        {
            try
            {
                string sql = "SELECT B.BK_DATE, B.TK_BK_NO, M.MOVIE_NM, SH.SHOW_START_TIME, SH.SHOW_DATE, B.BK_PRICE FROM BOOKING B, MOVIE M, SH_SCHE SH WHERE MEM_ID ='" + mem_id + "' AND M.MOVIE_NO = B.MOVIE_NO AND SH.SHOW_SCHE_NO = B.SHOW_SCHE_NO";
                Console.WriteLine(sql);
                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("예매 내역이 없습니다.");
                    dataGridView1.Visible = false;
                }
                else
                {
                    while (reader.Read())
                    {
                        string bk_date = reader.GetDateTime(reader.GetOrdinal("BK_DATE")).ToString().Substring(0, 10);
                        string tk_bk_no = reader.GetString(reader.GetOrdinal("TK_BK_NO"));
                        string movie_nm = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                        string show_start_time = reader.GetString(reader.GetOrdinal("SHOW_START_TIME"));
                        string show_date = reader.GetString(reader.GetOrdinal("SHOW_DATE")).ToString().Substring(0, 10);
                        int bk_price = reader.GetInt32(reader.GetOrdinal("BK_PRICE"));
                        dataGridView1.Rows.Add(bk_date, tk_bk_no, movie_nm, show_start_time, show_date, bk_price.ToString());
                    }
                }

                connect.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
