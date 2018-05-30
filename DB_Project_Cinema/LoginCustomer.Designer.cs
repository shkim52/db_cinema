namespace DB_Project_Cinema
{
    partial class LoginCustomer
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
            this.CustNameTextbox = new System.Windows.Forms.TextBox();
            this.CustResidentTextbox = new System.Windows.Forms.TextBox();
            this.CustHPNumTextbox = new System.Windows.Forms.TextBox();
            this.CustPWTextbox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(390, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "이름:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustNameTextbox
            // 
            this.CustNameTextbox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CustNameTextbox.Location = new System.Drawing.Point(483, 26);
            this.CustNameTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.CustNameTextbox.Name = "CustNameTextbox";
            this.CustNameTextbox.Size = new System.Drawing.Size(238, 30);
            this.CustNameTextbox.TabIndex = 17;
            // 
            // CustResidentTextbox
            // 
            this.CustResidentTextbox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CustResidentTextbox.Location = new System.Drawing.Point(483, 67);
            this.CustResidentTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.CustResidentTextbox.MaxLength = 6;
            this.CustResidentTextbox.Name = "CustResidentTextbox";
            this.CustResidentTextbox.Size = new System.Drawing.Size(238, 30);
            this.CustResidentTextbox.TabIndex = 18;
            // 
            // CustHPNumTextbox
            // 
            this.CustHPNumTextbox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CustHPNumTextbox.Location = new System.Drawing.Point(483, 109);
            this.CustHPNumTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.CustHPNumTextbox.MaxLength = 11;
            this.CustHPNumTextbox.Name = "CustHPNumTextbox";
            this.CustHPNumTextbox.Size = new System.Drawing.Size(238, 30);
            this.CustHPNumTextbox.TabIndex = 19;
            // 
            // CustPWTextbox
            // 
            this.CustPWTextbox.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CustPWTextbox.Location = new System.Drawing.Point(483, 151);
            this.CustPWTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.CustPWTextbox.Name = "CustPWTextbox";
            this.CustPWTextbox.PasswordChar = '*';
            this.CustPWTextbox.Size = new System.Drawing.Size(238, 30);
            this.CustPWTextbox.TabIndex = 20;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.LightGray;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginButton.Location = new System.Drawing.Point(762, 67);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 70);
            this.LoginButton.TabIndex = 21;
            this.LoginButton.Text = "로그인";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(350, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 33);
            this.label3.TabIndex = 22;
            this.label3.Text = "생년월일:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(350, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 33);
            this.label6.TabIndex = 23;
            this.label6.Text = "휴대폰번호:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(350, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 33);
            this.label4.TabIndex = 24;
            this.label4.Text = "비밀번호:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LoginCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustNameTextbox);
            this.Controls.Add(this.CustResidentTextbox);
            this.Controls.Add(this.CustHPNumTextbox);
            this.Controls.Add(this.CustPWTextbox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginCustomer";
            this.Size = new System.Drawing.Size(1020, 418);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustNameTextbox;
        private System.Windows.Forms.TextBox CustResidentTextbox;
        private System.Windows.Forms.TextBox CustHPNumTextbox;
        private System.Windows.Forms.TextBox CustPWTextbox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;

    }
}
