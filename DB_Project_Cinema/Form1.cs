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

        public void MovieDetailPage_Add(int movie_no)
        {
            MovieDetail moviedetail = new MovieDetail(movie_no);
            moviedetail.SetParent(this);
            this.mainPanel.Controls.Add(moviedetail);
            moviedetail.Dock = DockStyle.Fill;
            moviedetail.BringToFront();
        }
        

        private void CinemaProgram_Load(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Contains(MoviePage.Instance))
            {
                mainPanel.Controls.Remove(MoviePage.Instance);
            }
            mainPanel.Controls.Add(MoviePage.Instance);
            MoviePage.Instance.SetParent(this);
            MoviePage.Instance.Dock = DockStyle.Fill;
            MoviePage.Instance.BringToFront();
            
            Logout_clicked();
        }

        public void Login_Complete(string memberId)
        {
            login_mem_id = memberId;
            LoginPageButton.Visible = false;
            FindIDandPWButton.Visible = false;
            JoinMembershipButton.Visible = false;
            LogoutButton.Visible = true;
            checkResv.Visible = false;

            MoviePage.Instance.SetMem_id(memberId);
        }

        public string GetLoginId()
        {
            return login_mem_id;
        }

        private void MoviePageButton_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Contains(MoviePage.Instance))
            {
                mainPanel.Controls.Remove(MoviePage.Instance);
               // foreach (var c in MoviePage.Instance.Controls)
              //  {
               //     MoviePage.Instance.Controls.Remove((Control)c);
               // }
                
            }
            MoviePage.Instance.View_PlayingMovie();
            mainPanel.Controls.Add(MoviePage.Instance);
            MoviePage.Instance.SetParent(this);
            MoviePage.Instance.Dock = DockStyle.Fill;
            MoviePage.Instance.BringToFront();
            

            MoviePageButton.BackColor = Color.DimGray;
            TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            checkResv.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            FindIDandPWButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }

        private void TicketingPageButton_Click(object sender, EventArgs e)
        {

            Join_Cust();

            MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            TicketingPageButton.BackColor = Color.DimGray;
            ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            checkResv.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            JoinMembershipButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            FindIDandPWButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }
        public void Join_Cust()
        {
            if (GetLoginId() == String.Empty)
            {
                if (MessageBox.Show("비회원으로 예매 하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    JoinCust jc = new JoinCust(this);
                    mainPanel.Controls.Add(jc);
                    jc.Dock = DockStyle.Fill;
                    jc.BringToFront();
                }
                else
                {
                    MessageBox.Show("회원으로 로그인 해주세요!");
                }
            }
            else
            {
                TicketingPage tp = new TicketingPage(this);
                mainPanel.Controls.Add(tp);
                tp.Dock = DockStyle.Fill;
                tp.BringToFront();
            }
        }
        public void load_ticketPage(string cust_name, string cust_sid, string cust_tel, string cust_pw)
        {
            TicketingPage tp = new TicketingPage(this);
            mainPanel.Controls.Add(tp);
            tp.Dock = DockStyle.Fill;
            tp.BringToFront();
            tp.SetCustNM(cust_name);
            tp.SetCustSid(cust_sid);
            tp.SetCustTel(cust_tel);
            tp.SetCustPw(cust_pw);
        }
        private void ScreenInfoButton_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Contains(ScreenInfo.Instance))
            {
                mainPanel.Controls.Remove(ScreenInfo.Instance);
            }
           
           mainPanel.Controls.Add(ScreenInfo.Instance);
           ScreenInfo.Instance.Dock = DockStyle.Fill;
           ScreenInfo.Instance.BringToFront();

            MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ScreenInfoButton.BackColor = Color.DimGray;
            LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            checkResv.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
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
            checkResv.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            JoinMembershipButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            FindIDandPWButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }

        private void MyPageButton_Click(object sender, EventArgs e)
        {
            if (!LoginPageButton.Visible)
            {
                MyPage mypage = new MyPage(this);
                mainPanel.Controls.Add(mypage);
                mypage.Dock = DockStyle.Fill;
                mypage.BringToFront();

                MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                checkResv.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                MyPageButton.BackColor = Color.DimGray;
                JoinMembershipButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
                FindIDandPWButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
            else
            {
                MessageBox.Show("로그인을 하세요!");
            }

        }

       
        private void JoinMembershipButton_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Contains(JoinMembership.Instance))
            {
                mainPanel.Controls.Remove(JoinMembership.Instance);
                
            }
            mainPanel.Controls.Add(JoinMembership.Instance);
            JoinMembership.Instance.Dock = DockStyle.Fill;
            JoinMembership.Instance.BringToFront();
            
            MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            checkResv.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            JoinMembershipButton.BackColor = Color.DimGray;
            FindIDandPWButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }

        private void FindIDandPWButton_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Contains(FindIDandPW.Instance))
            {
                mainPanel.Controls.Remove(FindIDandPW.Instance);
            }
            mainPanel.Controls.Add(FindIDandPW.Instance);
            FindIDandPW.Instance.Dock = DockStyle.Fill;
            FindIDandPW.Instance.BringToFront();
            

            MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            checkResv.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            JoinMembershipButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            FindIDandPWButton.BackColor = Color.DimGray;
        }

         private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("로그아웃 되었습니다.");
            Logout_clicked();
            login_mem_id = String.Empty;
        }

        public void Logout_clicked()
        {
            login_mem_id = String.Empty;
            LoginPageButton.Visible = true;
            FindIDandPWButton.Visible = true; 
            JoinMembershipButton.Visible = true;
            LogoutButton.Visible = false;
            checkResv.Visible = true;

            MoviePage.Instance.SetMem_id(String.Empty);
            MoviePage.Instance.Dock = DockStyle.Fill;
            MoviePage.Instance.BringToFront();            
        }

        public void checkResv_Click(object sender, EventArgs e)
        {
            LoginCust logincust = new LoginCust(this);
            mainPanel.Controls.Add(logincust);
            logincust.Dock = DockStyle.Fill;
            logincust.BringToFront();


            MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            checkResv.BackColor = Color.DimGray;
            JoinMembershipButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            FindIDandPWButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }
    }
}
