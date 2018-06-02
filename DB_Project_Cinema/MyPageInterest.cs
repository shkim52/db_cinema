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
    public partial class MyPageInterest : UserControl
    {
        private OracleConnection Conn;
        private int movie_no;
        public MyPageInterest()
        {

            InitializeComponent();
            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            Conn = new OracleConnection(str);
        }

        private void MyPageInterest_Load(object sender, EventArgs e)
        {
            load_datagridview();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            { 
                if (e.ColumnIndex == 3)
                {

                }
                else if (e.ColumnIndex == 4)
                {
                    delete_interest(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    dataGridView1.Refresh();
                    //load_datagridview();
                }
            }
        }
        private void load_datagridview()
        {
            try
            {
                Conn.Open();

                string sql = "SELECT POSTER, MOVIE_NM, RELEASE_DATE, M.MOVIE_NO FROM MOVIE M, INTEREST_LIST I WHERE M.MOVIE_NO = I.MOVIE_NO AND I.MEM_ID = '" + Program.memID + "'";
                OracleCommand Comm = new OracleCommand(sql, Conn);

                OracleDataReader reader = Comm.ExecuteReader();
                if (!reader.HasRows)
                {
                    dataGridView1.Visible = false;
                    label2.Text = "현재 관심리스트에 내용이 존재하지 않습니다.";
                }
                while (reader.Read())
                {
                    
                    var poster = reader.GetString(reader.GetOrdinal("POSTER"));
                    System.Net.WebClient webSource = new System.Net.WebClient();
                    byte[] data = webSource.DownloadData(poster);
                    System.IO.MemoryStream pipe = new System.IO.MemoryStream(data);
                    Image jpgImage = Image.FromStream(pipe);

                    string movie_nm = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    string release = reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToString().Substring(0, 10) + " 개봉";
                    dataGridView1.Rows.Add(jpgImage, movie_nm, release);

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
        private void delete_interest(string movie_nm)
        {    
            find_movie_no(movie_nm);
            try
            {
                Conn.Open();
                OracleCommand Cmd = new OracleCommand();
                Cmd.Connection = Conn;
                
                string input_sql = "DELETE FROM INTEREST_LIST WHERE MOVIE_NO = " + movie_no +" AND MEM_ID = '" + Program.memID + "'";
                
                Cmd.CommandText = input_sql;
                Cmd.ExecuteNonQuery();
                
                MessageBox.Show("삭제완료");

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
        private void find_movie_no(string movie_nm)
        {
            try
            {
                Conn.Open();

                string sql = "SELECT I.MOVIE_NO FROM MOVIE M, INTEREST_LIST I WHERE M.MOVIE_NO = I.MOVIE_NO AND M.MOVIE_NM = '" + movie_nm + "'AND I.MEM_ID = '" + Program.memID + "'";
                OracleCommand Comm = new OracleCommand(sql, Conn);

                OracleDataReader reader = Comm.ExecuteReader();

                reader.Read();
                movie_no = reader.GetInt32(reader.GetOrdinal("MOVIE_NO"));
                
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
