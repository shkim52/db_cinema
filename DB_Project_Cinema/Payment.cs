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
        private string member;
        private string show_schedule;

        public Payment(string mem_id, string schedule_no)
        {
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();

            member = mem_id;
            show_schedule = schedule_no;

            TelNM_View();
            Point_View();
           
        
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }     
        }

        private void PhoneNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력해주세요!");
            }
        }

        private void PhoneVerification_Click(object sender, EventArgs e)
        {
            MessageBox.Show("휴대폰 인증이 완료되었습니다!");
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
                 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void UsePoint_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SavePoint.Text) < 1000)
            {
                MessageBox.Show("1000Point 이상부터 사용 가능합니다!");
            }
        }

        private void CreditCard_Click(object sender, EventArgs e)
        {
            if (CreditCard.Checked)
            {
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
        
    }
}
