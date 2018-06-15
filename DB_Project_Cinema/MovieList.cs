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
    public partial class MovieList : UserControl
    {
        private Connection Connect;
        private Button[] btn = new Button[5];
        private PictureBox[] pic = new PictureBox[5];
        private Label[] label = new Label[5];
        private Label[] score = new Label[5];
        private int[] movie_no_array = new int[5];
        private int[] resv_rate = new int[5];
        private int total_resv;
        
        private bool selected_show_stat;

        public MovieList(bool show_stat)
        {
            InitializeComponent();

            selected_show_stat = show_stat;

            Connect = new Connection();
            Connect.Connecting();

            Movie_View();

        }
        public void Movie_View()
        {

            for (int i = 0; i < pic.Length; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Name = "Poster" + (i + 1).ToString();
                pic[i].Size = new Size(130, 185);
                pic[i].Location = new Point(230 + 180 * i, 30);

                btn[i] = new Button();
                btn[i].Name = "MovieDetail" + (i + 1).ToString();
                btn[i].Size = new Size(130, 25);
                btn[i].Location = new Point(230 + 180 * i, 225);
                btn[i].Click += Movie_Click;

                label[i] = new Label();
                label[i].Name = "ResvRate" + (i + 1).ToString();
                label[i].Size = new Size(130, 20);
                label[i].Location = new Point(230 + 180 * i, 255);

                try
                {
                    string sql = "SELECT * FROM(SELECT ROWNUM RM, MOVIE_NO, MOVIE_NM, POSTER, RELEASE_DATE FROM MOVIE WHERE SHOW_STAT='{0}') Y WHERE Y.RM=" + (i + 1);
                    if (selected_show_stat)
                    {
                        sql = string.Format(sql, "Y");

                        OracleCommand Comm = new OracleCommand(sql, Connect.con);
                        OracleDataReader reader = Comm.ExecuteReader();

                        score[i] = new Label();
                        score[i].Name = "Score" + (i + 1).ToString();
                        score[i].Size = new Size(130, 25);
                        score[i].Location = new Point(230 + 180 * i, 275);

                        while (reader.Read())
                        {
                            var poster = reader.GetString(reader.GetOrdinal("POSTER"));
                            movie_no_array[i] = reader.GetInt32(reader.GetOrdinal("MOVIE_NO"));

                            pic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                            pic[i].ImageLocation = poster;

                            btn[i].Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));



                        }

                        string sql2 = "SELECT AVG(MOVIE_SCORE) FROM GRADE WHERE MOVIE_NO=" + movie_no_array[i] + " GROUP BY MOVIE_NO";

                        OracleCommand Comm2 = new OracleCommand(sql2, Connect.con);
                        OracleDataReader reader2 = Comm2.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            while (reader2.Read())
                            {
                                score[i].Text = "   평점: " + reader2.GetFloat(reader2.GetOrdinal("AVG(MOVIE_SCORE)")).ToString("N1") + "점";

                            }
                        }
                        else if (!reader2.HasRows)
                        {
                            score[i].Text = "   평점: -점";
                        }

                        string sql3 = "SELECT COUNT(*) FROM BOOKING";

                        OracleCommand Comm3 = new OracleCommand(sql3, Connect.con);
                        OracleDataReader reader3 = Comm3.ExecuteReader();

                        reader3.Read();

                        total_resv = reader3.GetInt32(reader3.GetOrdinal("COUNT(*)"));

                        string sql4 = "SELECT COUNT(*) FROM BOOKING WHERE MOVIE_NO="+movie_no_array[i]+" GROUP BY MOVIE_NO";

                        OracleCommand Comm4 = new OracleCommand(sql4, Connect.con);
                        OracleDataReader reader4 = Comm4.ExecuteReader();

                        if (reader4.HasRows)
                        {
                            while (reader4.Read())
                            {
                                label[i].Text = "   예매율: " + ((reader4.GetFloat(reader4.GetOrdinal("COUNT(*)"))/total_resv)*100).ToString("N1") + "%";

                            }
                        }
                        else if (!reader4.HasRows)
                        {
                            label[i].Text = "   예매율: -";
                        }

                        Controls.Add(pic[i]);
                        Controls.Add(btn[i]);
                        Controls.Add(label[i]);
                        Controls.Add(score[i]);
                    }
                    else
                    {
                        sql = string.Format(sql, "E");

                        Console.WriteLine(sql);
                        OracleCommand Comm = new OracleCommand(sql, Connect.con);

                        OracleDataReader reader = Comm.ExecuteReader();

                        while (reader.Read())
                        {
                            var poster = reader.GetString(reader.GetOrdinal("POSTER"));
                            movie_no_array[i] = reader.GetInt32(reader.GetOrdinal("MOVIE_NO"));
                            pic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                            pic[i].ImageLocation = poster;

                            btn[i].Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));

                            label[i].Text = "  개봉일: " + reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToString().Substring(0, 10);

                        }
                        Controls.Add(pic[i]);
                        Controls.Add(btn[i]);
                        Controls.Add(label[i]);
                    }                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());

                }
            }
        }

        private void Movie_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string selected_button = btn.Name;

            MoviePage.Instance.Movie_Detail(movie_no_array[Convert.ToInt32(selected_button.Substring(11, 1)) - 1]);
        }
    }
}

