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
        //private static MyPage _instance;
        private CinemaProgram _parent;

        /*public static MyPage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MyPage();
                }
                return _instance;
            }
        }*/

        public MyPage(CinemaProgram parent)
        {
            InitializeComponent();
            _parent = parent;

            Console.WriteLine("--------------------");
            Console.WriteLine(_parent.GetLoginId());
        }
        ~MyPage()
        {

        }
       /* public void setMem_id(string s)
        {
            mem_id = s;
        }*/        

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

            SubPanel.Controls.Add(MyPageQuitMem.Instance);
            MyPageQuitMem.Instance.setMem_id(_parent.GetLoginId());
            MyPageQuitMem.Instance.BringToFront();
            MyPageQuitMem.Instance.Dock = DockStyle.None;
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
            MovieDetail moviedetail = new MovieDetail(movie_no);
            this.Parent.Controls.Remove(this);
            this.Controls.Remove(this);
            _parent.MovieDetailPage_Add(moviedetail);
        }
    }
}
