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
    public partial class MyPageCheckResv : UserControl
    {
        private static MyPageCheckResv _instance;
        public static MyPageCheckResv Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MyPageCheckResv();
                }
                return _instance;
            }
        }

        private string mem_id;
        public void setMem_id(string s)
        {
            mem_id = s;
        }
        public MyPageCheckResv()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
