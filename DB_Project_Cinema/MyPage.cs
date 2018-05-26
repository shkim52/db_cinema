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
    public partial class MyPage : UserControl
    {
        public MyPage()
        {
            InitializeComponent();

            MyPageConfirmPW.BringToFront();
        }

       

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void MyPageChangeInfoButton_Click(object sender, EventArgs e)
        {
            MyPageChangeInfoButton.BackColor = Color.AntiqueWhite;
            MyPageChangePwButton.BackColor = Color.White;
            MyPageQuitMemButton.BackColor = Color.White;
            MyPageCheckResvButton.BackColor = Color.White;
            MyPageInterestButton.BackColor = Color.White;
            MyPageMyPointButton.BackColor = Color.White;

            MyPageChangeInfo.BringToFront();
        }

        private void MyPageChangePwButton_Click(object sender, EventArgs e)
        {
            MyPageChangeInfoButton.BackColor = Color.White;
            MyPageChangePwButton.BackColor = Color.AntiqueWhite;
            MyPageQuitMemButton.BackColor = Color.White;
            MyPageCheckResvButton.BackColor = Color.White;
            MyPageInterestButton.BackColor = Color.White;
            MyPageMyPointButton.BackColor = Color.White;

            MyPageChangePw.BringToFront();
        }

        private void MyPageQuitMemButton_Click(object sender, EventArgs e)
        {
            MyPageChangeInfoButton.BackColor = Color.White;
            MyPageChangePwButton.BackColor = Color.White;
            MyPageQuitMemButton.BackColor = Color.AntiqueWhite;
            MyPageCheckResvButton.BackColor = Color.White;
            MyPageInterestButton.BackColor = Color.White;
            MyPageMyPointButton.BackColor = Color.White;

            MyPageQuitMem.BringToFront();
        }

        private void MyPageCheckResvButton_Click(object sender, EventArgs e)
        {
            MyPageChangeInfoButton.BackColor = Color.White;
            MyPageChangePwButton.BackColor = Color.White;
            MyPageQuitMemButton.BackColor = Color.White;
            MyPageCheckResvButton.BackColor = Color.AntiqueWhite;
            MyPageInterestButton.BackColor = Color.White;
            MyPageMyPointButton.BackColor = Color.White;

            MyPageCheckResv.BringToFront();
        }

        private void MyPageInterestButton_Click(object sender, EventArgs e)
        {
            MyPageChangeInfoButton.BackColor = Color.White;
            MyPageChangePwButton.BackColor = Color.White;
            MyPageQuitMemButton.BackColor = Color.White;
            MyPageCheckResvButton.BackColor = Color.White;
            MyPageInterestButton.BackColor = Color.AntiqueWhite;
            MyPageMyPointButton.BackColor = Color.White;

            MyPageInterest.BringToFront();
        }

        private void MyPageMyPointButton_Click(object sender, EventArgs e)
        {
            MyPageChangeInfoButton.BackColor = Color.White;
            MyPageChangePwButton.BackColor = Color.White;
            MyPageQuitMemButton.BackColor = Color.White;
            MyPageCheckResvButton.BackColor = Color.White;
            MyPageInterestButton.BackColor = Color.White;
            MyPageMyPointButton.BackColor = Color.AntiqueWhite;

            MyPageMyPoint.BringToFront();
        }
    }
}
