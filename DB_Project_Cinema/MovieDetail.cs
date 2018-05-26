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
        public MovieDetail()
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
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NO=1";
                OracleCommand Comm = new OracleCommand(sql,Conn);

               
                OracleDataReader reader = Comm.ExecuteReader();
              
                while (reader.Read())
                {
                
                    //this.TOT_SEAT_CNT.Text = reader.GetString(reader.GetOrdinal("ACTOR_NM"));
                    this.Movie_NM.Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    this.Movie_Intro.Text=reader.GetString(reader.GetOrdinal("MOVIE_INTRO"));
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

