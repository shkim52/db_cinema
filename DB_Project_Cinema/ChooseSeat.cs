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

        private int chosen_seat_cnt = 0;
        private string[] chosen_seat = new string[20];
        private int cnt = 0;
        private int index = 0;

        private string member;
        private string show_schedule;
        private int screen;

        public ChooseSeat(string mem_id, string schedule_no)
        {
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();

            member = mem_id;
            show_schedule = schedule_no;
            

        }

        private void ChooseSeat_Load(object sender, EventArgs e)
        {
            Seat_View();

            try
            {
                //  상영관에 맞는 상영관출력!
                screen = Convert.ToInt32(show_schedule.Substring(8, 1));
                string sql = "SELECT * FROM SCREEN WHERE SCR_NO=" +screen;
                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();
                
                while (reader.Read())
                {
                    this.SCR_NM.Text = reader.GetString(reader.GetOrdinal("SCR_NM"));
                    this.TOT_SEAT_CNT.Text = reader.GetDecimal(reader.GetOrdinal("SCR_SEAT_CNT")).ToString();

                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public string Get_SchNo()
        {
            return show_schedule;
        }
        public int Get_BkSeatCnt()
        {
            return chosen_seat_cnt;
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
                    seat[i, j].Name = (i * 20 + (j + 1)).ToString();
                    seat[i, j].Size = new Size(18, 18);
                    seat[i, j].Location = new Point(20 * (j + 1), 20 * (i + 1));
                    seat[i, j].FlatStyle = FlatStyle.Flat;
                    seat[i, j].BackColor = Color.Gray;
                    seat[i, j].FlatAppearance.BorderSize = 0;
                    seat[i, j].Click += new EventHandler(Seat_Click);

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
            Button seat = sender as Button;


            if (chosen_seat.Contains(seat.Name))
            {
                seat.BackColor = Color.Gray;
                chosen_seat_cnt--;
                Console.WriteLine(chosen_seat_cnt);
                Console.WriteLine(seat.Name);
                index = Array.IndexOf(chosen_seat, seat.Name);
                chosen_seat[index] = chosen_seat[cnt - 1];
                chosen_seat[cnt - 1] = null;
                cnt--;

            }
            else
            {
                seat.BackColor = Color.Red;
                chosen_seat_cnt++;
                Console.WriteLine(chosen_seat_cnt);
                Console.WriteLine(seat.Name);
                chosen_seat[cnt] = seat.Name;
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
                return true;
            }

        }
    }
}

