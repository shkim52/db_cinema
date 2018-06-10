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
    public partial class Payment : UserControl
    {
        private Connection connect;
        private string[] Tel_NM = new string[10];
        private string telnm;
        private string member;
        private string show_schedule;
        private int movieno;
        private int bk_seatcnt;
        private int seat_no;//
        private int seatprice;
        private int savepoint;
        private int usepoint;
        private int tel_dc_rate;
        private int total_dc_price;
        private int total_differ_price;
        private string payway;
        private string cust_id;//
        private string cust_pw;
        private string cust_nm;
        private string cust_birth;
        private string cust_telno;


        public Payment(string mem_id, string schedule_no, int bk_seat_cnt, int chosen_seat_no)
        {
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();

            member = mem_id;
            show_schedule = schedule_no;
            bk_seatcnt = bk_seat_cnt;
            seat_no = chosen_seat_no;
            get_sche_info();
            get_cust_info();
            TelNM_View();
            Point_View();
            Price_View();
        
        }

        private void get_sche_info()
        {
            try
            {
                string sql = "SELECT * FROM SH_SCHE WHERE SHOW_SCHE_NO='"+show_schedule+"'";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    movieno = reader.GetInt32(reader.GetOrdinal("MOVIE_NO"));
                    seatprice = reader.GetInt32(reader.GetOrdinal("SEAT_PRICE"));
                }

                 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }     
        }

        private void get_cust_info()
        {
            try
            {
                string sql = "SELECT * FROM CUST WHERE CUST_ID='" + cust_id + "'";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    cust_pw = reader.GetString(reader.GetOrdinal("CUST_PW"));
                    cust_nm = reader.GetString(reader.GetOrdinal("CUST_NM"));
                    cust_birth = reader.GetString(reader.GetOrdinal("CUST_BIRTH"));
                    cust_telno = reader.GetString(reader.GetOrdinal("CUST_TELNO"));
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

       
        private void TelNM_View()
        {
            try
            {
                string sql = "SELECT * FROM TEL_DC";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                int index = 0;

                while (reader.Read())
                {
                    Tel_NM[index++] = Convert.ToString(reader["TEL_NM"]); // select문으로 받아온 영화번호를 배열에 저장해둔다
                }

                for (int i = 0; i < Tel_NM.Length; i++)
                {
                    TelNM.Items.Add(Tel_NM[i]);
                }

                telnm = TelNM.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }     
        }

        private void PhoneNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력해주세요!");
            }
        }

        private void PhoneVerification_Click(object sender, EventArgs e)
        {
            if (TelNM.Text == "" || PhoneNumber.Text == "")
            {
                MessageBox.Show("통신사를 선택해 주세요!");
            }
            else if (PhoneNumber.Text.Length < 10)
            {
                MessageBox.Show("휴대폰 번호를 정확히 입력해주세요!");
            }
            else
            {
                MessageBox.Show("휴대폰 인증이 완료되었습니다!");
                try
                {
                    string sql = "SELECT * FROM TEL_DC WHERE TEL_NM = '" + TelNM.Text + "'";

                    OracleCommand Comm = new OracleCommand(sql, connect.con);
                    OracleDataReader reader = Comm.ExecuteReader();

                    while (reader.Read())
                    {
                        tel_dc_rate = reader.GetInt32(reader.GetOrdinal("DC_RATE"));
                        TotalDCPrice.Text = ((seatprice * bk_seatcnt) * (tel_dc_rate * 0.01)).ToString();
                        DifferencePrice.Text = (int.Parse(TotalPrice.Text) - int.Parse(TotalDCPrice.Text)).ToString();
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
        }

        private void Point_View()
        {
            
            try
            {
                string sql = "SELECT SAVE_POINT FROM MEM WHERE MEM_ID = '" + member + "'";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    this.SavePoint.Text = reader.GetInt32(reader.GetOrdinal("SAVE_POINT")).ToString();
                    savepoint = Convert.ToInt32(SavePoint.Text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Price_View()
        {
            TotalPrice.Text = (seatprice * bk_seatcnt).ToString();
            //DifferencePrice.Text = (Convert.ToInt32(TotalPrice) - Convert.ToInt32(TotalDCPrice.Text)).ToString();

        }

        private void UsePoint_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SavePoint.Text) < 1000)
            {
                MessageBox.Show("1000Point 이상부터 사용 가능합니다!");
            }
            else
            {
                usepoint = int.Parse(UsePoint.Text);
                //total_dc_price = int.Parse(TotalDCPrice.Text) + usepoint;
                //TotalDCPrice.Text = total_dc_price.ToString();
                //total_differ_price = int.Parse(TotalPrice.Text) - int.Parse(TotalDCPrice.Text);
                //DifferencePrice.Text=total_differ_price.ToString();
            }
        }

        private void CreditCard_Click(object sender, EventArgs e)
        {
            if (CreditCard.Checked)
            {
                payway = "카드 결제";
                AccountTransfer.Enabled = false;
                BankCategory.Enabled = false;
                AccountNumber.Enabled = false;
                AccountPW.Enabled = false;
                AccountVerification.Enabled = false;
            }
            else
            {
                AccountTransfer.Enabled = true;
                BankCategory.Enabled = true;
                AccountNumber.Enabled = true;
                AccountPW.Enabled = true;
                AccountVerification.Enabled = true;
            }
        }

        private void AccountTransfer_Click(object sender, EventArgs e)
        {
            if (AccountTransfer.Checked)
            {
                payway = "계좌 이체";
                CreditCard.Enabled = false;
                CardCategory.Enabled = false;
                CardNumber.Enabled = false;
                CardPW.Enabled = false;
                ApprovalRequest.Enabled = false;
            }
            else
            {
                CreditCard.Enabled = true;
                CardCategory.Enabled = true;
                CardNumber.Enabled = true;
                CardPW.Enabled = true;
                ApprovalRequest.Enabled = true;
            }
        }

        private void ApprovalRequest_Click(object sender, EventArgs e)
        {
            if (CardNumber.Text == "" || CardPW.Text == "")
            {
                MessageBox.Show("모든 정보를 입력해주세요!");
            }
            else if (CardNumber.Text.Length != 16)
            {
                MessageBox.Show("카드번호 16자리를 입력하세요!");
            }
            else if (CardPW.Text.Length != 4)
            {
                MessageBox.Show("비밀번호 4자리를 입력하세요!");
            }
            else
            {
                MessageBox.Show("승인번호가 발급되었습니다!");
            }
        }

        private void AccountVerification_Click(object sender, EventArgs e)
        {
            if (AccountNumber.Text == "" || AccountPW.Text == "")
            {
                MessageBox.Show("모든 정보를 입력해주세요!");
            }
            else if (AccountNumber.Text.Length < 11)
            {
                MessageBox.Show("계좌번호를 정확히 입력하세요!");
            }
            else if (AccountPW.Text.Length != 4)
            {
                MessageBox.Show("비밀번호 4자리를 입력하세요!");
            }
            else
            {
                MessageBox.Show("계좌 검증이 완료되었습니다!");
            }
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            if (!CreditCard.Checked && !AccountTransfer.Checked)
            {
                MessageBox.Show("결제 방법을 선택해 주세요!");
            }
            else
            {
                OracleCommand Cmd = new OracleCommand();
                Cmd.Connection = connect.con;
                

                string sql = "EXECUTE RESV_PROC('" + member + "'," + movieno + ", '" + show_schedule + "'," + bk_seatcnt + "," + seat_no + "," + savepoint + ", '" + payway + "', '" + telnm + "', " + usepoint + "," + seatprice + ", '" + cust_pw + "','" + cust_nm + "','" + cust_birth + "','" + cust_telno + "')";

                Cmd.CommandText = sql;
                Cmd.ExecuteNonQuery();
                MessageBox.Show("결제가 완료되었습니다!");
            }
        }
 
    }
}
