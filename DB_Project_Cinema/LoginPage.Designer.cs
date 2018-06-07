namespace DB_Project_Cinema
{
    partial class LoginPage
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MemLoginTab = new System.Windows.Forms.Button();
            this.CustLoginTab = new System.Windows.Forms.Button();
            this.mem_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_INPUT = new System.Windows.Forms.TextBox();
            this.PW_INPUT = new System.Windows.Forms.TextBox();
            this.mem_loginButton = new System.Windows.Forms.Button();
            this.cust_panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cust_loginButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.mem_panel.SuspendLayout();
            this.cust_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MemLoginTab);
            this.panel1.Controls.Add(this.CustLoginTab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 217);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(550, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemLoginTab
            // 
            this.MemLoginTab.BackColor = System.Drawing.Color.LightGray;
            this.MemLoginTab.FlatAppearance.BorderSize = 0;
            this.MemLoginTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemLoginTab.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemLoginTab.Location = new System.Drawing.Point(512, 164);
            this.MemLoginTab.Margin = new System.Windows.Forms.Padding(2);
            this.MemLoginTab.Name = "MemLoginTab";
            this.MemLoginTab.Size = new System.Drawing.Size(71, 37);
            this.MemLoginTab.TabIndex = 4;
            this.MemLoginTab.Text = "회원";
            this.MemLoginTab.UseVisualStyleBackColor = false;
            this.MemLoginTab.Click += new System.EventHandler(this.MemLoginTab_Click);
            // 
            // CustLoginTab
            // 
            this.CustLoginTab.BackColor = System.Drawing.Color.LightGray;
            this.CustLoginTab.FlatAppearance.BorderSize = 0;
            this.CustLoginTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustLoginTab.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CustLoginTab.Location = new System.Drawing.Point(592, 164);
            this.CustLoginTab.Margin = new System.Windows.Forms.Padding(2);
            this.CustLoginTab.Name = "CustLoginTab";
            this.CustLoginTab.Size = new System.Drawing.Size(71, 37);
            this.CustLoginTab.TabIndex = 5;
            this.CustLoginTab.Text = "비회원";
            this.CustLoginTab.UseVisualStyleBackColor = false;
            this.CustLoginTab.Click += new System.EventHandler(this.CustLoginTab_Click);
            // 
            // mem_panel
            // 
            this.mem_panel.Controls.Add(this.label2);
            this.mem_panel.Controls.Add(this.label3);
            this.mem_panel.Controls.Add(this.ID_INPUT);
            this.mem_panel.Controls.Add(this.PW_INPUT);
            this.mem_panel.Controls.Add(this.mem_loginButton);
            this.mem_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mem_panel.Location = new System.Drawing.Point(0, 217);
            this.mem_panel.Name = "mem_panel";
            this.mem_panel.Size = new System.Drawing.Size(1083, 262);
            this.mem_panel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(409, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(381, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ID_INPUT
            // 
            this.ID_INPUT.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID_INPUT.Location = new System.Drawing.Point(490, 68);
            this.ID_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.ID_INPUT.Name = "ID_INPUT";
            this.ID_INPUT.Size = new System.Drawing.Size(210, 30);
            this.ID_INPUT.TabIndex = 12;
            // 
            // PW_INPUT
            // 
            this.PW_INPUT.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PW_INPUT.Location = new System.Drawing.Point(490, 108);
            this.PW_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.PW_INPUT.Name = "PW_INPUT";
            this.PW_INPUT.PasswordChar = '*';
            this.PW_INPUT.Size = new System.Drawing.Size(210, 30);
            this.PW_INPUT.TabIndex = 13;
            // 
            // mem_loginButton
            // 
            this.mem_loginButton.BackColor = System.Drawing.Color.LightGray;
            this.mem_loginButton.FlatAppearance.BorderSize = 0;
            this.mem_loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mem_loginButton.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mem_loginButton.Location = new System.Drawing.Point(726, 68);
            this.mem_loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.mem_loginButton.Name = "mem_loginButton";
            this.mem_loginButton.Size = new System.Drawing.Size(71, 68);
            this.mem_loginButton.TabIndex = 14;
            this.mem_loginButton.Text = "로그인";
            this.mem_loginButton.UseVisualStyleBackColor = false;
            this.mem_loginButton.Click += new System.EventHandler(this.mem_loginButton_Click);
            // 
            // cust_panel
            // 
            this.cust_panel.Controls.Add(this.label8);
            this.cust_panel.Controls.Add(this.cust_loginButton);
            this.cust_panel.Controls.Add(this.label7);
            this.cust_panel.Controls.Add(this.label4);
            this.cust_panel.Controls.Add(this.textBox4);
            this.cust_panel.Controls.Add(this.label5);
            this.cust_panel.Controls.Add(this.textBox3);
            this.cust_panel.Controls.Add(this.label6);
            this.cust_panel.Controls.Add(this.textBox2);
            this.cust_panel.Controls.Add(this.textBox1);
            this.cust_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cust_panel.Location = new System.Drawing.Point(0, 217);
            this.cust_panel.Name = "cust_panel";
            this.cust_panel.Size = new System.Drawing.Size(1083, 262);
            this.cust_panel.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(616, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "-  *******";
            // 
            // cust_loginButton
            // 
            this.cust_loginButton.BackColor = System.Drawing.Color.LightGray;
            this.cust_loginButton.FlatAppearance.BorderSize = 0;
            this.cust_loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cust_loginButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cust_loginButton.Location = new System.Drawing.Point(770, 88);
            this.cust_loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.cust_loginButton.Name = "cust_loginButton";
            this.cust_loginButton.Size = new System.Drawing.Size(75, 70);
            this.cust_loginButton.TabIndex = 21;
            this.cust_loginButton.Text = "로그인";
            this.cust_loginButton.UseVisualStyleBackColor = false;
            this.cust_loginButton.Click += new System.EventHandler(this.cust_loginButton_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(400, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 33);
            this.label7.TabIndex = 50;
            this.label7.Text = "이름:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(360, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 33);
            this.label4.TabIndex = 57;
            this.label4.Text = "비밀번호:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(493, 49);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(238, 30);
            this.textBox4.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(360, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 33);
            this.label5.TabIndex = 56;
            this.label5.Text = "휴대폰번호:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(493, 90);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.MaxLength = 6;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 30);
            this.textBox3.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(360, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 33);
            this.label6.TabIndex = 55;
            this.label6.Text = "생년월일:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(493, 132);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.MaxLength = 11;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 30);
            this.textBox2.TabIndex = 53;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(493, 174);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(238, 30);
            this.textBox1.TabIndex = 54;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cust_panel);
            this.Controls.Add(this.mem_panel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(1083, 479);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mem_panel.ResumeLayout(false);
            this.mem_panel.PerformLayout();
            this.cust_panel.ResumeLayout(false);
            this.cust_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MemLoginTab;
        private System.Windows.Forms.Button CustLoginTab;
        private System.Windows.Forms.Panel mem_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID_INPUT;
        private System.Windows.Forms.TextBox PW_INPUT;
        private System.Windows.Forms.Button mem_loginButton;
        private System.Windows.Forms.Panel cust_panel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cust_loginButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;

    }
}
