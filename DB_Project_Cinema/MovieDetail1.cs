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
    public partial class MovieDetail1 : UserControl
    {
        private static MovieDetail1 _instance;
        private int movie_no;
        public OracleConnection Conn;
        public static MovieDetail1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MovieDetail1();
                }
                return _instance;
            }
        }
        public void setMovie_no(int n){
            Console.WriteLine(n);
            movie_no = n;
        }
        public MovieDetail1()
        {
            InitializeComponent();

            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            Conn = new OracleConnection(str);
            /**OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;*/
           /* try
            {

                Conn.Open();
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NO="+movie_no;
                Console.WriteLine(sql);
                OracleCommand Comm = new OracleCommand(sql, Conn);


                OracleDataReader reader = Comm.ExecuteReader();


                while (reader.Read())
                {
                    this.MovieNM.Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    this.Genre.Text = reader.GetString(reader.GetOrdinal("GENRE"));
                    //this.ReleaseDate.Text = reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToShortDateString();
                    this.ShowTime.Text = reader.GetString(reader.GetOrdinal("SHOW_TIME"));
                    this.Rating.Text = reader.GetString(reader.GetOrdinal("RATING"));
                    this.DirectorNM.Text = reader.GetString(reader.GetOrdinal("DIRECTOR_NM"));
                    this.ActorNM.Text = reader.GetString(reader.GetOrdinal("ACTOR_NM"));
                    this.Country.Text = reader.GetString(reader.GetOrdinal("COUNTRY"));
                    this.Distributor.Text = reader.GetString(reader.GetOrdinal("DISTRIBUTOR"));
                    this.MovieIntro.Text = reader.GetString(reader.GetOrdinal("MOVIE_INTRO"));
                    var poster = reader.GetString(reader.GetOrdinal("POSTER"));

                    Poster.SizeMode = PictureBoxSizeMode.StretchImage;
                    Poster.ImageLocation = poster;
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
            }*/
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        public void MovieDetail_test()
        {
            try
            {

                Conn.Open();
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NO=" + movie_no;
                Console.WriteLine(sql);
                OracleCommand Comm = new OracleCommand(sql, Conn);


                OracleDataReader reader = Comm.ExecuteReader();


                while (reader.Read())
                {
                    this.MovieNM.Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    this.Genre.Text = reader.GetString(reader.GetOrdinal("GENRE"));
                    //this.ReleaseDate.Text = reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToShortDateString();
                    this.ShowTime.Text = reader.GetString(reader.GetOrdinal("SHOW_TIME"));
                    this.Rating.Text = reader.GetString(reader.GetOrdinal("RATING"));
                    this.DirectorNM.Text = reader.GetString(reader.GetOrdinal("DIRECTOR_NM"));
                    this.ActorNM.Text = reader.GetString(reader.GetOrdinal("ACTOR_NM"));
                    this.Country.Text = reader.GetString(reader.GetOrdinal("COUNTRY"));
                    this.Distributor.Text = reader.GetString(reader.GetOrdinal("DISTRIBUTOR"));
                    this.MovieIntro.Text = reader.GetString(reader.GetOrdinal("MOVIE_INTRO"));
                    var poster = reader.GetString(reader.GetOrdinal("POSTER"));

                    Poster.SizeMode = PictureBoxSizeMode.StretchImage;
                    Poster.ImageLocation = poster;
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
