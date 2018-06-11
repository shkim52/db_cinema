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
        private CinemaProgram _parent;

        public MyPage(CinemaProgram parent)
        {
            InitializeComponent();
            _parent = parent;
            Console.WriteLine(_parent.GetLoginId());
        }
        ~MyPage()
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

            
            MyPageChangeInfo changeinfo_page = new MyPageChangeInfo(_parent.GetLoginId());
            SubPanel.Controls.Add(changeinfo_page);
            changeinfo_page.BringToFront();
            changeinfo_page.Dock = DockStyle.None;
        }

        private void MyPageChangePwButton_Click(object sender, EventArgs e)
        {
            MyPageChangeInfoButton.BackColor = Color.White;
            MyPageChangePwButton.BackColor = Color.AntiqueWhite;
            MyPageQuitMemButton.BackColor = Color.White;
            MyPageCheckResvButton.BackColor = Color.White;
            MyPageInterestButton.BackColor = Color.White;
            MyPageMyPointButton.BackColor = Color.White;

            MyPageChangePw changepw_page = new MyPageChangePw(_parent.GetLoginId());
            SubPanel.Controls.Add(changepw_page);
            changepw_page.BringToFront();
            changepw_page.Dock = DockStyle.None;
        }

        private void MyPageQuitMemButton_Click(object sender, EventArgs e)
        {
            MyPageChangeInfoButton.BackColor = Color.White;
            MyPageChangePwButton.BackColor = Color.White;
            MyPageQuitMemButton.BackColor = Color.AntiqueWhite;
            MyPageCheckResvButton.BackColor = Color.White;
            MyPageInterestButton.BackColor = Color.White;
            MyPageMyPointButton.BackColor = Color.White;

            MyPageQuitMem mpq = new MyPageQuitMem(this);
            SubPanel.Controls.Add(mpq);
            mpq.setMem_id(_parent.GetLoginId());
            mpq.BringToFront();
            mpq.Dock = DockStyle.None;
        }

        private void MyPageCheckResvButton_Click(object sender, EventArgs e)
        {
            MyPageChangeInfoButton.BackColor = Color.White;
            MyPageChangePwButton.BackColor = Color.White;
            MyPageQuitMemButton.BackColor = Color.White;
            MyPageCheckResvButton.BackColor = Color.AntiqueWhite;
            MyPageInterestButton.BackColor = Color.White;
            MyPageMyPointButton.BackColor = Color.White;

            MyPageCheckResv changepw_page = new MyPageCheckResv(_parent.GetLoginId());
            SubPanel.Controls.Add(changepw_page);
            changepw_page.BringToFront();
            changepw_page.Dock = DockStyle.None;
        }

        private void MyPageInterestButton_Click(object sender, EventArgs e)
        {
            MyPageChangeInfoButton.BackColor = Color.White;
            MyPageChangePwButton.BackColor = Color.White;
            MyPageQuitMemButton.BackColor = Color.White;
            MyPageCheckResvButton.BackColor = Color.White;
            MyPageInterestButton.BackColor = Color.AntiqueWhite;
            MyPageMyPointButton.BackColor = Color.White;

            MyPageInterest interest_page = new MyPageInterest(this,_parent.GetLoginId());
            SubPanel.Controls.Add(interest_page);
            interest_page.BringToFront();
            interest_page.Dock = DockStyle.None;
        }

        private void MyPageMyPointButton_Click(object sender, EventArgs e)
        {
            MyPageChangeInfoButton.BackColor = Color.White;
            MyPageChangePwButton.BackColor = Color.White;
            MyPageQuitMemButton.BackColor = Color.White;
            MyPageCheckResvButton.BackColor = Color.White;
            MyPageInterestButton.BackColor = Color.White;
            MyPageMyPointButton.BackColor = Color.AntiqueWhite;

            SubPanel.Controls.Add(MyPageMyPoint.Instance);

            MyPageMyPoint.Instance.setMem_id(_parent.GetLoginId());
            MyPageMyPoint.Instance.BringToFront();
            MyPageMyPoint.Instance.Dock = DockStyle.None; 
        }
        public void Interest_MovieDetail_View(int movie_no)
        {
            this.Parent.Controls.Remove(this);
            this.Controls.Remove(this);
            _parent.MovieDetailPage_Add(movie_no);
        }
        public void click_logout()
        {
            this.Parent.Controls.Remove(this);
            this.Controls.Remove(this);
            _parent.Logout_clicked();
        }
    }
}
