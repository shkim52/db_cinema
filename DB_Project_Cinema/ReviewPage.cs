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
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NO = " + movie_no ;

                OracleCommand Comm = new OracleCommand(sql, Conn);
                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    this.MovieNM.Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                }

                string sql2 = "SELECT * FROM GRADE WHERE MOVIE_NO = " + movie_no;
                
                OracleCommand Comm2 = new OracleCommand(sql2, Conn);
                OracleDataReader reader2 = Comm2.ExecuteReader();

                while (reader2.Read())
                {
                    string memID = reader2.GetString(reader2.GetOrdinal("MEM_ID"));
                    string score = reader2.GetInt32(reader2.GetOrdinal("MOVIE_SCORE")).ToString();
                    string review = reader2.GetString(reader2.GetOrdinal("REVIEW"));

                    string[] row0 = { memID, score, review };

                    this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 

                    dataGridView1.Rows.Add(row0);
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
          
            /*if (Program.memID == "")
            {
                MessageBox.Show("로그인을 하세요!");
            }
            else*/
            {
                try
                {
                    OracleCommand Cmd = new OracleCommand();
                    Cmd.Connection = Conn;
                    Conn.Open();

                    string sql = "SELECT * FROM GRADE WHERE MEM_ID='"+Program.memID+"' AND MOVIE_NO="+movie_no;

                    OracleCommand Comm = new OracleCommand(sql, Conn);
                    OracleDataReader reader = Comm.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show("이미 리뷰를 등록한 영화입니다!");

                        }
                    }
                    else if (!reader.HasRows)
                    {
                        string sql2 = "INSERT INTO GRADE (MEM_ID, MOVIE_NO, MOVIE_SCORE, REVIEW) VALUES('" + Program.memID + "'," + movie_no + "," + MovieScore.Text + ",'" + Review.Text + "')";
                        Cmd.CommandText = sql2;
                        Cmd.ExecuteNonQuery();
                        MessageBox.Show("리뷰가 등록되었습니다!");
                    }


                    dataGridView1.Rows.Clear();

                    string sql3 = "SELECT * FROM GRADE WHERE MOVIE_NO = " + movie_no;

                    OracleCommand Comm2 = new OracleCommand(sql3, Conn);
                    OracleDataReader reader2 = Comm2.ExecuteReader();

                    while (reader2.Read())
                    {
                        string memID = reader2.GetString(reader2.GetOrdinal("MEM_ID"));
                        string score = reader2.GetInt32(reader2.GetOrdinal("MOVIE_SCORE")).ToString();
                        string review = reader2.GetString(reader2.GetOrdinal("REVIEW"));

                        string[] row0 = { memID, score, review };

                        dataGridView1.Rows.Add(row0);
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

        private void BackToHome_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            dataGridView1.Rows.Clear();
        }
    }
}
