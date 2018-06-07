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
    public partial class TicketingPage : UserControl
    {
        private CinemaProgram _parent;
        /*
        private static TicketingPage _instance;
        public static TicketingPage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TicketingPage();
                }
                return _instance;
            }
        }*/
        public TicketingPage(CinemaProgram parent)
        {
            InitializeComponent();
            _parent = parent;
            SelectShowTime showtime_page = new SelectShowTime();
            panel2.Controls.Add(showtime_page);

            showtime_page.BringToFront();
            showtime_page.Dock = DockStyle.None;
            
            PaymentPageButton.Visible = false;
            ChooseSeatPageButton.Visible = true;
            BackToChooseSeatButton.Visible = false;
            BackToSelcetTimeButton.Visible = false;
        }

        private void BackToSelcetTimeButton_Click_1(object sender, EventArgs e)
        {
            SelectShowTime showtime_page = new SelectShowTime();
            panel2.Controls.Add(showtime_page);

            showtime_page.BringToFront();
            showtime_page.Dock = DockStyle.None;

            PaymentPageButton.Visible = false;
            ChooseSeatPageButton.Visible = true;
            BackToChooseSeatButton.Visible = false;
            BackToSelcetTimeButton.Visible = false;
        }

        private void BackToChooseSeatButton_Click_1(object sender, EventArgs e)
        {
            ChooseSeat cs = new ChooseSeat(_parent.GetLoginId(), _parent.GetMovieName(), _parent.GetDate(), _parent.GetTime());
            panel2.Controls.Add(cs);

            cs.BringToFront();
            cs.Dock = DockStyle.None; 

            ChooseSeatPageButton.Visible = false;
            PaymentPageButton.Visible = true;
            BackToSelcetTimeButton.Visible = true;
            BackToChooseSeatButton.Visible = false;
        }

        private void PaymentPageButton_Click_1(object sender, EventArgs e)
        {
            //Payment.BringToFront();
            PaymentPageButton.Visible = false;
            ChooseSeatPageButton.Visible = false;
            BackToChooseSeatButton.Visible = true;
            BackToSelcetTimeButton.Visible = false;
        }

        private void ChooseSeatPageButton_Click_1(object sender, EventArgs e)
        {
            if (_parent.GetLoginId() == String.Empty )
            {
                MessageBox.Show("로그인을 하세요!"); 
                Console.WriteLine(CinemaProgram.Instance.GetDate()+_parent.GetDate()+"@@@@@@@");
            }
            else if (_parent.GetDate() == String.Empty || _parent.GetTime() == String.Empty)
            {
                MessageBox.Show("상영일자 혹은 상영시간이 선택되지 않았습니다.");
                Console.WriteLine("!!!!!!!");
            }
            else
            {
                ChooseSeat cs = new ChooseSeat(_parent.GetLoginId(), _parent.GetMovieName(), _parent.GetDate(), _parent.GetTime());
                panel2.Controls.Add(cs);

                cs.BringToFront();
                cs.Dock = DockStyle.None; 
                
                ChooseSeatPageButton.Visible = false;
                PaymentPageButton.Visible = true;
                BackToSelcetTimeButton.Visible = true;
                BackToChooseSeatButton.Visible = false;
            }
        }
    }
}
