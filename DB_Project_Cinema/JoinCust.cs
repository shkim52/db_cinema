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
        private static JoinCust _instance;
        private Connection connect;
        public static JoinCust Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new JoinCust();
                }
                return _instance;
            }
        }

        public JoinCust()
        {
            InitializeComponent();
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
                if (CustNameTextbox.Text == "" || CustResidentTextbox.Text == "" || CustHPNumTextbox.Text == "" || CustPWTextbox.Text=="")
                {
                    MessageBox.Show("모든 정보를 입력해주세요.");
                }
                else if (CustResidentTextbox.Text.Length != 6)
                {
                    MessageBox.Show("생년월일 6자리를 입력해주세요.");
                }
                else
                {
                    MessageBox.Show("임시 ID는 티켓예매번호이며 티켓예매번호와 비밀번호를 잊어버리면 예매확인이 어려우니 양해부탁드립니다!");
                }

                CinemaProgram cp = new CinemaProgram();
                this.Parent.Controls.Remove(this);
                ChooseSeat cs = new ChooseSeat("", new SelectShowTime().Get_SchNo());
                cp.mainPanel.Controls.Add(cs);
                cs.Dock = DockStyle.Fill;
                cs.BringToFront();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void CustResidentTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력해주세요!");
            }
        }

        private void CustHPNumTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력해주세요!");
            }
        }
    }
}
