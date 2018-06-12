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
    public partial class ChooseSeat : UserControl
    {
        private Connection connect;
        private Label[] RowNM = new Label[19];
        private Label[] ColNM = new Label[20];

        private Button[,] seat = new Button[19, 20];

        //private string[] used_seat = new string[500];
        //private string[] exist_seat = new string[500];

        private int[,] seat_array = new int[19, 20];
        //private int[,] exist_seat = new int[19, 20];

        private int chosen_seat_cnt = 0;
        private string[] chosen_seat = new string[20];
        private int cnt = 0;
        private int index = 0;

        private string member;
        private string show_schedule;
        private int screen;
        private string seat_no;

        public ChooseSeat(string mem_id, string schedule_no)
        {
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();

            member = mem_id;
            show_schedule = schedule_no;
            Seat_View();
        }
        private void ChooseSeat_Load(object sender, EventArgs e)
        {
            try
            {
                //  상영관에 맞는 상영관출력!
                screen = Convert.ToInt32(show_schedule.Substring(8, 1));
                string sql = "SELECT * FROM SCREEN WHERE SCR_NO=" + screen;
                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {
                    this.SCR_NM.Text = reader.GetString(reader.GetOrdinal("SCR_NM"));
                    this.TOT_SEAT_CNT.Text = reader.GetDecimal(reader.GetOrdinal("SCR_SEAT_CNT")).ToString();
                }

                string sql2 = "SELECT * FROM SEAT WHERE SCR_NO=" + screen;
                OracleCommand Comm2 = new OracleCommand(sql2, connect.con);
                OracleDataReader reader2 = Comm2.ExecuteReader();

                //int index = 0;
                try
                {
                    while (reader2.Read())
                    {
                        int row = Convert.ToChar(reader2["SEAT_ROW"]) - 0 - 65;
                        int col = Convert.ToInt32(reader2["SEAT_COL"]) - 1;

                        seat[row, col].Visible = true;
                        seat[row, col].BackColor = Color.Gray;
                        seat[row, col].Name = (reader2["SEAT_NO"]).ToString();
                    }
                }
                catch (Exception)
                {

                }
                /*while (reader2.Read())
                {
                    exist_seat[index++] = Convert.ToString(reader2["SEAT_NO"]);
                }*/

                string sql3 = "SELECT * FROM SEAT_USE WHERE SHOW_SCHE_NO='" + show_schedule + "' AND SEAT_USE_STAT='Y'";
                OracleCommand Comm3 = new OracleCommand(sql3, connect.con);
                OracleDataReader reader3 = Comm3.ExecuteReader();

                int index2 = 0;

                while (reader3.Read())
                {
                    int seat_no = Convert.ToInt32(reader3["SEAT_NO"]);
                    string seat_sql = "SELECT * FROM SEAT WHERE SEAT_NO = " + seat_no;

                    OracleCommand seat_com = new OracleCommand(seat_sql, connect.con);
                    OracleDataReader seat_reader = seat_com.ExecuteReader();
                    seat_reader.Read();
                    int row = Convert.ToChar(seat_reader["SEAT_ROW"]) - 0 - 65;
                    int col = Convert.ToInt32(seat_reader["SEAT_COL"]) - 1;
                    seat[row, col].Visible = true;
                    seat[row, col].BackColor = Color.LightGray;
                    seat[row, col].Enabled = false;

                    seat_array[row, col] = seat_no;
                }

                string sql4 = "SELECT COUNT(*) FROM SEAT_USE WHERE SHOW_SCHE_NO='" + show_schedule + "' AND SEAT_USE_STAT='Y'";
                OracleCommand Comm4 = new OracleCommand(sql4, connect.con);
                OracleDataReader reader4 = Comm4.ExecuteReader();

                while (reader4.Read())
                {
                    this.LeftSeatCnt.Text = (int.Parse(TOT_SEAT_CNT.Text) - reader4.GetInt32(reader4.GetOrdinal("COUNT(*)"))).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //Seat_View();

        }
        public string Get_SchNo()
        {
            return show_schedule;
        }
        public int Get_BkSeatCnt()
        {
            return chosen_seat_cnt;
        }
        public string Get_SeatNo()
        {
            return seat_no;
        }

        public void Seat_View()
        {
            for (int i = 0; i < 19; i++)
            {
                RowNM[i] = new Label();
                RowNM[i].Name = Convert.ToChar(i + 65) + "행";
                RowNM[i].Size = new Size(18, 18);
                RowNM[i].Location = new Point(0, 20 * (i + 1));
                RowNM[i].Text = Convert.ToChar(i + 65) + "";
                RowNM[i].TextAlign = ContentAlignment.MiddleCenter;

                panel1.Controls.Add(RowNM[i]);
            }

            for (int i = 0; i < 20; i++)
            {
                ColNM[i] = new Label();
                ColNM[i].Name = (i + 1).ToString() + "열";
                ColNM[i].Size = new Size(18, 18);
                ColNM[i].Location = new Point(20 * (i + 1), 0);
                ColNM[i].Text = (i + 1).ToString();
                ColNM[i].TextAlign = ContentAlignment.MiddleCenter;

                panel1.Controls.Add(ColNM[i]);
            }

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    seat[i, j] = new Button();
                    seat[i, j].Size = new Size(18, 18);
                    seat[i, j].Location = new Point(20 * (j + 1), 20 * (i + 1));
                    seat[i, j].FlatStyle = FlatStyle.Flat;
                    seat[i, j].BackColor = Color.Gray;
                    seat[i, j].FlatAppearance.BorderSize = 0;
                    seat[i, j].Click += new EventHandler(Seat_Click);
                    seat[i, j].Visible = false;
                    //좌석 이름 설정
                    /*
                    for (int k = 0; k < 10; k++)
                    {
                       if (screen == (k + 1))
                        {
                            seat[i, j].Name = (i * 20 + (j + 1) + 380 * k).ToString();
                        }
                    }*/

                   /* if (used_seat.Contains(seat[i, j].Name))
                    {
                        seat[i, j].Visible=true;
                        seat[i, j].BackColor = Color.LightGray;
                        seat[i, j].Enabled = false;
                    }
                    else
                    {
                        seat[i, j].Visible = true;
                        seat[i, j].BackColor = Color.Gray;
                        seat[i, j].Enabled = true;
                    }
                
                   if(!exist_seat.Contains(seat[i, j].Name))
                    {
                        seat[i, j].Visible = false;
                    }
                    else
                    {
                        seat[i, j].Visible = true;
                    }*/
                
                    panel1.Controls.Add(seat[i, j]);
                }                
            }

            Label choose = new Label();
            choose.Size = new Size(18, 18);
            choose.Location = new Point(0, 0);
            choose.BackColor = Color.Red;

            Label chooseSeat = new Label();
            chooseSeat.Size = new Size(100, 18);
            chooseSeat.Location = new Point(23, 0);
            chooseSeat.Text = "선택 좌석";
            chooseSeat.TextAlign = ContentAlignment.MiddleLeft;

            Label unresv = new Label();            
            unresv.Size = new Size(18, 18);
            unresv.Location = new Point(0,25);
            unresv.BackColor = Color.Gray;
            
            Label unresvSeat = new Label();
            unresvSeat.Size = new Size(100, 18);
            unresvSeat.Location = new Point(23, 25);
            unresvSeat.Text = "예매 가능 좌석";
            unresvSeat.TextAlign = ContentAlignment.MiddleLeft;

            Label resv = new Label();
            resv.Size = new Size(18, 18);
            resv.Location = new Point(0, 50);
            resv.BackColor = Color.LightGray;

            Label resvSeat = new Label();
            resvSeat.Size = new Size(100, 18);
            resvSeat.Location = new Point(23, 50);
            resvSeat.Text = "예매된 좌석";
            resvSeat.TextAlign = ContentAlignment.MiddleLeft;
            

            panel2.Controls.Add(choose);
            panel2.Controls.Add(chooseSeat);
            panel2.Controls.Add(unresv);
            panel2.Controls.Add(unresvSeat);
            panel2.Controls.Add(resv);
            panel2.Controls.Add(resvSeat);
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            string button_name = ((Button)sender).Name;
            
            if (chosen_seat.Contains(button_name))
            {
                ((Button)sender).BackColor = Color.Gray;
                chosen_seat_cnt--;
                Console.WriteLine(chosen_seat_cnt);
                Console.WriteLine(button_name);
                index = Array.IndexOf(chosen_seat, button_name);
                chosen_seat[index] = chosen_seat[cnt - 1];
                chosen_seat[cnt - 1] = null;
                cnt--;

            }
            else
            {
                ((Button)sender).BackColor = Color.Red;
                chosen_seat_cnt++;
                Console.WriteLine(chosen_seat_cnt);
                Console.WriteLine(button_name);
                chosen_seat[cnt] = button_name;
                cnt++;
            }
        }
        public bool SeatCnt_Check()
        {
            if (ChooseNumber.Text != chosen_seat_cnt.ToString())
            {
                MessageBox.Show("인원 수에 맞게 좌석 선택을 다시 해주세요!");
               
                return false;
            }
            else
            {
                for (int i = 0; i < chosen_seat.Length; i++)
                {
                    seat_no += chosen_seat[i] + ",";
                }

                return true;
            }
        }
    }
}

