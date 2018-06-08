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
        private Connection Connect;
        private MovieList Expect_ML;
        private MovieList Show_ML;
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
            Connect = new Connection();
            Connect.Connecting();

            // 인자값으로 현재 상영중인지 여부를 나타낸다
            Show_ML = new MovieList(true);
            Expect_ML = new MovieList(false);

            MovieCategory.Text = "영화명";
        }

        private void MoviePage_Load(object sender, EventArgs e)
        {
            // 상영중인 영화가 가장 먼저 보이도록
            panel3.Controls.Add(Show_ML);
            Show_ML.Dock = DockStyle.None;
            Show_ML.BringToFront();

            PlayingMovie.FlatAppearance.BorderColor = Color.Red;
            PlayingMovie.FlatAppearance.BorderSize = 1;
            ExpectedMovie.FlatAppearance.BorderSize = 0;
        }

        private void PlayingMovie_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Show_ML))
            {
                panel3.Controls.Add(Show_ML);
                Show_ML.Dock = DockStyle.None;
                Show_ML.BringToFront();
            }
            else
            {
                Show_ML.BringToFront();
            }

            PlayingMovie.FlatAppearance.BorderColor = Color.Red;
            PlayingMovie.FlatAppearance.BorderSize = 1;
            ExpectedMovie.FlatAppearance.BorderSize = 0;
            
        }

        private void ExpectedMovie_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(Expect_ML))
            {
                panel3.Controls.Add(Expect_ML);
                Expect_ML.Dock = DockStyle.None;
                Expect_ML.BringToFront();
            }
            else
            {
                Expect_ML.BringToFront();
            }

            ExpectedMovie.FlatAppearance.BorderColor = Color.Red;
            ExpectedMovie.FlatAppearance.BorderSize = 1;
            PlayingMovie.FlatAppearance.BorderSize = 0;
        }  

        private void SearchButton_Click(object sender, EventArgs e)
        {
            PlayingMovie.Visible = false;
            ExpectedMovie.Visible = false;

            if (SearchText.Text == "")
                MessageBox.Show("검색어를 입력하세요!");
            else
            {
                try
                {
                    if (MovieCategory.Text == "영화명")
                    {
                        string sql = "SELECT * FROM MOVIE WHERE MOVIE_NM LIKE '%" + SearchText.Text + "%'";
                        OracleCommand Comm1 = new OracleCommand(sql, Connect.con);
                        OracleDataReader reader = Comm1.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MovieSearchPage MS = new MovieSearchPage(MovieCategory.Text, SearchText.Text);
                            panel3.Controls.Add(MS);
                            MS.Dock = DockStyle.None;
                            MS.BringToFront();

                        }
                        else if (!reader.HasRows)
                        {
                            MessageBox.Show("해당" + MovieCategory.Text + " 영화명과 일치하는 영화가 없습니다!");
                        }
                    }
                    else if(MovieCategory.Text == "감독명")
                    {
                        string sql = "SELECT * FROM MOVIE WHERE DIRECTOR_NM LIKE '%" + SearchText.Text + "%'";
                        OracleCommand Comm1 = new OracleCommand(sql, Connect.con);
                        OracleDataReader reader = Comm1.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MovieSearchPage MS = new MovieSearchPage(MovieCategory.Text, SearchText.Text);
                            panel3.Controls.Add(MS);
                            MS.Dock = DockStyle.None;
                            MS.BringToFront();

                        }
                        else if (!reader.HasRows)
                        {
                            MessageBox.Show("해당" + MovieCategory.Text + " 영화명과 일치하는 영화가 없습니다!");
                        }
                    }
                    else if (MovieCategory.Text == "장르명")
                    {
                        string sql = "SELECT * FROM MOVIE WHERE GENRE LIKE '%" + SearchText.Text + "%'";
                        OracleCommand Comm1 = new OracleCommand(sql, Connect.con);
                        OracleDataReader reader = Comm1.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MovieSearchPage MS = new MovieSearchPage(MovieCategory.Text, SearchText.Text);
                            panel3.Controls.Add(MS);
                            MS.Dock = DockStyle.None;
                            MS.BringToFront();

                        }
                        else if (!reader.HasRows)
                        {
                            MessageBox.Show("해당" + MovieCategory.Text + " 영화명과 일치하는 영화가 없습니다!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
   

