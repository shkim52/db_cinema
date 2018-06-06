namespace DB_Project_Cinema
{
    partial class MyPageChangePw
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
            this.PWD_INPUT = new System.Windows.Forms.TextBox();
            this.NEW_PWD_INPUT = new System.Windows.Forms.TextBox();
            this.NEW_PWD2_INPUT = new System.Windows.Forms.TextBox();
            this.ChangePWButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(155, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(155, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "New Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(155, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirm New Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PWD_INPUT
            // 
            this.PWD_INPUT.Location = new System.Drawing.Point(356, 219);
            this.PWD_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.PWD_INPUT.Name = "PWD_INPUT";
            this.PWD_INPUT.PasswordChar = '*';
            this.PWD_INPUT.Size = new System.Drawing.Size(253, 25);
            this.PWD_INPUT.TabIndex = 18;
            // 
            // NEW_PWD_INPUT
            // 
            this.NEW_PWD_INPUT.Location = new System.Drawing.Point(356, 255);
            this.NEW_PWD_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.NEW_PWD_INPUT.Name = "NEW_PWD_INPUT";
            this.NEW_PWD_INPUT.PasswordChar = '*';
            this.NEW_PWD_INPUT.Size = new System.Drawing.Size(253, 25);
            this.NEW_PWD_INPUT.TabIndex = 19;
            // 
            // NEW_PWD2_INPUT
            // 
            this.NEW_PWD2_INPUT.Location = new System.Drawing.Point(356, 291);
            this.NEW_PWD2_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.NEW_PWD2_INPUT.Name = "NEW_PWD2_INPUT";
            this.NEW_PWD2_INPUT.PasswordChar = '*';
            this.NEW_PWD2_INPUT.Size = new System.Drawing.Size(253, 25);
            this.NEW_PWD2_INPUT.TabIndex = 20;
            // 
            // ChangePWButton
            // 
            this.ChangePWButton.BackColor = System.Drawing.Color.LightGray;
            this.ChangePWButton.FlatAppearance.BorderSize = 0;
            this.ChangePWButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePWButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChangePWButton.Location = new System.Drawing.Point(356, 367);
            this.ChangePWButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePWButton.Name = "ChangePWButton";
            this.ChangePWButton.Size = new System.Drawing.Size(115, 41);
            this.ChangePWButton.TabIndex = 21;
            this.ChangePWButton.Text = "비밀번호 변경";
            this.ChangePWButton.UseVisualStyleBackColor = false;
            this.ChangePWButton.Click += new System.EventHandler(this.ChangePWButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(142, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 43);
            this.label1.TabIndex = 22;
            this.label1.Text = "MyPage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyPageChangePw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PWD_INPUT);
            this.Controls.Add(this.NEW_PWD_INPUT);
            this.Controls.Add(this.NEW_PWD2_INPUT);
            this.Controls.Add(this.ChangePWButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MyPageChangePw";
            this.Size = new System.Drawing.Size(842, 485);
            this.Load += new System.EventHandler(this.MyPageChangePw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PWD_INPUT;
        private System.Windows.Forms.TextBox NEW_PWD_INPUT;
        private System.Windows.Forms.TextBox NEW_PWD2_INPUT;
        private System.Windows.Forms.Button ChangePWButton;
        private System.Windows.Forms.Label label1;

    }
}
