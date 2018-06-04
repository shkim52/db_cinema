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
        OracleConnection Conn;
        string mv_nm;
        public SelectShowTime()
        {
            InitializeComponent();
            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            Conn = new OracleConnection(str);
        }

        private void SelectShowTime_Load(object sender, EventArgs e)
        {
            show_movie_nm();
        }
        private void show_movie_nm()
        {
            try
            {

                Conn.Open();
                string sql = "SELECT MOVIE_NM FROM MOVIE WHERE SHOW_STAT = 'Y'";

                OracleCommand Comm = new OracleCommand(sql, Conn);

                OracleDataReader reader = Comm.ExecuteReader();

                while (reader.Read())
                {

                    dataGridView1.Rows.Add(reader.GetString(reader.GetOrdinal("MOVIE_NM")));
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mv_nm = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void calendar_scope()
        {

            DateTime projectStart = monthCalendar1.SelectionStart;
            DateTime projectEnd = monthCalendar1.SelectionEnd; 
            monthCalendar1.SelectionRange = new SelectionRange(projectStart, projectEnd); 
            
        }
    }
}
