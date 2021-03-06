﻿using System;
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
        private Connection connect;
        private int selected_movie_no;
        private CinemaProgram _parent;

        public MovieDetail(int selected_movie)
        {
            selected_movie_no = selected_movie;
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();
        }
        private void MovieDetail1_Load(object sender, EventArgs e)
        {
            MovieDetail_View();
        }

        public void SetParent(CinemaProgram parent)
        {
            _parent = parent;
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
                    MovieScore.Text = reader2.GetFloat(reader2.GetOrdinal("AVG(MOVIE_SCORE)")).ToString("N1") + "점";

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

                ReviewPage RV = new ReviewPage(selected_movie_no);
                this.Parent.Controls.Add(RV); // parent -> panel3
                RV.Dock = DockStyle.Fill;
                RV.BringToFront();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void InterestRegisterButton_Click(object sender, EventArgs e)
        {

            if (_parent.GetLoginId() == String.Empty)
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
                    sql = "SELECT  * FROM INTEREST_LIST WHERE MEM_ID = '" + _parent.GetLoginId() + "' AND MOVIE_NO = " + selected_movie_no;
                    Comm = new OracleCommand(sql, connect.con);
                    reader = Comm.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("이미 관심리스트에 등록되었습니다.");
                    } 
                    else
                    {
                        reader.Read();
                        string sql2 = "INSERT INTO INTEREST_LIST (MEM_ID, MOVIE_NO) VALUES('" + _parent.GetLoginId() + "'," + selected_movie_no + ")";
                        Console.WriteLine(sql2);

                        Cmd.CommandText = sql2;
                        Cmd.ExecuteNonQuery();

                        MessageBox.Show("관심리스트에 등록되었습니다!");                        
                      
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        private void BookButton_Click(object sender, EventArgs e)
        {
            _parent.Join_Cust();
        }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void MoviePictureBut_Click(object sender, EventArgs e)
        {

            MoviePicture mp = new MoviePicture(selected_movie_no);
            this.Parent.Controls.Add(mp); // parent -> panel3
            mp.Dock = DockStyle.Fill;
            mp.BringToFront();

        }


        
    }
}
