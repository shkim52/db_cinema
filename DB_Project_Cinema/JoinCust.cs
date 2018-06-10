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
    public partial class JoinCust : UserControl
    {
        CinemaProgram _parent;
        private Connection connect;

        public JoinCust(CinemaProgram parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void JoinCust_Load(object sender, EventArgs e)
        {
            connect = new Connection();
            connect.Connecting();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustNameTextbox.Text == "" || CustResidentTextbox.Text == "" || CustHPNumTextbox.Text == "" || CustPWTextbox.Text == "")
                {
                    MessageBox.Show("모든 정보를 입력해주세요.");
                }
                else if (CustResidentTextbox.Text.Length != 6)
                {
                    MessageBox.Show("생년월일 6자리를 입력해주세요.");
                }
                else if (CustHPNumTextbox.Text.Substring(0, 2) != "01")
                {
                    MessageBox.Show("핸드폰 번호의 입력이 잘못되었습니다.");
                }
                else
                {
                    MessageBox.Show("임시 ID는 티켓예매번호이며 티켓예매번호와 비밀번호를 잊어버리면 예매확인이 어려우니 양해부탁드립니다!");
                    this.Parent.Controls.Remove(this);
                    this.Controls.Remove(this);
                    _parent.load_ticketPage(CustNameTextbox.Text, CustResidentTextbox.Text, Convert.ToInt32(CustHPNumTextbox.Text), CustPWTextbox.Text);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void CustResidentTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력해주세요!");
            }
        }

        private void CustHPNumTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력해주세요!");
            }
        }
    }
}
