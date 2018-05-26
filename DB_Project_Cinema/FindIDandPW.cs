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
    public partial class FindIDandPW : UserControl
    {
        public FindIDandPW()
        {
            InitializeComponent();

            FindIDButton.FlatAppearance.BorderColor = Color.Red;
            FindIDButton.FlatAppearance.BorderSize = 1;
            FindPWButton.FlatAppearance.BorderSize = 0;

            FindID.BringToFront();
        }

        private void MemLoginButton_Click(object sender, EventArgs e)
        {

        }

       

        private void FindIDButton_Click_1(object sender, EventArgs e)
        {
            FindIDButton.FlatAppearance.BorderColor = Color.Red;
            FindIDButton.FlatAppearance.BorderSize = 1;
            FindPWButton.FlatAppearance.BorderSize = 0;

            FindID.BringToFront();
        }

        private void FindPWButton_Click_1(object sender, EventArgs e)
        {
            FindPWButton.FlatAppearance.BorderColor = Color.Red;
            FindPWButton.FlatAppearance.BorderSize = 1;
            FindIDButton.FlatAppearance.BorderSize = 0;

            FindPW.BringToFront();
        }
    }
}
