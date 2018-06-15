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
        private void PictureLoad()
        {
            try
            {
                string sql = "SELECT * FROM MV_PHOTO WHERE MOVIE_NO = " + selected_movie_no;
                Console.WriteLine(selected_movie_no);
                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();
                if (!reader.HasRows)
                {
                    Picture1.Visible = false;
                    Picture2.Visible = false;
                    Picture3.Visible = false;

                    label1.Text = "등록된 영화 사진이 없습니다.";
                }
                reader.Read();
                var poster = reader.GetString(reader.GetOrdinal("PHOTO_ROUTE"));

                Picture1.SizeMode = PictureBoxSizeMode.StretchImage;
                Picture1.ImageLocation = poster;

                reader.Read();
                poster = reader.GetString(reader.GetOrdinal("PHOTO_ROUTE"));

                Picture2.SizeMode = PictureBoxSizeMode.StretchImage;
                Picture2.ImageLocation = poster;

                reader.Read();
                poster = reader.GetString(reader.GetOrdinal("PHOTO_ROUTE"));

                Picture3.SizeMode = PictureBoxSizeMode.StretchImage;
                Picture3.ImageLocation = poster;

            }
            catch (Exception)
            {

            }
        }


        private void BackToHome_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            connect.con.Close();
        }
    }
}
