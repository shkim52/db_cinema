using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DB_Project_Cinema
{
    public partial class CinemaProgram : Form
    {
      
        public CinemaProgram()
        {
            InitializeComponent();

            MoviePage.BringToFront();
            
            
        }

        private void MoviePageButton_Click(object sender, EventArgs e)
        {
            
            MoviePage.BringToFront();

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
            
            TicketingPage.BringToFront();

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
            
            ScreenInfo.BringToFront();

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
            
            LoginPage.BringToFront();

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
            
            MyPage.BringToFront();

            MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = Color.DimGray;
            DiscountCardButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            JoinMembershipButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            FindIDandPWButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);

        }

        

        private void DiscountCardButton_Click(object sender, EventArgs e)
        {
            
            DiscountCard.BringToFront();

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
           
            JoinMembership.BringToFront();

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
            FindIDandPW.BringToFront();

            MoviePageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            TicketingPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            ScreenInfoButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            LoginPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            MyPageButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            DiscountCardButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            JoinMembershipButton.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            FindIDandPWButton.BackColor = Color.DimGray;
        }
    }
}
