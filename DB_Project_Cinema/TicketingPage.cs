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
        private Payment payment;

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
            if (choose_seat.SeatCnt_Check())
            {
                payment = new Payment(_parent.GetLoginId(), choose_seat.Get_SchNo(), choose_seat.Get_BkSeatCnt(), choose_seat.Get_SeatNo());
                panel2.Controls.Add(payment);
                payment.BringToFront();
                payment.Dock = DockStyle.None;

                PaymentPageButton.Visible = false;
                ChooseSeatPageButton.Visible = false;
                BackToChooseSeatButton.Visible = true;
                BackToSelcetTimeButton.Visible = false;

            }
        }

        private void ChooseSeatPageButton_Click_1(object sender, EventArgs e)
        {
            if (showtime_page.Get_SchNo() == null)
            {
                MessageBox.Show("상영일자 혹은 상영시간이 선택되지 않았습니다.");
            }
            else if (_parent.GetLoginId() == String.Empty)
            {
                if (MessageBox.Show("비회원으로 예매 하시겠습니까?", "", MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    _parent.mainPanel.Controls.Add(JoinCust.Instance);
                    JoinCust.Instance.Dock = DockStyle.Fill;
                    JoinCust.Instance.BringToFront();
                }
                else
                {
                    MessageBox.Show("회원으로 로그인 해주세요!");
                }
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
