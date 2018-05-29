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
    public partial class MovieList : UserControl
    {
        public MovieList()
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
                string sql1 = "SELECT * FROM MOVIE WHERE MOVIE_NO=1 ";
                OracleCommand Comm1 = new OracleCommand(sql1, Conn);

                OracleDataReader reader1 = Comm1.ExecuteReader();

                while (reader1.Read())
                {
                    

                    var poster = reader1.GetString(reader1.GetOrdinal("POSTER"));

                    Poster1.SizeMode = PictureBoxSizeMode.StretchImage;
                    Poster1.ImageLocation = poster;
                }

                string sql2 = "SELECT * FROM MOVIE WHERE MOVIE_NO=2 ";
                OracleCommand Comm2 = new OracleCommand(sql2, Conn);

                OracleDataReader reader2 = Comm2.ExecuteReader();

                while (reader2.Read())
                {
                    
                    var poster = reader2.GetString(reader2.GetOrdinal("POSTER"));

                    Poster2.SizeMode = PictureBoxSizeMode.StretchImage;
                    Poster2.ImageLocation = poster;
                }

                string sql3 = "SELECT * FROM MOVIE WHERE MOVIE_NO=3 ";
                OracleCommand Comm3 = new OracleCommand(sql3, Conn);

                OracleDataReader reader3 = Comm3.ExecuteReader();

                while (reader3.Read())
                {
                    
                    var poster = reader3.GetString(reader3.GetOrdinal("POSTER"));

                    Poster3.SizeMode = PictureBoxSizeMode.StretchImage;
                    Poster3.ImageLocation = poster;
                }

                string sql4 = "SELECT * FROM MOVIE WHERE MOVIE_NO=4 ";
                OracleCommand Comm4 = new OracleCommand(sql4, Conn);

                OracleDataReader reader4 = Comm4.ExecuteReader();

                while (reader4.Read())
                {
                    
                    var poster = reader4.GetString(reader4.GetOrdinal("POSTER"));

                    Poster4.SizeMode = PictureBoxSizeMode.StretchImage;
                    Poster4.ImageLocation = poster;
                }

                string sql5 = "SELECT * FROM MOVIE WHERE MOVIE_NO=5 ";
                OracleCommand Comm5 = new OracleCommand(sql5, Conn);

                OracleDataReader reader5 = Comm5.ExecuteReader();

                while (reader5.Read())
                {
                   
                    var poster = reader5.GetString(reader5.GetOrdinal("POSTER"));

                    Poster5.SizeMode = PictureBoxSizeMode.StretchImage;
                    Poster5.ImageLocation = poster;
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
