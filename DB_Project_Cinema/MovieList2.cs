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
    public partial class MovieList2 : UserControl
    {
        private static MovieList2 _instance;
        private Connection Connect;

        private Button[] btn = new Button[5];
        PictureBox[] pic = new PictureBox[5];
        Label[] label = new Label[5];
        public static MovieList2 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MovieList2();
                }
                return _instance;
            }
        }


        public MovieList2()
        {
            InitializeComponent();

            Connect = new Connection();
            Connect.Connecting();


            for (int i = 0; i < pic.Length; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Name = "Poster" + (i + 1).ToString();
                pic[i].Size = new Size(130, 185);
                pic[i].Location = new Point(90 + 180 * i, 30);

                btn[i] = new Button();
                btn[i].Name = "MovieDetail" + (i + 1).ToString();
                btn[i].Size = new Size(130, 25);
                btn[i].Location = new Point(90 + 180 * i, 225);
                btn[i].Click += Form1_Click;

                label[i] = new Label();
                label[i].Name = "ResvRate" + (i + 1).ToString();
                label[i].Size = new Size(130, 25);
                label[i].Location = new Point(90 + 180 * i, 255);

                try
                {
                    
                    string sql = "SELECT * FROM(SELECT ROWNUM RM, MOVIE_NO, MOVIE_NM, POSTER,RELEASE_DATE FROM MOVIE WHERE SHOW_STAT='E') Y WHERE Y.RM=" + (i + 1);
                    OracleCommand Comm = new OracleCommand(sql, Connect.con);

                    OracleDataReader reader = Comm.ExecuteReader();

                    while (reader.Read())
                    {
                        var poster = reader.GetString(reader.GetOrdinal("POSTER"));

                        pic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        pic[i].ImageLocation = poster;

                        btn[i].Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));

                        label[i].Text = "  개봉일: " + reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToString().Substring(0, 10);

                    }
                    Controls.Add(pic[i]);
                    Controls.Add(btn[i]);
                    Controls.Add(label[i]);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());

                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Controls.Remove(this);
            this.Parent.Controls.Add(MovieDetail1.Instance);
            MovieDetail1.Instance.setMovie_nm(btn.Text);
            MovieDetail1.Instance.MovieDetail_test();
            MovieDetail1.Instance.Dock = DockStyle.None;
            MovieDetail1.Instance.BringToFront();
        }
    }
}

