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
        private SelectShowTime showtime_page;
        private ChooseSeat choose_seat;

        public TicketingPage(CinemaProgram parent)
        {
            InitializeComponent();
            _parent = parent;

            showtime_page = new SelectShowTime();
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

        // 이름은 backto이지만 좌석선택하는 버튼인가??
        private void BackToChooseSeatButton_Click_1(object sender, EventArgs e)
        {
            choose_seat = new ChooseSeat(_parent.GetLoginId(), showtime_page.Get_SchNo());
            panel2.Controls.Add(choose_seat);

            choose_seat.BringToFront();
            choose_seat.Dock = DockStyle.None;

            ChooseSeatPageButton.Visible = false;
            PaymentPageButton.Visible = true;
            BackToSelcetTimeButton.Visible = true;
            BackToChooseSeatButton.Visible = false;
        }

        private void PaymentPageButton_Click_1(object sender, EventArgs e)
        {
            //Payment.BringToFront();
            if (choose_seat.SeatCnt_Check())
            {
                PaymentPageButton.Visible = false;
                ChooseSeatPageButton.Visible = false;
                BackToChooseSeatButton.Visible = true;
                BackToSelcetTimeButton.Visible = false;
            }
        }

        private void ChooseSeatPageButton_Click_1(object sender, EventArgs e)
        {
            if (_parent.GetLoginId() == String.Empty)
            {
                MessageBox.Show("로그인을 하세요!");
            }
            else if (showtime_page.Get_SchNo() == null)
            {
                MessageBox.Show("상영일자 혹은 상영시간이 선택되지 않았습니다.");
            }
            else
            {
                choose_seat = new ChooseSeat(_parent.GetLoginId(), showtime_page.Get_SchNo());
                panel2.Controls.Add(choose_seat);

                choose_seat.BringToFront();
                choose_seat.Dock = DockStyle.None;

                ChooseSeatPageButton.Visible = false;
                PaymentPageButton.Visible = true;
                BackToSelcetTimeButton.Visible = true;
                BackToChooseSeatButton.Visible = false;
            }
        }
    }
}
