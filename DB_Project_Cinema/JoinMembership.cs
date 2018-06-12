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
        public bool idcheck = false;        
        private Connection Connect;

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
        public JoinMembership()
        {
            InitializeComponent();
        }

        private void JoinMembership_Load(object sender, EventArgs e)
        {
            Connect = new Connection();
            Connect.Connecting();
        }

        private void DoubleCheckButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM MEM WHERE MEM_ID='" + ID_INPUT.Text+"'";

                OracleCommand Comm = new OracleCommand(sql, Connect.con);
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
                    ID_INPUT.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PWD_INPUT.Text == "" && PWD2_INPUT.Text == "" && PWD2_INPUT != PWD_INPUT)
                {
                    MessageBox.Show("비밀번호가 일치하지 않거나 입력되지 않았습니다.");
                }
                else if (!idcheck)
                {
                    MessageBox.Show("중복확인 체크를 해주세요");
                }
                else if (!EMAIL_INPUT.Text.Contains("@"))
                {
                    MessageBox.Show("이메일 형식이 잘못되었습니다.");
                }
                else if (SID_INPUT.Text.Length != 6)
                {
                    MessageBox.Show("생년월일 6자리를 입력해주세요.");
                }
                else if (NAME_INPUT.Text == "" && ID_INPUT.Text == "" && idcheck && TELNO_INPUT.Text == "")
                {
                    MessageBox.Show("잘못된 정보를 입력하였습니다.");
                }
                else
                {
                    OracleCommand Cmd = new OracleCommand();
                    Cmd.Connection = Connect.con;

                    string sql = "INSERT INTO MEM (MEM_ID, MEM_PW, MEM_NM, MEM_BIRTH, MEM_EMAIL, MEM_TELNO, SAVE_POINT, QUIT_STAT ) VALUES('" + ID_INPUT.Text + "','" + PWD_INPUT.Text + "','" + NAME_INPUT.Text + "','" + SID_INPUT.Text + "','" + EMAIL_INPUT.Text + "','" + TELNO_INPUT.Text + "', 0, 'N')";
                    Cmd.CommandText = sql;
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("회원가입에 성공하셨습니다");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
