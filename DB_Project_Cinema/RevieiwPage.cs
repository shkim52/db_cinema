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
    public partial class RevieiwPage : UserControl
    {
        public RevieiwPage()
        {
            InitializeComponent();

            InitializeComponent();

            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);
            /**OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;*/
            try
            {

                Conn.Open();
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NM = '" + Program.Movie_NM + "'";

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

            try
            {


                OracleCommand Cmd = new OracleCommand();
                Cmd.Connection = Conn;
                Conn.Open();

                string sql = "INSERT INTO GRADE (MEM_ID, MOVIE_NO, MOVIE_SCORE, REVIEW) VALUES('" + Program.memID + "',1,3,'" + Review.Text + "')";
                Cmd.CommandText = sql;
                Cmd.ExecuteNonQuery();
                MessageBox.Show("리뷰가 등록되었습니다!");

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
