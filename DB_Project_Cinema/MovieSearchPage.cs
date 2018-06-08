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
        private static MovieSearchPage _instance;
        private Connection connect;
        private string movie_nm;
        private string Director_nm;
        private string Genre_nm;
        //public OracleConnection Conn;
        private string category;
        private string searchtext;
        //public static MovieSearchPage Instance
        /*{
            get
            {
                if (_instance == null)
                {
                    _instance = new MovieSearchPage();
                }
                return _instance;
            }*/
        public void setMovie_nm(string s)
        {
            movie_nm = s;
        }
        public void setDirector_nm(string s)
        {
            Director_nm = s;
        }
        public void setGenre_nm(string s)
        {
            Genre_nm = s;
        }
        public MovieSearchPage(string movie_category, string search_text)
        {
           
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();
            searchtext = search_text;
            category = movie_category;

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

        public void Movie_Search()
        {
            dataGridView1.Rows.Clear();

            try
            {
                
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NM LIKE '%" + searchtext + "%'";
                
                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                    reader.Read();
                
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
                    //string show_time = reader.GetString(reader.GetOrdinal("SHOW_TIME"));
                    //string country = reader.GetString(reader.GetOrdinal("COUNTRY"));
                    string movie_detail = "상세보기";

                    this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Rows.Add(jpgImage, Movie_nm, genre, director_nm, actor_nm, rating, release_date, movie_detail);
                
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
                movie_nm = dataGridView1.Rows[e.RowIndex].Cells["MovieNM"].Value.ToString();

                //MovieDetail MD = new MovieDetail(movie_no_array[Convert.ToInt32(selected_button.Substring(11, 1)) - 1]);
                //this.Parent.Controls.Add(MD); // parent -> panel3
               // MD.Dock = DockStyle.None;
                //MD.BringToFront();
            }  

            }
        }

        
    

}
