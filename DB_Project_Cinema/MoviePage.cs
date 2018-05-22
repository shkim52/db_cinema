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
    public partial class MoviePage : UserControl
    {
        public MoviePage()
        {
            InitializeComponent();

            MovieList.BringToFront();

            BackToHomeButton.Visible = false;
            ReviewButton.Visible = false;
        }

        private void Movie1DetailButton_Click(object sender, EventArgs e)
        {
            MovieDetail.BringToFront();

            Movie1DetailButton.Visible = false;
            Movie2DetailButton.Visible = false;
            Movie3DetailButton.Visible = false;
            Movie4DetailButton.Visible = false;
            Movie5DetailButton.Visible = false;

            BackToHomeButton.Visible = true;
            ReviewButton.Visible = true;
        }

        private void BackToHomeButton_Click(object sender, EventArgs e)
        {
            MovieList.BringToFront();

            Movie1DetailButton.Visible = true;
            Movie2DetailButton.Visible = true;
            Movie3DetailButton.Visible = true;
            Movie4DetailButton.Visible = true;
            Movie5DetailButton.Visible = true;

            BackToHomeButton.Visible = false;
            ReviewButton.Visible = false;
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            Movie1DetailButton.Visible = false;
            Movie2DetailButton.Visible = false;
            Movie3DetailButton.Visible = false;
            Movie4DetailButton.Visible = false;
            Movie5DetailButton.Visible = false;

            BackToHomeButton.Visible = true;
            ReviewButton.Visible = false;

            ReviewPage.BringToFront();
        }
    }
}
