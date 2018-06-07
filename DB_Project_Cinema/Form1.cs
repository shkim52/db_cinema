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
        private static CinemaProgram _instance;
        private string login_mem_id;

        public static CinemaProgram Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CinemaProgram();
                }
                return _instance;
            }
        }
        public CinemaProgram()
        {
            InitializeComponent();
            login_mem_id = String.Empty;

        }
        public void MovieDetailPage_Add(Control page)
        {
           MoviePage.Instance.panel3.Controls.Add(page);
           page.Dock = DockStyle.None;
           page.BringToFront();
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
            Logout_clicked();

        }

        public void Login_Complete(string memberId)
        {
            login_mem_id = memberId;
            LoginPageButton.Visible = false;
            FindIDandPWButton.Visible = false;
            JoinMembershipButton.Visible = false;
            LogoutButton.Visible = true;
        }

        public string GetLoginId()
        {
            return login_mem_id;
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
            LoginPage lp = new LoginPage(this);
            mainPanel.Controls.Add(lp);
            lp.Dock = DockStyle.Fill;
            lp.BringToFront();            

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
            if (!LoginPageButton.Visible)
            {
                /*if (!mainPanel.Controls.Contains(MyPage.Instance))
                {
                    mainPanel.Controls.Add(MyPage.Instance);
                    MyPage.Instance.Dock = DockStyle.Fill;
                    MyPage.Instance.BringToFront();
                }
                else
                {
                    MyPage.Instance.BringToFront();
                }*/

                MyPage mypage = new MyPage(this);
                mainPanel.Controls.Add(mypage);
                mypage.Dock = DockStyle.Fill;
                mypage.BringToFront();

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
        // 아래 두 메소드는 왜 분리되어있는가??
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그아웃 되었습니다.");
            Logout_clicked();
            login_mem_id = string.Empty;
            //MovieDetail.Instance.setMem_id("");
            ReviewPage.Instance.setMem_id("");
        }


        public void Logout_clicked()
        {
            login_mem_id = string.Empty;
            LoginPageButton.Visible = true;
            FindIDandPWButton.Visible = true; 
            JoinMembershipButton.Visible = true;
            LogoutButton.Visible = false;
        }
    }
}
