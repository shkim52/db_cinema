using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace DB_Project_Cinema
{
    public partial class MoviePicture : UserControl
    {
        Connection connect;
        private int selected_movie_no;
        public MoviePicture(int selected_movie)
        {
            InitializeComponent();

            selected_movie_no = selected_movie;
        }
        private void MoviePicture_Load(object sender, EventArgs e)
        {
            connect = new Connection();
            connect.Connecting();
            PictureLoad();
        }
        private int CountPicture()
        {
            string sql = "SELECT COUNT(*) FROM MV_PHOTO WHERE MOVIE_NO = " + selected_movie_no;
            OracleCommand Comm = new OracleCommand(sql, connect.con);
            OracleDataReader reader = Comm.ExecuteReader();
            int count = Convert.ToInt32(Comm.ExecuteScalar());
            
            return count;
        }
        private void PictureLoad()
        {
            int count = CountPicture();

        }
    }
}
