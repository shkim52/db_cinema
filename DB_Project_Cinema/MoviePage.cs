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
        private string searchType;
        private Connection Connect;
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
            /**OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;*/

        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {

            PlayingMovie.Visible = false;
            ExpectedMovie.Visible = false;

            if (SearchText.Text == "")
                MessageBox.Show("검색어를 입력하세요!");
            else
            {
                
                try
                {
                    // Find the string in ListBox2.
                    if (MovieCategory.Text != string.Empty)
                    {
                        searchType = MovieCategory.Text;
                    }
                    Console.WriteLine("SEARCH TYPE === ");
                    Console.WriteLine(searchType);
                    if (searchType == "영화명")
                    {
                        string sql1 = "SELECT * FROM MOVIE WHERE MOVIE_NM LIKE '%" + SearchText.Text + "%'" ;
                       
                        OracleCommand Comm1 = new OracleCommand(sql1, Connect.con);
                        OracleDataReader reader1 = Comm1.ExecuteReader();
                        if (reader1.HasRows)
                        {
                            Controls.Add(MovieSearchPage.Instance);
                            MovieSearchPage.Instance.setMovie_nm(SearchText.Text);
                            MovieSearchPage.Instance.MovieDetail_test();
                            MovieSearchPage.Instance.Dock = DockStyle.Fill;
                            MovieSearchPage.Instance.BringToFront();

                        }
                        else if (!reader1.HasRows)
                        {
                            MessageBox.Show("해당 영화명과 일치하는 영화가 없습니다!");
                        }
                    }
                    else if (searchType == "감독명")
                    {
                        string sql2 = "SELECT * FROM MOVIE WHERE DIRECTOR_NM LIKE '%" + SearchText.Text + "%'";

                        OracleCommand Comm2 = new OracleCommand(sql2, Connect.con);
                        OracleDataReader reader2 = Comm2.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            Controls.Add(MovieSearchPage.Instance);
                            MovieSearchPage.Instance.setDirector_nm(SearchText.Text);
                            MovieSearchPage.Instance.DirectorDetail_test();
                            MovieSearchPage.Instance.Dock = DockStyle.Fill;
                            MovieSearchPage.Instance.BringToFront();
                        }
                        else if (!reader2.HasRows)
                        {
                            MessageBox.Show("해당 감독명과 일치하는 영화가 없습니다!");
                        }
                    }
                    else if (searchType == "장르명")
                    {
                        string sql3 = "SELECT * FROM MOVIE WHERE GENRE LIKE '%" + SearchText.Text + "%'";

                        OracleCommand Comm3 = new OracleCommand(sql3, Connect.con);
                        OracleDataReader reader3 = Comm3.ExecuteReader();
                        if (reader3.HasRows)
                        {
                            Controls.Add(MovieSearchPage.Instance);
                            MovieSearchPage.Instance.setGenre_nm(SearchText.Text);
                            MovieSearchPage.Instance.GenreDetail_test();
                            MovieSearchPage.Instance.Dock = DockStyle.Fill;
                            MovieSearchPage.Instance.BringToFront();
                        }
                        else if (!reader3.HasRows)
                        {
                            MessageBox.Show("해당 장르명과 일치하는 영화가 없습니다!");
                        }
                        
                    }
                    Connect.con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    Connect.con.Close();
                }
            }

        }

        private void PlayingMovie_Click(object sender, EventArgs e)
        {
            //MoviePage_Load(sender, e);

            panel3.Controls.Add(MovieList.Instance);
           // panel3.Controls.Add(MovieList.Instance);
            //MovieDetail1.Instance.setMovie_nm(btn.Text);
            // MovieDetail1.Instance.MovieDetail_test();
            MovieList.Instance.Dock = DockStyle.None;
            MovieList.Instance.BringToFront();

            PlayingMovie.FlatAppearance.BorderColor = Color.Red;
            PlayingMovie.FlatAppearance.BorderSize = 1;
            ExpectedMovie.FlatAppearance.BorderSize = 0;
            
        }

        private void ExpectedMovie_Click(object sender, EventArgs e)
        {
            MoviePage_Load(sender, e);
            
            panel3.Controls.Add(MovieList2.Instance);
            //MovieDetail1.Instance.setMovie_nm(btn.Text);
            // MovieDetail1.Instance.MovieDetail_test();
            MovieList2.Instance.Dock = DockStyle.None;
            MovieList2.Instance.BringToFront();

            ExpectedMovie.FlatAppearance.BorderColor = Color.Red;
            ExpectedMovie.FlatAppearance.BorderSize = 1;
            PlayingMovie.FlatAppearance.BorderSize = 0;
        }

        private void MoviePage_Load(object sender, EventArgs e)
        {
            panel3.Controls.Add(MovieList.Instance);
            //MovieDetail1.Instance.setMovie_nm(btn.Text);
            // MovieDetail1.Instance.MovieDetail_test();
            MovieList.Instance.Dock = DockStyle.None;
            MovieList.Instance.BringToFront();

            PlayingMovie.FlatAppearance.BorderColor = Color.Red;
            PlayingMovie.FlatAppearance.BorderSize = 1;
            ExpectedMovie.FlatAppearance.BorderSize = 0;
            searchType = "영화명";
        }

       
    }
}
   

