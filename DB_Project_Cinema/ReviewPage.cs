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
    public partial class ReviewPage : UserControl
    {
        private static ReviewPage _instance;
        private int movie_no;
        public OracleConnection Conn;
        public static ReviewPage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReviewPage();
                }
                return _instance;
            }
        }
        public void setMovie_no(int i)
        {
            movie_no = i;
        }

        public ReviewPage()
        {
            InitializeComponent();

            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            Conn = new OracleConnection(str);
            /**OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;*/
        }

        public void ReviewPage_test()
        {
            try
            {
                Conn.Open();
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NO = '" + movie_no + "'";

                OracleCommand Comm = new OracleCommand(sql, Conn);
                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    this.MovieNM.Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    

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

        private void ReviewRegisterButton_Click(object sender, EventArgs e)
        {
            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);
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
                    string sql = "SELECT * FROM MOVIE WHERE MOVIE_NO = '" + movie_no + "'";
                    //string sql2 = "SELECT * FROM GRADE WHERE MOVIE_NM = '" + movie_nm + "'";
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


                    while (reader.Read())
                    {
                        this.MovieNM.Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                        //int movie_no = reader.GetInt32(reader.GetOrdinal("MOVIE_NO"));

                        string sql3 = "INSERT INTO GRADE (MEM_ID, MOVIE_NO, MOVIE_SCORE, REVIEW) VALUES('" + Program.memID + "'," + movie_no + MovieScore.SelectedItem + Review.Text + "')";

                        Cmd.CommandText = sql3;
                        Cmd.ExecuteNonQuery();
                        MessageBox.Show("리뷰가 등록되었습니다!");
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
