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
        private string mem_id="";
        private Connection connect;
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
        public void setMem_id(string s)
        {
            mem_id = s;
        }
        public ReviewPage()
        {
            InitializeComponent();

           
        }

        public void ReviewPage_test()
        {
            try
            {
                
                string sql = "SELECT * FROM MOVIE WHERE MOVIE_NO = " + movie_no ;

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    this.MovieNM.Text = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                }

                string sql2 = "SELECT * FROM GRADE WHERE MOVIE_NO = " + movie_no;

                OracleCommand Comm2 = new OracleCommand(sql2, connect.con);
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

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }

        private void ReviewRegisterButton_Click(object sender, EventArgs e)
        {
          
            if (mem_id == "")
            {
                MessageBox.Show("로그인을 하세요!");
            }
            else
            {
                try
                {
                    OracleCommand Cmd = new OracleCommand();
                    Cmd.Connection = connect.con;
                    string sql = "SELECT * FROM GRADE WHERE MEM_ID='"+mem_id+"' AND MOVIE_NO="+movie_no;

                    OracleCommand Comm = new OracleCommand(sql, connect.con);
                    OracleDataReader reader = Comm.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show("이미 리뷰를 등록한 영화입니다!");

                        }
                    }
                    else
                    {
                        string sql2 = "INSERT INTO GRADE (MEM_ID, MOVIE_NO, MOVIE_SCORE, REVIEW) VALUES('" + mem_id + "'," + movie_no + "," + MovieScore.Text + ",'" + Review.Text + "')";
                        Cmd.CommandText = sql2;
                        Cmd.ExecuteNonQuery();
                        MessageBox.Show("리뷰가 등록되었습니다!");
                        Review.Text = "";
                    }


                    dataGridView1.Rows.Clear();

                    string sql3 = "SELECT * FROM GRADE WHERE MOVIE_NO = " + movie_no;

                    OracleCommand Comm2 = new OracleCommand(sql3, connect.con);
                    OracleDataReader reader2 = Comm2.ExecuteReader();

                    while (reader2.Read())
                    {
                        string memID = reader2.GetString(reader2.GetOrdinal("MEM_ID"));
                        string score = reader2.GetInt32(reader2.GetOrdinal("MOVIE_SCORE")).ToString();
                        string review = reader2.GetString(reader2.GetOrdinal("REVIEW"));

                        string[] row0 = { memID, score, review };

                        dataGridView1.Rows.Add(row0);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                
            }      
    }

        private void BackToHome_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            dataGridView1.Rows.Clear();
            connect.con.Close();
        }

        private void ReviewPage_Load(object sender, EventArgs e)
        {
            connect = new Connection();
            connect.Connecting();

        }
    }
}
