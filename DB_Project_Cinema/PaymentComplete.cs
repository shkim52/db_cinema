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
    public partial class PaymentComplete : UserControl
    {
        private Connection connect;
        private string show_schedule_no;
        private string tk_bk_no;
        private int movie_no;
        private int bk_seat_no;
        private int screen_no;
        private string paymentprice;
        private string[] seat_no = new string[10];

        public PaymentComplete(string show_scehdule, string Payment_Price)
        {
            InitializeComponent();
            connect = new Connection();
            connect.Connecting();

            show_schedule_no = show_scehdule;
            paymentprice = Payment_Price;

            Ticket_Info();
        }


        private void Ticket_Info()
        {
            try
            {
                string sql = "SELECT * FROM (SELECT * FROM BOOKING WHERE SHOW_SCHE_NO = '"+show_schedule_no+"' ORDER BY TK_BK_NO DESC) WHERE rownum = 1";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();


                while (reader.Read())
                {
                    tk_bk_no = reader.GetString(reader.GetOrdinal("TK_BK_NO"));
                    TicketNo.Text = reader.GetString(reader.GetOrdinal("TK_BK_NO"));
                    movie_no = reader.GetInt32(reader.GetOrdinal("MOVIE_NO"));
                    bk_seat_no = reader.GetInt32(reader.GetOrdinal("BK_SEAT_CNT"));
                }

                string sql2 = "SELECT * FROM MOVIE WHERE MOVIE_NO=" + movie_no;

                OracleCommand Comm2 = new OracleCommand(sql2, connect.con);
                OracleDataReader reader2 = Comm2.ExecuteReader();

                while (reader2.Read())
                {
                    MovieName.Text = reader2.GetString(reader2.GetOrdinal("MOVIE_NM"));
                    var poster = reader2.GetString(reader2.GetOrdinal("POSTER"));

                    MoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;
                    MoviePoster.ImageLocation = poster;
                }

                string sql3 = "SELECT * FROM SH_SCHE WHERE SHOW_SCHE_NO=" + show_schedule_no;

                OracleCommand Comm3 = new OracleCommand(sql3, connect.con);
                OracleDataReader reader3 = Comm3.ExecuteReader();

                while (reader3.Read())
                {
                    ScheDate.Text = reader3.GetDateTime(reader3.GetOrdinal("SHOW_DATE")).ToString().Substring(0, 10);
                    ScheStarTime.Text = reader3.GetString(reader3.GetOrdinal("SHOW_START_TIME"));
                    ScheEndTime.Text = reader3.GetString(reader3.GetOrdinal("SHOW_END_TIME"));
                }

                screen_no = Convert.ToInt32(show_schedule_no.Substring(8, 1));

                string sql4 = "SELECT * FROM SCREEN WHERE SCR_NO=" + screen_no;

                OracleCommand Comm4 = new OracleCommand(sql4, connect.con);
                OracleDataReader reader4 = Comm4.ExecuteReader();

                reader4.Read();

                ScrName.Text = reader4.GetString(reader4.GetOrdinal("SCR_NM"));

                string sql5 = "SELECT * FROM BK_SEAT WHERE TK_BK_NO=" + tk_bk_no;

                OracleCommand Comm5 = new OracleCommand(sql5, connect.con);
                OracleDataReader reader5 = Comm5.ExecuteReader();
                
                int index = 0;

                while (reader5.Read())
                {
                    seat_no[index++] = Convert.ToString(reader5["SEAT_NO"]); 
                }

                for (int i = 0; i < bk_seat_no; i++)
                {
                    SeatNo.Text += seat_no[i]+"/ ";
                }

                PaymentPrice.Text = paymentprice;
                      
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
