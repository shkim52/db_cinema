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
    public partial class DiscountCard : UserControl
    {
        private static DiscountCard _instance;
        public static DiscountCard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DiscountCard();
                }
                return _instance;
            }
        }
        public DiscountCard()
        {
            InitializeComponent();
        }
    }
}
