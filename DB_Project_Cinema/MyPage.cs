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
        private string mem_id; //나중에 지울부분
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

            SubPanel.Controls.Add(MyPageChangeInfo.Instance);
            MyPageChangeInfo.Instance.MyPageChangeInfo_test();
            MyPageChangeInfo.Instance.BringToFront();
            MyPageChangeInfo.Instance.Dock = DockStyle.None;
        }

        private void MyPageChangePwButton_Click(object sender, EventArgs e)
        {
            MyPageChangeInfoButton.BackColor = Color.White;
            MyPageChangePwButton.BackColor = Color.AntiqueWhite;
            MyPageQuitMemButton.BackColor = Color.White;
            MyPageCheckResvButton.BackColor = Color.White;
            MyPageInterestButton.BackColor = Color.White;
            MyPageMyPointButton.BackColor = Color.White;

            SubPanel.Controls.Add(MyPageChangePw.Instance);
            MyPageChangePw.Instance.setMem_id(_parent.GetLoginId());
            MyPageChangePw.Instance.BringToFront();
            MyPageChangePw.Instance.Dock = DockStyle.None;
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

            SubPanel.Controls.Add(MyPageCheckResv.Instance);

            MyPageCheckResv.Instance.setMem_id(_parent.GetLoginId());
            MyPageCheckResv.Instance.BringToFront();
            MyPageCheckResv.Instance.Dock = DockStyle.None;
        }

        private void MyPageInterestButton_Click(object sender, EventArgs e)
        {
            MyPageChangeInfoButton.BackColor = Color.White;
            MyPageChangePwButton.BackColor = Color.White;
            MyPageQuitMemButton.BackColor = Color.White;
            MyPageCheckResvButton.BackColor = Color.White;
            MyPageInterestButton.BackColor = Color.AntiqueWhite;
            MyPageMyPointButton.BackColor = Color.White;

            SubPanel.Controls.Add(MyPageInterest.Instance);

            MyPageInterest.Instance.setMem_id(_parent.GetLoginId());
            MyPageInterest.Instance.BringToFront();
            MyPageInterest.Instance.Dock = DockStyle.None;
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
    }
}
