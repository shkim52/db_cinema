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
        public MovieSearchPage()
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
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NO = 3";

                OracleCommand Comm = new OracleCommand(sql, Conn);


                OracleDataReader reader = Comm.ExecuteReader();


                while (reader.Read())
                {
                    string a = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    //this.Genre.Text = reader.GetString(reader.GetOrdinal("GENRE"));
                    //this.ReleaseDate.Text = reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToShortDateString();
                    //this.ShowTime.Text = reader.GetString(reader.GetOrdinal("SHOW_TIME"));
                    string c = reader.GetString(reader.GetOrdinal("RATING"));
                    string b = reader.GetString(reader.GetOrdinal("DIRECTOR_NM"));
                    // this.ActorNM.Text = reader.GetString(reader.GetOrdinal("ACTOR_NM"));
                    //this.Country.Text = reader.GetString(reader.GetOrdinal("COUNTRY"));
                    //this.Distributor.Text = reader.GetString(reader.GetOrdinal("DISTRIBUTOR"));
                    //this.MovieIntro.Text = reader.GetString(reader.GetOrdinal("MOVIE_INTRO"));
                    //var poster = reader.GetString(reader.GetOrdinal("POSTER"));

                    //Poster.SizeMode = PictureBoxSizeMode.StretchImage;
                    //Poster.ImageLocation = poster;

                    string[] row0 = { a,b,c };

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
    }
}
