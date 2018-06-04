using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data.SqlClient;

namespace DB_Project_Cinema
{
    public partial class CinemaProgram : Form
    {

        public CinemaProgram()
        {
            InitializeComponent();

        }

        private void MoviePageButton_Click(object sender, EventArgs e)
        {

            if (!mainPanel.Controls.Contains(MoviePage.Instance))
            {
                mainPanel.Controls.Add(MoviePage.Instance);
                MoviePage.Instance.Dock = DockStyle.Fill;
                MoviePage.Instance.BringToFront();
            }
            else
            {
                MoviePage.Instance.BringToFront();
            }
            MoviePageButton.BackColor = Color.DimGray;
            TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            DiscountCardButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            JoinMembershipButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            FindIDandPWButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);


        }

        private void TicketingPageButton_Click(object sender, EventArgs e)
        {

            if (!mainPanel.Controls.Contains(TicketingPage.Instance))
            {
                mainPanel.Controls.Add(TicketingPage.Instance);
                TicketingPage.Instance.Dock = DockStyle.Fill;
                TicketingPage.Instance.BringToFront();
            }
            else
            {
                TicketingPage.Instance.BringToFront();
            }
            MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            TicketingPageButton.BackColor = Color.DimGray;
            ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            DiscountCardButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            JoinMembershipButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            FindIDandPWButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }



        private void ScreenInfoButton_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(ScreenInfo.Instance))
            {
                mainPanel.Controls.Add(ScreenInfo.Instance);
                ScreenInfo.Instance.Dock = DockStyle.Fill;
                ScreenInfo.Instance.BringToFront();
            }
            else
            {
                ScreenInfo.Instance.BringToFront();
            }

            MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ScreenInfoButton.BackColor = Color.DimGray;
            LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            DiscountCardButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            JoinMembershipButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            FindIDandPWButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }

        private void LoginPageButton_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(LoginPage.Instance))
            {
                mainPanel.Controls.Add(LoginPage.Instance);
                LoginPage.Instance.Dock = DockStyle.Fill;
                LoginPage.Instance.BringToFront();
            }
            else
            {
                LoginPage.Instance.BringToFront();
            }
            MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            LoginPageButton.BackColor = Color.DimGray;
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            DiscountCardButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            JoinMembershipButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            FindIDandPWButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }

        private void MyPageButton_Click(object sender, EventArgs e)
        {
            if (Program.memID != "")
            {
                if (!mainPanel.Controls.Contains(MyPage.Instance))
                {
                    mainPanel.Controls.Add(MyPage.Instance);
                    MyPage.Instance.Dock = DockStyle.Fill;
                    MyPage.Instance.BringToFront();
                }
                else
                {
                    MyPage.Instance.BringToFront();
                }
                MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                MyPageButton.BackColor = Color.DimGray;
                DiscountCardButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                JoinMembershipButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                FindIDandPWButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
            else
            {
                MessageBox.Show("로그인을 하세요!");
            }

        }



        private void DiscountCardButton_Click(object sender, EventArgs e)
        {

            if (!mainPanel.Controls.Contains(DiscountCard.Instance))
            {
                mainPanel.Controls.Add(DiscountCard.Instance);
                DiscountCard.Instance.Dock = DockStyle.Fill;
                DiscountCard.Instance.BringToFront();
            }
            else
            {
                DiscountCard.Instance.BringToFront();
            }

            MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            DiscountCardButton.BackColor = Color.DimGray;
            JoinMembershipButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            FindIDandPWButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);

        }

        private void JoinMembershipButton_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(JoinMembership.Instance))
            {
                mainPanel.Controls.Add(JoinMembership.Instance);
                JoinMembership.Instance.Dock = DockStyle.Fill;
                JoinMembership.Instance.BringToFront();
            }
            else
            {
                JoinMembership.Instance.BringToFront();
            }

            MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            DiscountCardButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            JoinMembershipButton.BackColor = Color.DimGray;
            FindIDandPWButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }



        private void FindIDandPWButton_Click(object sender, EventArgs e)
        {
            if (!mainPanel.Controls.Contains(FindIDandPW.Instance))
            {
                mainPanel.Controls.Add(FindIDandPW.Instance);
                FindIDandPW.Instance.Dock = DockStyle.Fill;
                FindIDandPW.Instance.BringToFront();
            }
            else
            {
                FindIDandPW.Instance.BringToFront();
            }

            MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            DiscountCardButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            JoinMembershipButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            FindIDandPWButton.BackColor = Color.DimGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그아웃 되었습니다.");
            Program.memID = "";
            this.Close();
        }

        private void CinemaProgram_Load(object sender, EventArgs e)
        {

            if (!mainPanel.Controls.Contains(MoviePage.Instance))
            {
                mainPanel.Controls.Add(MoviePage.Instance);
                MoviePage.Instance.Dock = DockStyle.Fill;
                MoviePage.Instance.BringToFront();
            }
            else
            {
                MoviePage.Instance.BringToFront();
            }

            if (Program.memID == "" && Program.custID == "")
            {
                LogoutButton.Enabled = false;
            }
            else
            {
                LoginPageButton.Enabled = false;
                FindIDandPWButton.Enabled = false;
                JoinMembershipButton.Enabled = false;
            }

        }
    }
}
