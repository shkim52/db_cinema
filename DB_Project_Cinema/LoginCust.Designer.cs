namespace DB_Project_Cinema
{
    partial class LoginCust
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cust_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_INPUT = new System.Windows.Forms.TextBox();
            this.PW_INPUT = new System.Windows.Forms.TextBox();
            this.mem_loginButton = new System.Windows.Forms.Button();
            this.cust_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cust_panel
            // 
            this.cust_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cust_panel.Controls.Add(this.label4);
            this.cust_panel.Controls.Add(this.label2);
            this.cust_panel.Controls.Add(this.label3);
            this.cust_panel.Controls.Add(this.ID_INPUT);
            this.cust_panel.Controls.Add(this.PW_INPUT);
            this.cust_panel.Controls.Add(this.mem_loginButton);
            this.cust_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cust_panel.Location = new System.Drawing.Point(0, 0);
            this.cust_panel.Name = "cust_panel";
            this.cust_panel.Size = new System.Drawing.Size(1154, 552);
            this.cust_panel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gulim", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(525, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(548, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "임시ID와 비밀번호를 잊어버렸을 경우 현장 확인만 가능합니다.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(560, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "임시 ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(572, 228);
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
            this.ID_INPUT.Location = new System.Drawing.Point(681, 191);
            this.ID_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.ID_INPUT.Name = "ID_INPUT";
            this.ID_INPUT.Size = new System.Drawing.Size(210, 30);
            this.ID_INPUT.TabIndex = 12;
            // 
            // PW_INPUT
            // 
            this.PW_INPUT.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PW_INPUT.Location = new System.Drawing.Point(681, 231);
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
            this.mem_loginButton.Location = new System.Drawing.Point(917, 191);
            this.mem_loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.mem_loginButton.Name = "mem_loginButton";
            this.mem_loginButton.Size = new System.Drawing.Size(71, 68);
            this.mem_loginButton.TabIndex = 14;
            this.mem_loginButton.Text = "로그인";
            this.mem_loginButton.UseVisualStyleBackColor = false;
            this.mem_loginButton.Click += new System.EventHandler(this.mem_loginButton_Click);
            // 
            // LoginCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cust_panel);
            this.Name = "LoginCust";
            this.Size = new System.Drawing.Size(1154, 552);
            this.Load += new System.EventHandler(this.LoginCust_Load);
            this.cust_panel.ResumeLayout(false);
            this.cust_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cust_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID_INPUT;
        private System.Windows.Forms.TextBox PW_INPUT;
        private System.Windows.Forms.Button mem_loginButton;
    }
}
