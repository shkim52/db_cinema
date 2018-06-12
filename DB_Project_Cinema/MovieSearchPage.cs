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
    public partial class MovieSearchPage : UserControl
    {
        private Connection connect;
        private string category;
        private string searchtext;
        private int[] movie_no_array;
        private MoviePage _parent;

        public MovieSearchPage(string movie_category, string search_text, MoviePage parent)
        {

            InitializeComponent();
            _parent = parent;
            connect = new Connection();
            connect.Connecting();

            searchtext = search_text;
            category = movie_category;

            movie_no_array = new int[200];
            Init_array(movie_no_array);

            if (category == "영화명")
            {
                Movie_Search();
            }
            else if (category == "감독명")
            {
                Director_Search();
            }
            else if (category == "장르명")
            {
                Genre_Search();
            }
        }

        private void Init_array(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }

        public void Movie_Search()
        {
            dataGridView1.Rows.Clear();

            try
            {

                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NM LIKE '%" + searchtext + "%'";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                int index = 0;

                while (reader.Read())
                {

                    var poster = reader.GetString(reader.GetOrdinal("POSTER"));
                    System.Net.WebClient webSource = new System.Net.WebClient();
                    byte[] data = webSource.DownloadData(poster);
                    System.IO.MemoryStream pipe = new System.IO.MemoryStream(data);
                    Image jpgImage = Image.FromStream(pipe);

                    string Movie_nm = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    string genre = reader.GetString(reader.GetOrdinal("GENRE"));
                    string director_nm = reader.GetString(reader.GetOrdinal("DIRECTOR_NM"));
                    string actor_nm = reader.GetString(reader.GetOrdinal("ACTOR_NM"));
                    string rating = reader.GetString(reader.GetOrdinal("RATING"));
                    string release_date = reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToShortDateString();
                    string movie_detail = "상세보기";
                    movie_no_array[index++] = Convert.ToInt32(reader["MOVIE_NO"]);

                    this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Rows.Add(jpgImage, Movie_nm, genre, director_nm, actor_nm, rating, release_date, movie_detail);
                }

            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }



        public void Director_Search()
        {
            dataGridView1.Rows.Clear();

            try
            {

                string sql = "SELECT * FROM MOVIE WHERE DIRECTOR_NM LIKE '%" + searchtext + "%'";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                int index = 0;
                while (reader.Read())
                {
                    var poster = reader.GetString(reader.GetOrdinal("POSTER"));
                    System.Net.WebClient webSource = new System.Net.WebClient();
                    byte[] data = webSource.DownloadData(poster);
                    System.IO.MemoryStream pipe = new System.IO.MemoryStream(data);
                    Image jpgImage = Image.FromStream(pipe);

                    string Movie_nm = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    string genre = reader.GetString(reader.GetOrdinal("GENRE"));
                    string director_nm = reader.GetString(reader.GetOrdinal("DIRECTOR_NM"));
                    string actor_nm = reader.GetString(reader.GetOrdinal("ACTOR_NM"));
                    string rating = reader.GetString(reader.GetOrdinal("RATING"));
                    string release_date = reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToShortDateString();
                    string movie_detail = "상세보기";
                    movie_no_array[index++] = Convert.ToInt32(reader["MOVIE_NO"]);

                    dataGridView1.Rows.Add(jpgImage, Movie_nm, genre, director_nm, actor_nm, rating, release_date, movie_detail);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void Genre_Search()
        {
            dataGridView1.Rows.Clear();

            try
            {

                string sql = "SELECT * FROM MOVIE WHERE GENRE LIKE '%" + searchtext + "%'";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                int index = 0;

                while (reader.Read())
                {
                    var poster = reader.GetString(reader.GetOrdinal("POSTER"));
                    System.Net.WebClient webSource = new System.Net.WebClient();
                    byte[] data = webSource.DownloadData(poster);
                    System.IO.MemoryStream pipe = new System.IO.MemoryStream(data);
                    Image jpgImage = Image.FromStream(pipe);
                    string Movie_nm = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    string genre = reader.GetString(reader.GetOrdinal("GENRE"));
                    string director_nm = reader.GetString(reader.GetOrdinal("DIRECTOR_NM"));
                    string actor_nm = reader.GetString(reader.GetOrdinal("ACTOR_NM"));
                    string rating = reader.GetString(reader.GetOrdinal("RATING"));
                    string release_date = reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToShortDateString();
                    string movie_detail = "상세보기";
                    movie_no_array[index++] = Convert.ToInt32(reader["MOVIE_NO"]);

                    dataGridView1.Rows.Add(jpgImage, Movie_nm, genre, director_nm, actor_nm, rating, release_date, movie_detail);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 7)
            {
                /*
                MovieDetail MD = new MovieDetail(movie_no_array[e.RowIndex]);
                this.Parent.Controls.Add(MD); // parent -> panel3
                MD.Dock = DockStyle.None;
                MD.BringToFront();*/
                //this.Parent.Controls.Remove(this);
                //this.Controls.Remove(this);
                _parent.Movie_Detail(movie_no_array[e.RowIndex]);
            }

        }
    }




}
