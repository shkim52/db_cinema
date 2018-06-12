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
        private int bk_seatcnt;
        private string seat_no;
        private int seatprice;
        private int savepoint;
        private int usepoint = 0;
        private int tel_dc_rate;
        private string payway;
        private string cust_pw;
        private string cust_nm;
        private string cust_birth;
        private string cust_telno;
        private bool button_check = false;


        public Payment(string mem_id, string schedule_no, int bk_seat_cnt, string chosen_seat_no, string Cust_Pw, string Cust_Nm, string Cust_Birth, string Cust_Tel)
        {
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();

            member = mem_id;
            show_schedule = schedule_no;
            bk_seatcnt = bk_seat_cnt;
            seat_no = chosen_seat_no;
            cust_pw = Cust_Pw;
            cust_nm = Cust_Nm;
            cust_birth = Cust_Birth;
            cust_telno = Cust_Tel;

            seat_price_info();
            TelNM_View();
            Point_View();
            Price_View();
            if (member == "")
            {
                label9.Visible = false;
                label11.Visible = false;
                label24.Visible = false;
                SavePoint.Visible = false;
                UsePoint.Visible = false;
                label12.Visible = false;
                label18.Visible = false;
                PointDc.Visible = false;
                label13.Visible = false;
            }
            else if (Convert.ToInt32(SavePoint.Text) < 1000)
            {
                UsePoint.Enabled = false;
            }
            PointDc.Text = UsePoint.Text;
        }

        private void seat_price_info()
        {
            try
            {
                string sql = "SELECT * FROM SH_SCHE WHERE SHOW_SCHE_NO='"+show_schedule+"'";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                reader.Read();

                seatprice = reader.GetInt32(reader.GetOrdinal("SEAT_PRICE"));
                 
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
                    Tel_NM[index++] = Convert.ToString(reader["TEL_NM"]); 
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


        private void PhoneVerification_Click(object sender, EventArgs e)
        {
            if (TelNM.Text == "" || PhoneNumber.Text == "")
            {
                MessageBox.Show("통신사를 선택해 주세요!");
            }
            else if (PhoneNumber.Text.Substring(0, 2) != "01")
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

                    reader.Read();

                    tel_dc_rate = reader.GetInt32(reader.GetOrdinal("DC_RATE"));
                    TelDCPrice.Text = ((seatprice * bk_seatcnt) * (tel_dc_rate * 0.01)).ToString();
                    DifferencePrice.Text = (int.Parse(TotalPrice.Text) - int.Parse(TelDCPrice.Text)).ToString();                    
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

                reader.Read();

                this.SavePoint.Text = reader.GetInt32(reader.GetOrdinal("SAVE_POINT")).ToString();
                savepoint = Convert.ToInt32(SavePoint.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void Price_View()
        {
            TotalPrice.Text = (seatprice * bk_seatcnt).ToString();
        }

        private void UsePoint_TextChanged(object sender, EventArgs e)
        {
            PointDc.Text = UsePoint.Text;
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
                usepoint = int.Parse(UsePoint.Text);
                MessageBox.Show("승인번호가 발급되었습니다!");
                TelDCPrice.Text = (int.Parse(TelDCPrice.Text)).ToString();
                DifferencePrice.Text = (int.Parse(TotalPrice.Text) - int.Parse(TelDCPrice.Text)-usepoint).ToString();
                AccountNumber.Enabled = false;
                AccountPW.Enabled = false;
                button_check = true;
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
                usepoint = int.Parse(UsePoint.Text);
                MessageBox.Show("계좌 검증이 완료되었습니다!");
                TelDCPrice.Text = (int.Parse(TelDCPrice.Text) + usepoint).ToString();
                CardNumber.Enabled = false;
                DifferencePrice.Text = (int.Parse(TotalPrice.Text) - int.Parse(TelDCPrice.Text)-usepoint).ToString();
                CardPW.Enabled = false;
                button_check = true;
            }
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            if (!CreditCard.Checked && !AccountTransfer.Checked)
            {
                MessageBox.Show("결제 방법을 선택해 주세요!");
            }
            else if(!button_check)
            {
                MessageBox.Show("카드 승인 요청 및 계좌 검증을 해주세요!!");
            }

            else
            {
                OracleCommand Cmd = new OracleCommand();
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.CommandText = "RESV_PROC";
                Cmd.Connection = connect.con;

                Cmd.Parameters.Add(new OracleParameter("p_mem_id", member));
                Cmd.Parameters.Add(new OracleParameter("p_show_sche_no", show_schedule));
                Cmd.Parameters.Add(new OracleParameter("p_bk_seat_cnt", bk_seatcnt));
                Cmd.Parameters.Add(new OracleParameter("p_seat_no", seat_no));
                Cmd.Parameters.Add(new OracleParameter("p_pay_way", payway));
                Cmd.Parameters.Add(new OracleParameter("p_tel_nm", telnm));
                Cmd.Parameters.Add(new OracleParameter("p_use_point", usepoint));
                Cmd.Parameters.Add(new OracleParameter("p_cust_pw", cust_pw));
                Cmd.Parameters.Add(new OracleParameter("p_cust_nm", cust_nm));
                Cmd.Parameters.Add(new OracleParameter("p_cust_birth", cust_birth));
                Cmd.Parameters.Add(new OracleParameter("p_cust_telno", cust_telno));

                Cmd.ExecuteNonQuery();
                MessageBox.Show("결제가 완료되었습니다!");
            }
        }

        private void UsePoint_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력해주세요!");
            }
        }

        private void CardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력해주세요!");
            }
        }

        private void CardPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력해주세요!");
            }
        }

        private void AccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력해주세요!");
            }
        }

        private void AccountPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력해주세요!");
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
    }
}
