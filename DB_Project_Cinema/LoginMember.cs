﻿using System;
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
    public partial class LoginMember : UserControl
    {
        private Connection Connect;
        private static LoginMember _instance;
        public static LoginMember Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoginMember();
                }
                return _instance;
            }
        }
        public LoginMember()
        {
            InitializeComponent();
        }

        private void LoginMember_Load(object sender, EventArgs e)
        {
            Connect = new Connection();
            Connect.Connecting();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM MEM WHERE MEM_ID = '" + ID_INPUT.Text + "' AND MEM_PW = '" + PW_INPUT.Text+"'";

                OracleCommand Comm = new OracleCommand(sql, Connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                if (!reader.HasRows)
                {
                    MessageBox.Show("아이디 혹은 비밀번호를 잘못 입력하였습니다!");
                }

                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(reader.GetOrdinal("QUIT_STAT")));
                    if (reader.GetString(reader.GetOrdinal("QUIT_STAT")) == "N")
                    {
                        Program.memID = ID_INPUT.Text;
                        MessageBox.Show(ID_INPUT.Text + "님 환영합니다!");
                        //CinemaProgram c = new CinemaProgram();
                        //c.Show();
                        //this.Parent.Login_Complete();
                        (this.Parent).Parent.Controls.Remove(this);
                        //MoviePage.Instance.Dock = DockStyle.Fill;
                        //MoviePage.Instance.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("탈퇴회원입니다.");
                    }
                    
                }
                Connect.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
