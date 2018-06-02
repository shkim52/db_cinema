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
    public partial class MovieList2 : UserControl
    {
        Button[] btn = new Button[5];
        PictureBox[] pic = new PictureBox[5];

        public MovieList2()
        {
            InitializeComponent();

            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);
            /**OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;*/


            for (int i = 0; i < pic.Length; i++)
            {
                pic[i] = new PictureBox();
                pic[i].Name = "Poster" + (i + 1).ToString();
                pic[i].Size = new Size(130, 185);
                pic[i].Location = new Point(90 + 180 * i, 30);

                btn[i] = new Button();
                btn[i].Name = "MovieDetail" + (i + 1).ToString();
                btn[i].Size = new Size(130, 25);
                btn[i].Location = new Point(90 + 180 * i, 225);
                btn[i].Click += Form1_Click;
                try
                {
                    Conn.Open();

                    string sql = "SELECT * FROM MOVIE WHERE MOVIE_NO=" + (i + 1);
                    OracleCommand Comm = new OracleCommand(sql, Conn);

                    OracleDataReader reader = Comm.ExecuteReader();

                    while (reader.Read())
                    {
                        var poster = reader.GetString(reader.GetOrdinal("POSTER"));

                        pic[i].SizeMode = PictureBoxSizeMode.StretchImage;
                        pic[i].ImageLocation = poster;

                        btn[i].Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));

                    }
                    Controls.Add(pic[i]);
                    Controls.Add(btn[i]);


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

        private void Form1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            Controls.Add(MovieDetail1.Instance);
            MovieDetail1.Instance.setMovie_nm(btn.Text);
            MovieDetail1.Instance.MovieDetail_test();
            MovieDetail1.Instance.Dock = DockStyle.Fill;
            MovieDetail1.Instance.BringToFront();
        }
    }
}
