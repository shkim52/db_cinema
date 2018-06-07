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
        private Connection connect;
        private string mem_id;
        private MyPage _parent;
        private int[] movie_array;

        public MyPageInterest(MyPage parent,string member)
        {
            InitializeComponent();

            _parent = parent;

            connect = new Connection();
            connect.Connecting();

            movie_array = new int[30];
            mem_id = member;
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
                string movie_name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (e.ColumnIndex == 3) // 디테일페이지 이동
                {
                    _parent.Interest_MovieDetail_View(movie_array[e.RowIndex]);
                }
                else if (e.ColumnIndex == 4) // 관심리스트 삭제
                {
                    delete_interest(movie_array[e.RowIndex]);
                    dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);
                    //load_datagridview();
                }
            }
        }
        private void load_datagridview()
        {
            try
            {

                string sql = "SELECT POSTER, MOVIE_NM, RELEASE_DATE, M.MOVIE_NO FROM MOVIE M, INTEREST_LIST I WHERE M.MOVIE_NO = I.MOVIE_NO AND I.MEM_ID = '" + mem_id + "'";
                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                if (!reader.HasRows)
                {
                    dataGridView1.Visible = false;
                    label2.Text = "현재 관심리스트에 내용이 존재하지 않습니다.";
                }
                int index = 0;

                while (reader.Read())
                {
                    movie_array[index++] = Convert.ToInt32(reader["MOVIE_NO"]);
                    var poster = reader.GetString(reader.GetOrdinal("POSTER"));
                    System.Net.WebClient webSource = new System.Net.WebClient();
                    byte[] data = webSource.DownloadData(poster);
                    System.IO.MemoryStream pipe = new System.IO.MemoryStream(data);
                    Image jpgImage = Image.FromStream(pipe);

                    string movie_nm = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    string release = reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToString().Substring(0, 10) + " 개봉";
                    dataGridView1.Rows.Add(jpgImage, movie_nm, release);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        private void delete_interest(int movie_no)
        {
            try
            {
                OracleCommand Cmd = new OracleCommand();
                Cmd.Connection = connect.con;

                string input_sql = "DELETE FROM INTEREST_LIST WHERE MOVIE_NO = " + movie_no + " AND MEM_ID = '" + mem_id + "'";

                Cmd.CommandText = input_sql;
                Cmd.ExecuteNonQuery();

                MessageBox.Show("삭제완료");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
