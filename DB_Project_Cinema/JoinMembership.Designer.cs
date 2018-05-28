namespace DB_Project_Cinema
{
    partial class JoinMembership
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NAME_INPUT = new System.Windows.Forms.TextBox();
            this.ID_INPUT = new System.Windows.Forms.TextBox();
            this.EMAIL_INPUT = new System.Windows.Forms.TextBox();
            this.SID_INPUT = new System.Windows.Forms.TextBox();
            this.TELNO_INPUT = new System.Windows.Forms.TextBox();
            this.SEX_INPUT = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PWD_INPUT = new System.Windows.Forms.TextBox();
            this.PWD2_INPUT = new System.Windows.Forms.TextBox();
            this.DoubleCheckButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ID_CHECK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(258, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "User Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(258, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 33);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(258, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "E-mail:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(258, 325);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "주민등록번호:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(258, 361);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "연락처:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(258, 390);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 58);
            this.label7.TabIndex = 26;
            this.label7.Text = "성별:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NAME_INPUT
            // 
            this.NAME_INPUT.Location = new System.Drawing.Point(375, 144);
            this.NAME_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.NAME_INPUT.Name = "NAME_INPUT";
            this.NAME_INPUT.Size = new System.Drawing.Size(224, 25);
            this.NAME_INPUT.TabIndex = 27;
            // 
            // ID_INPUT
            // 
            this.ID_INPUT.Location = new System.Drawing.Point(375, 180);
            this.ID_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.ID_INPUT.Name = "ID_INPUT";
            this.ID_INPUT.Size = new System.Drawing.Size(224, 25);
            this.ID_INPUT.TabIndex = 28;
            // 
            // EMAIL_INPUT
            // 
            this.EMAIL_INPUT.Location = new System.Drawing.Point(375, 292);
            this.EMAIL_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.EMAIL_INPUT.Name = "EMAIL_INPUT";
            this.EMAIL_INPUT.Size = new System.Drawing.Size(224, 25);
            this.EMAIL_INPUT.TabIndex = 29;
            // 
            // SID_INPUT
            // 
            this.SID_INPUT.Location = new System.Drawing.Point(375, 327);
            this.SID_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.SID_INPUT.Name = "SID_INPUT";
            this.SID_INPUT.PasswordChar = '*';
            this.SID_INPUT.Size = new System.Drawing.Size(224, 25);
            this.SID_INPUT.TabIndex = 30;
            // 
            // TELNO_INPUT
            // 
            this.TELNO_INPUT.Location = new System.Drawing.Point(375, 363);
            this.TELNO_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.TELNO_INPUT.Name = "TELNO_INPUT";
            this.TELNO_INPUT.Size = new System.Drawing.Size(224, 25);
            this.TELNO_INPUT.TabIndex = 31;
            // 
            // SEX_INPUT
            // 
            this.SEX_INPUT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SEX_INPUT.FormattingEnabled = true;
            this.SEX_INPUT.Items.AddRange(new object[] {
            "여자",
            "남자"});
            this.SEX_INPUT.Location = new System.Drawing.Point(375, 397);
            this.SEX_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.SEX_INPUT.Name = "SEX_INPUT";
            this.SEX_INPUT.Size = new System.Drawing.Size(223, 40);
            this.SEX_INPUT.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(254, 217);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 29);
            this.label8.TabIndex = 33;
            this.label8.Text = "Password:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(220, 253);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 29);
            this.label9.TabIndex = 34;
            this.label9.Text = "Confirm Password:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PWD_INPUT
            // 
            this.PWD_INPUT.Location = new System.Drawing.Point(375, 220);
            this.PWD_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.PWD_INPUT.Name = "PWD_INPUT";
            this.PWD_INPUT.PasswordChar = '*';
            this.PWD_INPUT.Size = new System.Drawing.Size(224, 25);
            this.PWD_INPUT.TabIndex = 35;
            // 
            // PWD2_INPUT
            // 
            this.PWD2_INPUT.Location = new System.Drawing.Point(375, 256);
            this.PWD2_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.PWD2_INPUT.Name = "PWD2_INPUT";
            this.PWD2_INPUT.PasswordChar = '*';
            this.PWD2_INPUT.Size = new System.Drawing.Size(224, 25);
            this.PWD2_INPUT.TabIndex = 36;
            // 
            // DoubleCheckButton
            // 
            this.DoubleCheckButton.BackColor = System.Drawing.Color.LightGray;
            this.DoubleCheckButton.FlatAppearance.BorderSize = 0;
            this.DoubleCheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoubleCheckButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DoubleCheckButton.Location = new System.Drawing.Point(612, 180);
            this.DoubleCheckButton.Margin = new System.Windows.Forms.Padding(2);
            this.DoubleCheckButton.Name = "DoubleCheckButton";
            this.DoubleCheckButton.Size = new System.Drawing.Size(75, 28);
            this.DoubleCheckButton.TabIndex = 37;
            this.DoubleCheckButton.Text = "중복확인";
            this.DoubleCheckButton.UseVisualStyleBackColor = false;
            this.DoubleCheckButton.Click += new System.EventHandler(this.DoubleCheckButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(502, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 45);
            this.label1.TabIndex = 38;
            this.label1.Text = "Join Membership";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.LightGray;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SubmitButton.Location = new System.Drawing.Point(480, 460);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(118, 42);
            this.SubmitButton.TabIndex = 39;
            this.SubmitButton.Text = "회원가입";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ID_CHECK
            // 
            this.ID_CHECK.AutoSize = true;
            this.ID_CHECK.Location = new System.Drawing.Point(712, 187);
            this.ID_CHECK.Name = "ID_CHECK";
            this.ID_CHECK.Size = new System.Drawing.Size(162, 15);
            this.ID_CHECK.TabIndex = 41;
            this.ID_CHECK.Text = "중복확인을 눌러주세요";
            // 
            // JoinMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ID_CHECK);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NAME_INPUT);
            this.Controls.Add(this.ID_INPUT);
            this.Controls.Add(this.EMAIL_INPUT);
            this.Controls.Add(this.SID_INPUT);
            this.Controls.Add(this.TELNO_INPUT);
            this.Controls.Add(this.SEX_INPUT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PWD_INPUT);
            this.Controls.Add(this.PWD2_INPUT);
            this.Controls.Add(this.DoubleCheckButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JoinMembership";
            this.Size = new System.Drawing.Size(994, 552);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NAME_INPUT;
        private System.Windows.Forms.TextBox ID_INPUT;
        private System.Windows.Forms.TextBox EMAIL_INPUT;
        private System.Windows.Forms.TextBox SID_INPUT;
        private System.Windows.Forms.TextBox TELNO_INPUT;
        private System.Windows.Forms.CheckedListBox SEX_INPUT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PWD_INPUT;
        private System.Windows.Forms.TextBox PWD2_INPUT;
        private System.Windows.Forms.Button DoubleCheckButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label ID_CHECK;

    }
}
