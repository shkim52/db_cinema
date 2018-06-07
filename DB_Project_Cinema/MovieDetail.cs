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
    public partial class MovieDetail : UserControl
    {
        //private static MovieDetail _instance;
        private Connection connect;
        private CinemaProgram _parents; // 사용하지 않는 변수
        private string movie_nm; 
        public string mem_id = null;
        private int selected_movie_no;

        //MoviePage m = new MoviePage();
        /*public static MovieDetail Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MovieDetail();
                }
                return _instance;
            }
        }*/
        public MovieDetail(int selected_movie)
        {
            mem_id = CinemaProgram.Instance.GetLoginId();
            selected_movie_no = selected_movie;
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();

            MovieDetail_View();
        }
        private void MovieDetail1_Load(object sender, EventArgs e)
        {
            MovieDetail_View();
        }
        // 얘들은 왜 필요할까?
        public void SetMovie_nm(string s){
            movie_nm = s;
        }
        public void SetMovie_no(int i)
        {
            //movie_no = i;
        }

       
        public void MovieDetail_View()
        {
            ReviewButton_Visible();

            try
            {
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NO=" + selected_movie_no;

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                reader.Read();

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

               string sql2 = "SELECT AVG(MOVIE_SCORE) FROM GRADE WHERE MOVIE_NO=" + selected_movie_no;

                OracleCommand Comm2 = new OracleCommand(sql2, connect.con);
                OracleDataReader reader2 = Comm2.ExecuteReader();

                if (reader2.HasRows)
                {
                    reader2.Read();
                    MovieScore.Text = reader2.GetInt32(reader2.GetOrdinal("AVG(MOVIE_SCORE)")).ToString() + "점";

                }
                else if (!reader2.HasRows)
                {
                    MovieScore.Text = "-점";
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }
        private void ReviewButton_Visible()
        {
            string sql = "SELECT SHOW_STAT FROM MOVIE WHERE MOVIE_NO = " + selected_movie_no + " AND SHOW_STAT = 'E'";

            OracleCommand Comm = new OracleCommand(sql, connect.con);
            OracleDataReader reader = Comm.ExecuteReader();

            if (reader.HasRows)
            {
                ReviewButton.Visible = false;
            }
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand Cmd = new OracleCommand();
                Cmd.Connection = connect.con;
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NO = " + selected_movie_no;

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();
                
                reader.Read();

                this.Parent.Controls.Add(ReviewPage.Instance);// panel3
                Controls.Remove(this);
                ReviewPage.Instance.setMovie_no(selected_movie_no);
                ReviewPage.Instance.ReviewPage_test();
                ReviewPage.Instance.Dock = DockStyle.None;
                ReviewPage.Instance.BringToFront();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void InterestRegisterButton_Click(object sender, EventArgs e)
        {
          
            if (mem_id == null)
            {
                MessageBox.Show("로그인을 하세요!");
            }
            else
            {
                try
                {
                    OracleCommand Cmd = new OracleCommand();
                    Cmd.Connection = connect.con;
                    string sql = "SELECT * FROM MOVIE WHERE MOVIE_NO = " + selected_movie_no;

                    OracleCommand Comm = new OracleCommand(sql, connect.con);
                    OracleDataReader reader = Comm.ExecuteReader();

                    reader.Read();

                    this.MovieNM.Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));

                    string sql2 = "INSERT INTO INTEREST_LIST (MEM_ID, MOVIE_NO) VALUES('" + mem_id + "'," + selected_movie_no + ")";

                    Cmd.CommandText = sql2;
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("관심리스트에 등록되었습니다!");
                        
                      
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        
    }
}
