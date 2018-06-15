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
    public partial class CustCheckResv : UserControl
    {
        private Connection connect;
        private string cust_id;
        public CustCheckResv(string id)
        {
            InitializeComponent();
            cust_id = id;
            
            connect = new Connection();
            connect.Connecting();
            get_resveration();
        }

        //에매내역 불러오기 함수
        public void get_resveration()
        {
            try
            {
                string sql = "SELECT P.PAY_STAT, B.BK_DATE, B.TK_BK_NO, M.MOVIE_NM, SH.SHOW_START_TIME, SH.SHOW_DATE, B.BK_PRICE FROM PAYMENT P, BOOKING B, MOVIE M, SH_SCHE SH WHERE B.TK_BK_NO ='" + cust_id + "' AND M.MOVIE_NO = B.MOVIE_NO AND SH.SHOW_SCHE_NO = B.SHOW_SCHE_NO AND P.PAY_NO = B.TK_BK_NO";
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
                        string show_date = reader.GetDateTime(reader.GetOrdinal("SHOW_DATE")).ToString().Substring(0, 10);
                        int bk_price = reader.GetInt32(reader.GetOrdinal("BK_PRICE"));
                        string pay_stat = reader.GetString(reader.GetOrdinal("PAY_STAT"));
                        string pay_stat_fig;
                        if (pay_stat == "Y")
                        {
                            pay_stat_fig = "예매 취소 하기";
                        }
                        else
                        {
                            pay_stat_fig = "예매 취소 완료";
                        }
                        dataGridView1.Rows.Add(bk_date, tk_bk_no, movie_nm, show_start_time, show_date, bk_price.ToString(), pay_stat_fig);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "예매 취소 완료")
                {
                    MessageBox.Show("이미 예매 취소하였습니다!!");
                }
                else if (MessageBox.Show("예매를 취소하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string tk_bk_no = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Console.WriteLine(tk_bk_no);

                    OracleCommand Cmd = new OracleCommand();
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = "CANCEL_RESV_PROC";
                    Cmd.Connection = connect.con;

                    Cmd.Parameters.Add(new OracleParameter("p_tk_bk_no", tk_bk_no)); 
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("예매 취소가 완료되었습니다. 환불 처리는 카드사에 따라 시간이 소요될 예정입니다.");
                    dataGridView1.Rows[e.RowIndex].Cells[6].Value = "예매 취소 완료";
                }
            }
        }
    }
}
