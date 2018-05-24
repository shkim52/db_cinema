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
    public partial class MoviePage : UserControl
    {
        public MoviePage()
        {
            InitializeComponent();

            string str = "data source=localhost:1521/xe;user id=SHKIM; password=5276";
            OracleConnection Conn = new OracleConnection(str);
            /**OracleCommand Comm;
            Comm = new OracleCommand();
            Comm.Connection = Conn;*/
            try
            {
            
                Conn.Open();
                string sql1 = "SELECT * FROM MOVIE WHERE MOVIE_NO=1 ";
                OracleCommand Comm1 = new OracleCommand(sql1,Conn);
            
                OracleDataReader reader1 = Comm1.ExecuteReader();

                while (reader1.Read())
                {
                    this.Movie1DetailButton.Text = reader1.GetString(reader1.GetOrdinal("MOVIE_NM"));
                }

                string sql2 = "SELECT * FROM MOVIE WHERE MOVIE_NO=2 ";
                OracleCommand Comm2 = new OracleCommand(sql2, Conn);

                OracleDataReader reader2 = Comm2.ExecuteReader();

                while (reader2.Read())
                {
                    this.Movie2DetailButton.Text = reader2.GetString(reader2.GetOrdinal("MOVIE_NM"));
                }

                string sql3 = "SELECT * FROM MOVIE WHERE MOVIE_NO=3 ";
                OracleCommand Comm3 = new OracleCommand(sql3, Conn);

                OracleDataReader reader3 = Comm3.ExecuteReader();

                while (reader3.Read())
                {
                    this.Movie3DetailButton.Text = reader3.GetString(reader3.GetOrdinal("MOVIE_NM"));
                }

                string sql4 = "SELECT * FROM MOVIE WHERE MOVIE_NO=4 ";
                OracleCommand Comm4 = new OracleCommand(sql4, Conn);

                OracleDataReader reader4 = Comm4.ExecuteReader();

                while (reader4.Read())
                {
                    this.Movie4DetailButton.Text = reader4.GetString(reader4.GetOrdinal("MOVIE_NM"));
                }

                string sql5 = "SELECT * FROM MOVIE WHERE MOVIE_NO=5 ";
                OracleCommand Comm5 = new OracleCommand(sql5, Conn);

                OracleDataReader reader5 = Comm5.ExecuteReader();

                while (reader5.Read())
                {
                    this.Movie5DetailButton.Text = reader5.GetString(reader5.GetOrdinal("MOVIE_NM"));
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
        

            MovieList.BringToFront();

            BackToHomeButton.Visible = false;
            ReviewButton.Visible = false;
        }

        private void Movie1DetailButton_Click(object sender, EventArgs e)
        {
            MovieDetail.BringToFront();

            Movie1DetailButton.Visible = false;
            Movie2DetailButton.Visible = false;
            Movie3DetailButton.Visible = false;
            Movie4DetailButton.Visible = false;
            Movie5DetailButton.Visible = false;

            BackToHomeButton.Visible = true;
            ReviewButton.Visible = true;
        }

        private void BackToHomeButton_Click(object sender, EventArgs e)
        {
            MovieList.BringToFront();

            Movie1DetailButton.Visible = true;
            Movie2DetailButton.Visible = true;
            Movie3DetailButton.Visible = true;
            Movie4DetailButton.Visible = true;
            Movie5DetailButton.Visible = true;

            BackToHomeButton.Visible = false;
            ReviewButton.Visible = false;
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            Movie1DetailButton.Visible = false;
            Movie2DetailButton.Visible = false;
            Movie3DetailButton.Visible = false;
            Movie4DetailButton.Visible = false;
            Movie5DetailButton.Visible = false;

            BackToHomeButton.Visible = true;
            ReviewButton.Visible = false;

            ReviewPage.BringToFront();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
