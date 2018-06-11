namespace DB_Project_Cinema
{
    partial class MyPageChangeInfo
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
            this.NAME = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.SID = new System.Windows.Forms.TextBox();
            this.TELNO = new System.Windows.Forms.TextBox();
            this.ChangeInfoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(168, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "User Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(168, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(168, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "E-mail:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(168, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "생년월일:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(168, 333);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "연락처:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(318, 190);
            this.NAME.Margin = new System.Windows.Forms.Padding(2);
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Size = new System.Drawing.Size(252, 25);
            this.NAME.TabIndex = 21;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(318, 226);
            this.ID.Margin = new System.Windows.Forms.Padding(2);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(252, 25);
            this.ID.TabIndex = 22;
            // 
            // EMAIL
            // 
            this.EMAIL.Location = new System.Drawing.Point(318, 262);
            this.EMAIL.Margin = new System.Windows.Forms.Padding(2);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(252, 25);
            this.EMAIL.TabIndex = 23;
            // 
            // SID
            // 
            this.SID.Location = new System.Drawing.Point(318, 297);
            this.SID.Margin = new System.Windows.Forms.Padding(2);
            this.SID.Name = "SID";
            this.SID.PasswordChar = '*';
            this.SID.ReadOnly = true;
            this.SID.Size = new System.Drawing.Size(131, 25);
            this.SID.TabIndex = 24;
            this.SID.TabStop = false;
            // 
            // TELNO
            // 
            this.TELNO.Location = new System.Drawing.Point(318, 333);
            this.TELNO.Margin = new System.Windows.Forms.Padding(2);
            this.TELNO.Name = "TELNO";
            this.TELNO.Size = new System.Drawing.Size(252, 25);
            this.TELNO.TabIndex = 25;
            // 
            // ChangeInfoButton
            // 
            this.ChangeInfoButton.BackColor = System.Drawing.Color.LightGray;
            this.ChangeInfoButton.FlatAppearance.BorderSize = 0;
            this.ChangeInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeInfoButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChangeInfoButton.Location = new System.Drawing.Point(318, 390);
            this.ChangeInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeInfoButton.Name = "ChangeInfoButton";
            this.ChangeInfoButton.Size = new System.Drawing.Size(131, 41);
            this.ChangeInfoButton.TabIndex = 27;
            this.ChangeInfoButton.Text = "변경사항 저장";
            this.ChangeInfoButton.UseVisualStyleBackColor = false;
            this.ChangeInfoButton.Click += new System.EventHandler(this.ChangeInfoButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(282, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 39);
            this.label1.TabIndex = 28;
            this.label1.Text = "MyPage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gulim", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(454, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 29;
            this.label7.Text = "-   *******";
            // 
            // MyPageChangeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.SID);
            this.Controls.Add(this.TELNO);
            this.Controls.Add(this.ChangeInfoButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MyPageChangeInfo";
            this.Size = new System.Drawing.Size(876, 535);
            this.Load += new System.EventHandler(this.MyPageChangeInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox EMAIL;
        private System.Windows.Forms.TextBox SID;
        private System.Windows.Forms.TextBox TELNO;
        private System.Windows.Forms.Button ChangeInfoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;

    }
}
