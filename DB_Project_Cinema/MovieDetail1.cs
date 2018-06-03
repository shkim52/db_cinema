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
        private string movie_nm;
        //private int movie_no;
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
        public void setMovie_nm(string s){
            movie_nm = s;
        }
        public void setMovie_no(int i)
        {
            //movie_no = i;
        }
        public MovieDetail1()
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
            try
            {
                Conn.Open();
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NM='"+movie_nm+"'";

                OracleCommand Comm = new OracleCommand(sql, Conn);
                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    this.MovieNM.Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    this.Genre.Text = reader.GetString(reader.GetOrdinal("GENRE"));
                    this.ReleaseDate.Text= reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToString().Substring(0, 10);
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


        private void ReviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand Cmd = new OracleCommand();
                Cmd.Connection = Conn;
                Conn.Open();
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NM = '" + movie_nm + "'";

                OracleCommand Comm = new OracleCommand(sql, Conn);
                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    int movie_no = reader.GetInt32(reader.GetOrdinal("MOVIE_NO"));
                    
                    Controls.Add(ReviewPage.Instance);
                    ReviewPage.Instance.setMovie_no(movie_no);
                    ReviewPage.Instance.ReviewPage_test();
                    ReviewPage.Instance.Dock = DockStyle.None;
                    ReviewPage.Instance.BringToFront();

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

        private void InterestRegisterButton_Click(object sender, EventArgs e)
        {
          
            if (Program.memID == "")
            {
                MessageBox.Show("로그인을 하세요!");
            }
            else
            {
                try
                {
                    OracleCommand Cmd = new OracleCommand();
                    Cmd.Connection = Conn;
                    Conn.Open();
                    string sql = "SELECT * FROM MOVIE WHERE MOVIE_NM = '" + movie_nm + "'";

                    OracleCommand Comm = new OracleCommand(sql, Conn);
                    OracleDataReader reader = Comm.ExecuteReader();

                    while (reader.Read())
                    {
                        try
                        {
                            this.MovieNM.Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                            decimal movie_no = reader.GetDecimal(reader.GetOrdinal("MOVIE_NO"));

                            string sql2 = "INSERT INTO INTEREST_LIST (MEM_ID, MOVIE_NO) VALUES('" + Program.memID + "',"+movie_no+")";

                            Cmd.CommandText = sql2;
                            Cmd.ExecuteNonQuery();

                            MessageBox.Show("관심리스트에 등록되었습니다!");
                        
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("이미 등록된 영화입니다!");
                        }
                        


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
