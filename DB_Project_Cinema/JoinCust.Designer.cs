namespace DB_Project_Cinema
{
    partial class JoinCust
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustNameTextbox = new System.Windows.Forms.TextBox();
            this.CustResidentTextbox = new System.Windows.Forms.TextBox();
            this.CustHPNumTextbox = new System.Windows.Forms.TextBox();
            this.CustPWTextbox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(630, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 45);
            this.label1.TabIndex = 39;
            this.label1.Text = "Join Customer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(521, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 33);
            this.label2.TabIndex = 40;
            this.label2.Text = "이름:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustNameTextbox
            // 
            this.CustNameTextbox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CustNameTextbox.Location = new System.Drawing.Point(614, 151);
            this.CustNameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.CustNameTextbox.Name = "CustNameTextbox";
            this.CustNameTextbox.Size = new System.Drawing.Size(238, 30);
            this.CustNameTextbox.TabIndex = 41;
            // 
            // CustResidentTextbox
            // 
            this.CustResidentTextbox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CustResidentTextbox.Location = new System.Drawing.Point(614, 192);
            this.CustResidentTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.CustResidentTextbox.MaxLength = 6;
            this.CustResidentTextbox.Name = "CustResidentTextbox";
            this.CustResidentTextbox.Size = new System.Drawing.Size(118, 30);
            this.CustResidentTextbox.TabIndex = 42;
            this.CustResidentTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustResidentTextbox_KeyPress);
            // 
            // CustHPNumTextbox
            // 
            this.CustHPNumTextbox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CustHPNumTextbox.Location = new System.Drawing.Point(614, 234);
            this.CustHPNumTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.CustHPNumTextbox.MaxLength = 11;
            this.CustHPNumTextbox.Name = "CustHPNumTextbox";
            this.CustHPNumTextbox.Size = new System.Drawing.Size(238, 30);
            this.CustHPNumTextbox.TabIndex = 43;
            this.CustHPNumTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustHPNumTextbox_KeyPress);
            // 
            // CustPWTextbox
            // 
            this.CustPWTextbox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CustPWTextbox.Location = new System.Drawing.Point(614, 276);
            this.CustPWTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.CustPWTextbox.Name = "CustPWTextbox";
            this.CustPWTextbox.PasswordChar = '*';
            this.CustPWTextbox.Size = new System.Drawing.Size(238, 30);
            this.CustPWTextbox.TabIndex = 44;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.LightGray;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginButton.Location = new System.Drawing.Point(603, 381);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(249, 42);
            this.LoginButton.TabIndex = 45;
            this.LoginButton.Text = "가입하기";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(481, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 33);
            this.label3.TabIndex = 46;
            this.label3.Text = "생년월일:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(481, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 33);
            this.label6.TabIndex = 47;
            this.label6.Text = "휴대폰번호:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(481, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 33);
            this.label4.TabIndex = 48;
            this.label4.Text = "비밀번호:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(737, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "-  *******";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(884, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "-를 제외한 숫자만 입력하세요.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(422, 15);
            this.label8.TabIndex = 51;
            this.label8.Text = "비밀번호를 잊어버리면 홈페이지에서 예매확인이 불가합니다.";
            // 
            // JoinCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustNameTextbox);
            this.Controls.Add(this.CustResidentTextbox);
            this.Controls.Add(this.CustHPNumTextbox);
            this.Controls.Add(this.CustPWTextbox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(502, 41);
            this.Name = "JoinCust";
            this.Size = new System.Drawing.Size(1175, 552);
            this.Load += new System.EventHandler(this.JoinCust_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustNameTextbox;
        private System.Windows.Forms.TextBox CustResidentTextbox;
        private System.Windows.Forms.TextBox CustHPNumTextbox;
        private System.Windows.Forms.TextBox CustPWTextbox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}
