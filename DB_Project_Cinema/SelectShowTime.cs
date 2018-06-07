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
    public partial class SelectShowTime : UserControl
    {
        private Connection connect;
        private string mv_nm; // 삭제해야될 부분 
        private DateTime selected_date;
        private string show_start_time;
        private int[] movie_no_array;
        private int selected_movie_no;
        private string select_sch_no;

        public SelectShowTime()
        {
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();

            movie_no_array = new int[200];
            Init_array(movie_no_array);
        }

        private void SelectShowTime_Load(object sender, EventArgs e)
        {
            show_movie_nm();
            mv_nm = dataGridView1.Rows[0].Cells[0].Value.ToString();//초기값으로 맨 위에있는 영화 선택
            selected_movie_no = 0;

            //일주일만 선택 가능하도록 제한
            DateTime now = DateTime.Now;
            DateTime week = now.AddDays(7);

            monthCalendar1.SelectionStart = now;
            monthCalendar1.SelectionEnd = week;
            monthCalendar1.MinDate = now;
            monthCalendar1.MaxDate = week;

            selected_date = monthCalendar1.SelectionRange.Start;
        }

        public string Get_SchNo()
        {
            return select_sch_no;
        }

        private void Init_array(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }

        //상영중인 영화들에 대한 정보 불러오기
        private void show_movie_nm()
        {
            try
            {
                string sql = "SELECT MOVIE_NO,MOVIE_NM FROM MOVIE WHERE SHOW_STAT = 'Y' ORDER BY MOVIE_NM";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                int index = 0;

                while (reader.Read())
                {
                    movie_no_array[index++] = Convert.ToInt32(reader["MOVIE_NO"]);
                    dataGridView1.Rows.Add(reader["MOVIE_NM"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mv_nm = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            selected_movie_no = movie_no_array[e.RowIndex];

            refresh_showtime();
        }
        //값이 선택될때마다 상영일정을 보여주기 위함
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            selected_date = monthCalendar1.SelectionRange.Start;

            refresh_showtime();
        }
        //상영일정 보여주기
        private void refresh_showtime()
        {
            dataGridView2.Rows.Clear(); //상영일정 정보에 기존에 추가되어있는 내용이 있으면 삭제

            try
            {
                string sql = "SELECT SC.SCR_NM, SH.SHOW_START_TIME,SH.SHOW_SCHE_NO FROM MOVIE M, SH_SCHE SH, SCREEN SC WHERE M.MOVIE_NO = '" + selected_movie_no + "' AND M.MOVIE_NO = SH.MOVIE_NO AND SH.SCR_NO = SC.SCR_NO AND SH.SHOW_DATE= '" + selected_date.ToString().Substring(0, 10) + "' ORDER BY SC.SCR_NM, SH.SHOW_START_TIME";
                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();
                int index;
                while (reader.Read())
                {
                    index = dataGridView2.Rows.Add();
                    dataGridView2.Rows[index].Cells[0].Value = reader["SCR_NM"];
                    dataGridView2.Rows[index].Cells[1].Value = reader["SHOW_START_TIME"];
                    dataGridView2.Rows[index].Cells[2].Value = reader["SHOW_SCHE_NO"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void chooseseatbuttonClicked()
        {
            CinemaProgram cp = new CinemaProgram();
            if (cp.GetLoginId() == String.Empty)
            {
                MessageBox.Show("로그인을 하세요!");
            }
            else if (selected_date.ToString().Substring(0, 10) == String.Empty || show_start_time == String.Empty)
            {
                MessageBox.Show("상영일자 혹은 상영시간이 선택되지 않았습니다.");
                Console.WriteLine("!!!!!!!");
            }
            else
            {
                ChooseSeat cs = new ChooseSeat(cp.GetLoginId(), selected_date.ToString());
                this.Parent.Controls.Add(cs); // parent -> panel3
                cs.Dock = DockStyle.None;
                cs.BringToFront();
                /*
                ChooseSeatPageButton.Visible = false;
                PaymentPageButton.Visible = true;
                BackToSelcetTimeButton.Visible = true;
                BackToChooseSeatButton.Visible = false;*/
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 1) //버튼 클릭시
                {
                    DataGridViewCell cell = dataGridView2[e.ColumnIndex, e.RowIndex];
                    DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                    cellStyle.SelectionBackColor = Color.DarkRed;
                    cellStyle.SelectionForeColor = Color.White;
                    cell.Style = cellStyle;

                    select_sch_no = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
