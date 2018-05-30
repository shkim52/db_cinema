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
    public partial class JoinMembership : UserControl
    {
        private static JoinMembership _instance;
        public static JoinMembership Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new JoinMembership();
                }
                return _instance;
            }
        }
        public bool idcheck = false;
        
        public JoinMembership()
        {
            InitializeComponent();
        }

        private void DoubleCheckButton_Click(object sender, EventArgs e)
        {
            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);

            try
            {

                Conn.Open();

                string sql = "SELECT * FROM MEM WHERE MEM_ID='" + ID_INPUT.Text+"'";

                OracleCommand Comm = new OracleCommand(sql, Conn);
                OracleDataReader reader = Comm.ExecuteReader();

                if (reader.HasRows)
                {
                    ID_CHECK.Text = "이미 존재하는 아이디입니다!";
                    idcheck = false;
                }
                else
                {
                    ID_CHECK.Text = "사용 가능한 아이디입니다.";
                    idcheck = true;
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

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            string str = "data source=localhost:1521/xe;user id=CINEMA; password=1234";
            OracleConnection Conn = new OracleConnection(str);

            try
            {


                OracleCommand Cmd = new OracleCommand();
                Cmd.Connection = Conn;
                Conn.Open();

                if (PWD_INPUT.Text == "" && PWD2_INPUT.Text == "" && PWD2_INPUT != PWD_INPUT)
                {
                    MessageBox.Show("비밀번호가 일치하지 않거나 입력되지 않았습니다.");
                }
                else if (!EMAIL_INPUT.Text.Contains("@"))
                {
                    MessageBox.Show("이메일 형식이 잘못되었습니다.");
                }
                else if (SID_INPUT.Text.Length != 13)
                {
                    MessageBox.Show("생년월일 6자리를 입력해주세요.");
                }
                else if (NAME_INPUT.Text == "" && ID_INPUT.Text == "" && idcheck && TELNO_INPUT.Text == "")
                {
                    MessageBox.Show("잘못된 정보를 입력하였습니다.");
                }
                else
                {
                    string sql = "INSERT INTO MEM (MEM_ID, MEM_PW, MEM_NM, MEM_SID_NO, MEM_EMAIL, MEM_TELNO) VALUES('" + ID_INPUT.Text + "','" + PWD_INPUT.Text + "','" + NAME_INPUT.Text + "','" + SID_INPUT.Text + "','" + EMAIL_INPUT.Text + "','" + TELNO_INPUT.Text + "')";
                    Cmd.CommandText = sql;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("회원가입에 성공하셨습니다");

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
