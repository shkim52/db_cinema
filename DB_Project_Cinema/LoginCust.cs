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
    public partial class LoginCust : UserControl
    {
        private static LoginCust _instance;
        private Connection connect;
        private CinemaProgram _parent;
        /*public static LoginCust Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoginCust();
                }
                return _instance;
            }
        }*/
        public LoginCust(CinemaProgram parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void LoginCust_Load(object sender, EventArgs e)
        {
            connect = new Connection();
            connect.Connecting();
        }

        private void mem_loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM CUST WHERE CUST_ID = '" + ID_INPUT.Text + "' AND CUST_PW = '" + PW_INPUT.Text + "'";

                OracleCommand Comm = new OracleCommand(sql, connect.con);
                OracleDataReader reader = Comm.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("로그인 완료되었습니다.");
                    CustCheckResv ccr = new CustCheckResv(ID_INPUT.Text);
                    this.Parent.Controls.Remove(this);
                    _parent.mainPanel.Controls.Add(ccr);
                    ccr.Dock = DockStyle.Fill;
                    ccr.BringToFront();
                }

                else
                {
                    MessageBox.Show("아이디 혹은 비밀번호를 잘못 입력하였습니다!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}