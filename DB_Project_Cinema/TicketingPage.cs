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
        }
        public TicketingPage()
        {
            InitializeComponent();

            SelectShowTime.BringToFront();
            PaymentPageButton.Visible = false;
            ChooseSeatPageButton.Visible = true;
            BackToChooseSeatButton.Visible = false;
            BackToSelcetTimeButton.Visible = false;


        }

        private void BackToSelcetTimeButton_Click_1(object sender, EventArgs e)
        {
            SelectShowTime.BringToFront();
            PaymentPageButton.Visible = false;
            ChooseSeatPageButton.Visible = true;
            BackToChooseSeatButton.Visible = false;
            BackToSelcetTimeButton.Visible = false;
        }

        private void BackToChooseSeatButton_Click_1(object sender, EventArgs e)
        {
            ChooseSeat.BringToFront();
            ChooseSeatPageButton.Visible = false;
            PaymentPageButton.Visible = true;
            BackToSelcetTimeButton.Visible = true;
            BackToChooseSeatButton.Visible = false;
        }

        private void PaymentPageButton_Click_1(object sender, EventArgs e)
        {
            Payment.BringToFront();
            PaymentPageButton.Visible = false;
            ChooseSeatPageButton.Visible = false;
            BackToChooseSeatButton.Visible = true;
            BackToSelcetTimeButton.Visible = false;
        }

        private void ChooseSeatPageButton_Click_1(object sender, EventArgs e)
        {
            //if (Program.memID != "")
            {
                ChooseSeat.BringToFront();
                ChooseSeatPageButton.Visible = false;
                PaymentPageButton.Visible = true;
                BackToSelcetTimeButton.Visible = true;
                BackToChooseSeatButton.Visible = false;
            }
            //else
            {
               // MessageBox.Show("로그인을 하세요!");

            }
        }
    }
}
