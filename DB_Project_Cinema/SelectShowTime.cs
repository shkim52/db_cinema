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

        private string mv_nm;
        private DateTime selected_date;
        private string show_start_time;
        public SelectShowTime()
        {
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();

        }

        private void SelectShowTime_Load(object sender, EventArgs e)
        {
            show_movie_nm();
            mv_nm = dataGridView1.Rows[0].Cells[0].Value.ToString();//초기값으로 맨 위에있는 영화 선택

            //일주일만 선택 가능하도록 제한
            DateTime now = DateTime.Now;
            DateTime week = now.AddDays(7);

            monthCalendar1.SelectionStart = now;
            monthCalendar1.SelectionEnd = week;
            monthCalendar1.MinDate = now;
            monthCalendar1.MaxDate = week;
        }
        //상영중인 영화들에 대한 정보 불러오기
        private void show_movie_nm()
        {
            try
            {
                string sql = "SELECT MOVIE_NM FROM MOVIE WHERE SHOW_STAT = 'Y' ORDER BY MOVIE_NM";

                OracleCommand Comm = new OracleCommand(sql, connect.con);

                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {

                    dataGridView1.Rows.Add(reader.GetString(reader.GetOrdinal("MOVIE_NM")));
                }
                connect.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mv_nm = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        //일주일만 선택 가능하도록 제한한 함수
        private void calendar_scope()
        {
            DateTime projectStart = monthCalendar1.SelectionStart;
            DateTime projectEnd = monthCalendar1.SelectionEnd;
            monthCalendar1.SelectionRange = new SelectionRange(projectStart, projectEnd);
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

            connect = new Connection();
            connect.Connecting();
            try
            {
                string sql2 = "SELECT SC.SCR_NM, SH.SHOW_START_TIME FROM MOVIE M, SH_SCHE SH, SCREEN SC WHERE M.MOVIE_NM = '" + mv_nm + "' AND M.MOVIE_NO = SH.MOVIE_NO AND SH.SCR_NO = SC.SCR_NO AND SH.SHOW_DATE= '" + selected_date.ToString().Substring(0, 10) + "' ORDER BY SC.SCR_NM, SH.SHOW_START_TIME";

                OracleCommand Comm = new OracleCommand(sql2, connect.con);

                OracleDataReader reader2 = Comm.ExecuteReader();
                
                while (reader2.Read())
                {
                    string scr_nm = reader2.GetString(reader2.GetOrdinal("SCR_NM"));
                    show_start_time = reader2.GetString(reader2.GetOrdinal("SHOW_START_TIME"));

                    dataGridView2.Rows.Add(scr_nm, show_start_time);
                }
                show_start_time = String.Empty;
                
                connect.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                 if (e.ColumnIndex == 1) //버튼 클릭시
                {
                    show_start_time = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                CinemaProgram cp = new CinemaProgram();
                cp.SetMovieName(mv_nm);
                cp.SetDate(selected_date.ToString().Substring(0, 10));
                cp.SetTime(show_start_time);
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
                ChooseSeat cs = new ChooseSeat(cp.GetLoginId(), mv_nm, selected_date.ToString().Substring(0, 10), show_start_time);
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
    }
}
