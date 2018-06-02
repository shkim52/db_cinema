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
    public partial class MoviePage : UserControl
    {
        private static MoviePage _instance;
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

            MovieList.BringToFront();

            PlayingMovie.FlatAppearance.BorderColor = Color.Red;
            PlayingMovie.FlatAppearance.BorderSize = 1;
            ExpectedMovie.FlatAppearance.BorderSize = 0;
        }      

        private void SearchButton_Click_1(object sender, EventArgs e)
        {

            PlayingMovie.Visible = false;
            ExpectedMovie.Visible = false;


            if (SearchText.Text == "")
                MessageBox.Show("검색어를 입력하세요!");
            else
            {
                string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
                OracleConnection Conn = new OracleConnection(str);
                /**OracleCommand Comm;
                Comm = new OracleCommand();
                Comm.Connection = Conn;*/
                try
                {
                    Conn.Open();

                    if (MovieCategory.SelectedItem.ToString() == "영화명")
                    {
                        string sql2 = "SELECT * FROM MOVIE WHERE MOVIE_NM = '" + SearchText.Text + "'";

                        OracleCommand Comm = new OracleCommand(sql2, Conn);
                        OracleDataReader reader2 = Comm.ExecuteReader();
                        if (reader2.HasRows)
                        {                         
                            MovieSearchPage.BringToFront();

                            while (reader2.Read())
                            {

                            }

                        }
                        else if (!reader2.HasRows)
                        {
                            MessageBox.Show("해당 영화명과 일치하는 영화가 없습니다!");
                        }
                    }
                    else if (MovieCategory.SelectedItem.ToString() == "감독명")
                    {
                        string sql2 = "SELECT * FROM MOVIE WHERE DIRECTOR_NM = '" + SearchText.Text + "'";

                        OracleCommand Comm = new OracleCommand(sql2, Conn);
                        OracleDataReader reader2 = Comm.ExecuteReader();
                        if (reader2.HasRows)
                        {
                            

                            MovieSearchPage.BringToFront();

                            while (reader2.Read())
                            {

                            }
                        }
                        else if (!reader2.HasRows)
                        {
                            MessageBox.Show("해당 감독명과 일치하는 영화가 없습니다!");
                        }
                    }
                    else if (MovieCategory.SelectedItem.ToString() == "장르명")
                    {
                        string sql2 = "SELECT * FROM MOVIE WHERE GENRE = '" + SearchText.Text + "'";

                        OracleCommand Comm = new OracleCommand(sql2, Conn);
                        OracleDataReader reader2 = Comm.ExecuteReader();
                        if (reader2.HasRows)
                        {
                           
                            MovieSearchPage.BringToFront();

                            while (reader2.Read())
                            {

                            }

                        }
                        else if (!reader2.HasRows)
                        {
                            MessageBox.Show("해당 장르명과 일치하는 영화가 없습니다!");
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

        private void PlayingMovie_Click(object sender, EventArgs e)
        {
            MovieList.BringToFront();

            PlayingMovie.FlatAppearance.BorderColor = Color.Red;
            PlayingMovie.FlatAppearance.BorderSize = 1;
            ExpectedMovie.FlatAppearance.BorderSize = 0;
            
        }

        private void ExpectedMovie_Click(object sender, EventArgs e)
        {
            MovieList2.BringToFront();

            ExpectedMovie.FlatAppearance.BorderColor = Color.Red;
            ExpectedMovie.FlatAppearance.BorderSize = 1;
            PlayingMovie.FlatAppearance.BorderSize = 0;
        }

       
    }
}
   

