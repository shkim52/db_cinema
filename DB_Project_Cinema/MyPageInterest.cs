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
        public MyPageInterest()
        {
            InitializeComponent();
            
            
            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);
            
            try
            {

                Conn.Open();

                string sql = "SELECT POSTER, MOVIE_NM, RELEASE_DATE, DIRECTOR_NM FROM MOVIE M, INTEREST_LIST I WHERE M.MOVIE_NO = I.MOVIE_NO AND I.MEM_ID = '"+Program.memID+"'";
                Console.WriteLine(sql);
                OracleCommand Comm = new OracleCommand(sql, Conn);

                OracleDataReader reader = Comm.ExecuteReader();
                if (!reader.HasRows)
                {
                    dataGridView1.Visible = false;
                }
                while(reader.Read())
                {
                    var poster = reader.GetString(reader.GetOrdinal("POSTER"));
                    System.Net.WebClient webSource = new System.Net.WebClient();
                    byte[] data = webSource.DownloadData(poster);
                    System.IO.MemoryStream pipe = new System.IO.MemoryStream(data);
                    Image jpgImage = Image.FromStream(pipe);
                    
                    string movie_nm = reader.GetString(reader.GetOrdinal("MOVIE_NM"));
                    string release = reader.GetDateTime(reader.GetOrdinal("RELEASE_DATE")).ToString().Substring(0, 10);
                    string director_nm = reader.GetString(reader.GetOrdinal("DIRECTOR_NM"));
                    dataGridView1.Rows.Add(jpgImage, movie_nm, release, director_nm); 

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
}
