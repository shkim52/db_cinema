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
        private string movie_nm;
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
        public void setMovie_nm(string s)
        {
            movie_nm = s;
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
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NM = '" + movie_nm + "'";

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
                    string sql = "SELECT * FROM MOVIE WHERE MOVIE_NM = '" + movie_nm + "'";

                    OracleCommand Comm = new OracleCommand(sql, Conn);
                    OracleDataReader reader = Comm.ExecuteReader();

                    while (reader.Read())
                    {
                        this.MovieNM.Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                        decimal movie_no = reader.GetDecimal(reader.GetOrdinal("MOVIE_NO"));

                        string sql2 = "INSERT INTO GRADE (MEM_ID, MOVIE_NO, MOVIE_SCORE, REVIEW) VALUES('" + Program.memID + "'," + movie_no + MovieScore.SelectedItem + Review.Text + "')";

                        Cmd.CommandText = sql2;
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
