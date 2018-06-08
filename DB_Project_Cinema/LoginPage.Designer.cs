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
            this.mem_panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_INPUT = new System.Windows.Forms.TextBox();
            this.PW_INPUT = new System.Windows.Forms.TextBox();
            this.mem_loginButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.mem_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
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
            this.label2.Location = new System.Drawing.Point(409, 37);
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
            this.label3.Location = new System.Drawing.Point(381, 77);
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
            this.ID_INPUT.Location = new System.Drawing.Point(490, 40);
            this.ID_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.ID_INPUT.Name = "ID_INPUT";
            this.ID_INPUT.Size = new System.Drawing.Size(210, 30);
            this.ID_INPUT.TabIndex = 12;
            // 
            // PW_INPUT
            // 
            this.PW_INPUT.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PW_INPUT.Location = new System.Drawing.Point(490, 80);
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
            this.mem_loginButton.Location = new System.Drawing.Point(726, 40);
            this.mem_loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.mem_loginButton.Name = "mem_loginButton";
            this.mem_loginButton.Size = new System.Drawing.Size(71, 68);
            this.mem_loginButton.TabIndex = 14;
            this.mem_loginButton.Text = "로그인";
            this.mem_loginButton.UseVisualStyleBackColor = false;
            this.mem_loginButton.Click += new System.EventHandler(this.mem_loginButton_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mem_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID_INPUT;
        private System.Windows.Forms.TextBox PW_INPUT;
        private System.Windows.Forms.Button mem_loginButton;

    }
}
