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
    public partial class MoviePage : UserControl
    {
        private static MoviePage _instance;
        public static MoviePage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MoviePage();
                }
                return _instance;
            }
        }
        public MoviePage()
        {
            InitializeComponent();

            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);
            /**OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;*/
            try
            {

                Conn.Open();

                string sql1 = "SELECT * FROM MOVIE WHERE MOVIE_NO=1 ";
                OracleCommand Comm1 = new OracleCommand(sql1, Conn);

                OracleDataReader reader1 = Comm1.ExecuteReader();

                while (reader1.Read())
                {
                    this.Movie1DetailButton.Text = reader1.GetString(reader1.GetOrdinal("MOVIE_NM"));

                }

                string sql2 = "SELECT * FROM MOVIE WHERE MOVIE_NO=2 ";
                OracleCommand Comm2 = new OracleCommand(sql2, Conn);

                OracleDataReader reader2 = Comm2.ExecuteReader();

                while (reader2.Read())
                {
                    this.Movie2DetailButton.Text = reader2.GetString(reader2.GetOrdinal("MOVIE_NM"));
                }

                string sql3 = "SELECT * FROM MOVIE WHERE MOVIE_NO=3 ";
                OracleCommand Comm3 = new OracleCommand(sql3, Conn);

                OracleDataReader reader3 = Comm3.ExecuteReader();

                while (reader3.Read())
                {
                    this.Movie3DetailButton.Text = reader3.GetString(reader3.GetOrdinal("MOVIE_NM"));
                }

                string sql4 = "SELECT * FROM MOVIE WHERE MOVIE_NO=4 ";
                OracleCommand Comm4 = new OracleCommand(sql4, Conn);

                OracleDataReader reader4 = Comm4.ExecuteReader();

                while (reader4.Read())
                {
                    this.Movie4DetailButton.Text = reader4.GetString(reader4.GetOrdinal("MOVIE_NM"));
                }

                string sql5 = "SELECT * FROM MOVIE WHERE MOVIE_NO=5 ";
                OracleCommand Comm5 = new OracleCommand(sql5, Conn);

                OracleDataReader reader5 = Comm5.ExecuteReader();

                while (reader5.Read())
                {
                    this.Movie5DetailButton.Text = reader5.GetString(reader5.GetOrdinal("MOVIE_NM"));
                }


                Conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                Conn.Close();
            }


            MovieList.BringToFront();

            BackToHomeButton.Visible = false;
            ReviewButton.Visible = false;
        }



        private void Movie1DetailButton_Click_2(object sender, EventArgs e)
        {
            Controls.Add(MovieDetail1.Instance);
            MovieDetail1.Instance.setMovie_no(1);
            MovieDetail1.Instance.MovieDetail_test();
            MovieDetail1.Instance.Dock = DockStyle.Fill;
            MovieDetail1.Instance.BringToFront();

            Movie1DetailButton.Visible = false;
            Movie2DetailButton.Visible = false;
            Movie3DetailButton.Visible = false;
            Movie4DetailButton.Visible = false;
            Movie5DetailButton.Visible = false;

            BackToHomeButton.Visible = true;
            ReviewButton.Visible = true;               
        }

        private void Movie2DetailButton_Click_1(object sender, EventArgs e)
        {
            Controls.Add(MovieDetail1.Instance);
            MovieDetail1.Instance.setMovie_no(2);
            MovieDetail1.Instance.MovieDetail_test();
            MovieDetail1.Instance.Dock = DockStyle.Fill;
            MovieDetail1.Instance.BringToFront();

            Movie1DetailButton.Visible = false;
            Movie2DetailButton.Visible = false;
            Movie3DetailButton.Visible = false;
            Movie4DetailButton.Visible = false;
            Movie5DetailButton.Visible = false;

            BackToHomeButton.Visible = true;
            ReviewButton.Visible = true;
        }

        private void Movie3DetailButton_Click_1(object sender, EventArgs e)
        {
            Controls.Add(MovieDetail1.Instance);
            MovieDetail1.Instance.setMovie_no(3);
            MovieDetail1.Instance.MovieDetail_test();
            MovieDetail1.Instance.Dock = DockStyle.Fill;
            MovieDetail1.Instance.BringToFront();

            Movie1DetailButton.Visible = false;
            Movie2DetailButton.Visible = false;
            Movie3DetailButton.Visible = false;
            Movie4DetailButton.Visible = false;
            Movie5DetailButton.Visible = false;

            BackToHomeButton.Visible = true;
            ReviewButton.Visible = true;
        }

        private void Movie4DetailButton_Click_1(object sender, EventArgs e)
        {
            Controls.Add(MovieDetail1.Instance);
            MovieDetail1.Instance.setMovie_no(4);
            MovieDetail1.Instance.MovieDetail_test();
            MovieDetail1.Instance.Dock = DockStyle.Fill;
            MovieDetail1.Instance.BringToFront();

            Movie1DetailButton.Visible = false;
            Movie2DetailButton.Visible = false;
            Movie3DetailButton.Visible = false;
            Movie4DetailButton.Visible = false;
            Movie5DetailButton.Visible = false;

            BackToHomeButton.Visible = true;
            ReviewButton.Visible = true;


        }

        private void Movie5DetailButton_Click_1(object sender, EventArgs e)
        {
            Controls.Add(MovieDetail1.Instance);
            MovieDetail1.Instance.setMovie_no(5);
            MovieDetail1.Instance.MovieDetail_test();
            MovieDetail1.Instance.Dock = DockStyle.Fill;
            MovieDetail1.Instance.BringToFront();

            Movie1DetailButton.Visible = false;
            Movie2DetailButton.Visible = false;
            Movie3DetailButton.Visible = false;
            Movie4DetailButton.Visible = false;
            Movie5DetailButton.Visible = false;

            BackToHomeButton.Visible = true;
            ReviewButton.Visible = true;
        }

        private void BackToHomeButton_Click_2(object sender, EventArgs e)
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

        private void ReviewButton_Click_2(object sender, EventArgs e)
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

        private void SearchButton_Click_1(object sender, EventArgs e)
        {

            if (SearchText.Text == "")
                MessageBox.Show("검색어를 입력하세요!");
            else
            {

                string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
                OracleConnection Conn = new OracleConnection(str);
                /**OracleCommand Comm;
                Comm = new OracleCommand();
                Comm.Connection = Conn;*/
                try
                {

                    Conn.Open();


                    if (MovieCategory.SelectedItem.ToString() == "영화명")
                    {
                        string sql2 = "SELECT * FROM MOVIE WHERE MOVIE_NM = '" + SearchText.Text + "'";

                        OracleCommand Comm = new OracleCommand(sql2, Conn);
                        OracleDataReader reader2 = Comm.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            Movie1DetailButton.Visible = false;
                            Movie2DetailButton.Visible = false;
                            Movie3DetailButton.Visible = false;
                            Movie4DetailButton.Visible = false;
                            Movie5DetailButton.Visible = false;

                            BackToHomeButton.Visible = true;
                            ReviewButton.Visible = false;

                            MovieSearchPage.BringToFront();

                            while (reader2.Read())
                            {
                                //Program.MovieNM = SearchText.Text;

                            }

                        }
                        else if (!reader2.HasRows)
                        {
                            MessageBox.Show("해당 영화명과 일치하는 영화가 없습니다!");
                        }
                        /* while (reader2.Read())
                         {
                             Program.MovieNM = SearchText.Text;
                         }
                         */
                    }
                    else if (MovieCategory.SelectedItem.ToString() == "감독명")
                    {
                        string sql2 = "SELECT * FROM MOVIE WHERE DIRECTOR_NM = '" + SearchText.Text + "'";

                        OracleCommand Comm = new OracleCommand(sql2, Conn);
                        OracleDataReader reader2 = Comm.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            Movie1DetailButton.Visible = false;
                            Movie2DetailButton.Visible = false;
                            Movie3DetailButton.Visible = false;
                            Movie4DetailButton.Visible = false;
                            Movie5DetailButton.Visible = false;

                            BackToHomeButton.Visible = true;
                            ReviewButton.Visible = false;

                            MovieSearchPage.BringToFront();

                            while (reader2.Read())
                            {
                                //Program.MovieNM = SearchText.Text;

                            }

                        }
                        else if (!reader2.HasRows)
                        {
                            MessageBox.Show("해당 감독명과 일치하는 영화가 없습니다!");
                        }
                        /* while (reader2.Read())
                         {
                             Program.MovieNM = SearchText.Text;
                         }
                         */
                    }
                    else if (MovieCategory.SelectedItem.ToString() == "장르명")
                    {
                        string sql2 = "SELECT * FROM MOVIE WHERE GENRE = '" + MovieDetail.Text + "'";

                        OracleCommand Comm = new OracleCommand(sql2, Conn);
                        OracleDataReader reader2 = Comm.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            Movie1DetailButton.Visible = false;
                            Movie2DetailButton.Visible = false;
                            Movie3DetailButton.Visible = false;
                            Movie4DetailButton.Visible = false;
                            Movie5DetailButton.Visible = false;

                            BackToHomeButton.Visible = true;
                            ReviewButton.Visible = false;

                            MovieSearchPage.BringToFront();

                            while (reader2.Read())
                            {
                                //Program.MovieNM = SearchText.Text;

                            }

                        }
                        else if (!reader2.HasRows)
                        {
                            MessageBox.Show("해당 장르명과 일치하는 영화가 없습니다!");
                        }
                        /* while (reader2.Read())
                         {
                             Program.MovieNM = SearchText.Text;
                         }
                         */
                    }
                    Conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    Conn.Close();
                }
            }




        }


    }
}
