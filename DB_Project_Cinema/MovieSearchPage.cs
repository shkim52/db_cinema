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
        private string movie_nm;
        private string Director_nm;
        private string Genre_nm;
        public OracleConnection Conn;
        public static MovieSearchPage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MovieSearchPage();
                }
                return _instance;
            }
        }
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
        public MovieSearchPage()
        {
            InitializeComponent();

            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            Conn = new OracleConnection(str);
            /**OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;*/
        }

        public void MovieDetail_test()
        {
            dataGridView1.Rows.Clear();

            try
            {
                Conn.Open();
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NM LIKE '%" + movie_nm + "%'";

                OracleCommand Comm = new OracleCommand(sql, Conn);
                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {                   
                    string Movie_nm = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    string genre = reader.GetString(reader.GetOrdinal("GENRE"));
                    string director_nm = reader.GetString(reader.GetOrdinal("DIRECTOR_NM"));
                    string actor_nm = reader.GetString(reader.GetOrdinal("ACTOR_NM"));
                    string rating = reader.GetString(reader.GetOrdinal("RATING"));
                    string release_date = reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToShortDateString();
                    string show_time = reader.GetString(reader.GetOrdinal("SHOW_TIME"));
                    string country = reader.GetString(reader.GetOrdinal("COUNTRY"));

                    string[] row0 = { Movie_nm, genre, director_nm, actor_nm, rating, release_date, show_time, country };

                    dataGridView1.Rows.Add(row0);
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

        public void DirectorDetail_test()
        {
            dataGridView1.Rows.Clear();

            try
            {
                Conn.Open();
                string sql = "SELECT * FROM MOVIE WHERE DIRECTOR_NM LIKE '%" + Director_nm + "%'";

                OracleCommand Comm = new OracleCommand(sql, Conn);
                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    string Movie_nm = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    string genre = reader.GetString(reader.GetOrdinal("GENRE"));
                    string director_nm = reader.GetString(reader.GetOrdinal("DIRECTOR_NM"));
                    string actor_nm = reader.GetString(reader.GetOrdinal("ACTOR_NM"));
                    string rating = reader.GetString(reader.GetOrdinal("RATING"));
                    string release_date = reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToShortDateString();
                    string show_time = reader.GetString(reader.GetOrdinal("SHOW_TIME"));
                    string country = reader.GetString(reader.GetOrdinal("COUNTRY"));

                    string[] row0 = { Movie_nm, genre, director_nm, actor_nm, rating, release_date, show_time, country };

                    dataGridView1.Rows.Add(row0);
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

        public void GenreDetail_test()
        {
            dataGridView1.Rows.Clear();

            try
            {
                Conn.Open();
                string sql = "SELECT * FROM MOVIE WHERE GENRE LIKE '%" + Genre_nm + "%'";

                OracleCommand Comm = new OracleCommand(sql, Conn);
                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    string Movie_nm = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    string genre = reader.GetString(reader.GetOrdinal("GENRE"));
                    string director_nm = reader.GetString(reader.GetOrdinal("DIRECTOR_NM"));
                    string actor_nm = reader.GetString(reader.GetOrdinal("ACTOR_NM"));
                    string rating = reader.GetString(reader.GetOrdinal("RATING"));
                    string release_date = reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToShortDateString();
                    string show_time = reader.GetString(reader.GetOrdinal("SHOW_TIME"));
                    string country = reader.GetString(reader.GetOrdinal("COUNTRY"));

                    string[] row0 = { Movie_nm, genre, director_nm, actor_nm, rating, release_date, show_time, country };

                    dataGridView1.Rows.Add(row0);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
