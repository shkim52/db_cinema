using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project_Cinema
{
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();

            MemLoginButton.FlatAppearance.BorderColor = Color.Red;
            MemLoginButton.FlatAppearance.BorderSize = 1;
            CustLoginButton.FlatAppearance.BorderSize = 0;
            LoginMember.BringToFront();


        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void loginMember1_Load(object sender, EventArgs e)
        {

        }

        private void MemLoginButton_Click(object sender, EventArgs e)
        {
            MemLoginButton.FlatAppearance.BorderColor = Color.Red;
            MemLoginButton.FlatAppearance.BorderSize = 1;
            CustLoginButton.FlatAppearance.BorderSize = 0;
            LoginMember.BringToFront();
        }

        private void CustLoginButton_Click(object sender, EventArgs e)
        {
            CustLoginButton.FlatAppearance.BorderColor = Color.Red;
            CustLoginButton.FlatAppearance.BorderSize = 1;
            MemLoginButton.FlatAppearance.BorderSize = 0;
            LoginCustomer.BringToFront();
        }
    }
}
