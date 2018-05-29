namespace DB_Project_Cinema
{
    partial class MyPage
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
            this.MyPageChangePwButton = new System.Windows.Forms.Button();
            this.MyPageQuitMemButton = new System.Windows.Forms.Button();
            this.MyPageCheckResvButton = new System.Windows.Forms.Button();
            this.MyPageMyPointButton = new System.Windows.Forms.Button();
            this.MyPageInterestButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MyPageChangeInfoButton = new System.Windows.Forms.Button();
            this.MyPageQuitMem = new DB_Project_Cinema.MyPageQuitMem();
            this.MyPageMyPoint = new DB_Project_Cinema.MyPageMyPoint();
            this.MyPageInterest = new DB_Project_Cinema.MyPageInterest();
            this.MyPageCheckResv = new DB_Project_Cinema.MyPageCheckResv();
            this.MyPageChangePw = new DB_Project_Cinema.MyPageChangePw();
            this.MyPageChangeInfo = new DB_Project_Cinema.MyPageChangeInfo();
            this.MyPageConfirmPW = new DB_Project_Cinema.MyPageConfirmPW();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MyPageChangePwButton);
            this.panel1.Controls.Add(this.MyPageQuitMemButton);
            this.panel1.Controls.Add(this.MyPageCheckResvButton);
            this.panel1.Controls.Add(this.MyPageMyPointButton);
            this.panel1.Controls.Add(this.MyPageInterestButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.MyPageChangeInfoButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 622);
            this.panel1.TabIndex = 0;
            // 
            // MyPageChangePwButton
            // 
            this.MyPageChangePwButton.FlatAppearance.BorderSize = 0;
            this.MyPageChangePwButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPageChangePwButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyPageChangePwButton.Location = new System.Drawing.Point(178, 272);
            this.MyPageChangePwButton.Name = "MyPageChangePwButton";
            this.MyPageChangePwButton.Size = new System.Drawing.Size(157, 40);
            this.MyPageChangePwButton.TabIndex = 16;
            this.MyPageChangePwButton.Text = "- 비밀번호 변경";
            this.MyPageChangePwButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyPageChangePwButton.UseVisualStyleBackColor = true;
            this.MyPageChangePwButton.Click += new System.EventHandler(this.MyPageChangePwButton_Click);
            // 
            // MyPageQuitMemButton
            // 
            this.MyPageQuitMemButton.FlatAppearance.BorderSize = 0;
            this.MyPageQuitMemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPageQuitMemButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyPageQuitMemButton.Location = new System.Drawing.Point(178, 318);
            this.MyPageQuitMemButton.Name = "MyPageQuitMemButton";
            this.MyPageQuitMemButton.Size = new System.Drawing.Size(157, 40);
            this.MyPageQuitMemButton.TabIndex = 17;
            this.MyPageQuitMemButton.Text = "- 회원탈퇴";
            this.MyPageQuitMemButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyPageQuitMemButton.UseVisualStyleBackColor = true;
            this.MyPageQuitMemButton.Click += new System.EventHandler(this.MyPageQuitMemButton_Click);
            // 
            // MyPageCheckResvButton
            // 
            this.MyPageCheckResvButton.FlatAppearance.BorderSize = 0;
            this.MyPageCheckResvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPageCheckResvButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyPageCheckResvButton.Location = new System.Drawing.Point(178, 410);
            this.MyPageCheckResvButton.Name = "MyPageCheckResvButton";
            this.MyPageCheckResvButton.Size = new System.Drawing.Size(157, 40);
            this.MyPageCheckResvButton.TabIndex = 18;
            this.MyPageCheckResvButton.Text = "- 예매내역 확인";
            this.MyPageCheckResvButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyPageCheckResvButton.UseVisualStyleBackColor = true;
            this.MyPageCheckResvButton.Click += new System.EventHandler(this.MyPageCheckResvButton_Click);
            // 
            // MyPageMyPointButton
            // 
            this.MyPageMyPointButton.FlatAppearance.BorderSize = 0;
            this.MyPageMyPointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPageMyPointButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyPageMyPointButton.Location = new System.Drawing.Point(178, 551);
            this.MyPageMyPointButton.Name = "MyPageMyPointButton";
            this.MyPageMyPointButton.Size = new System.Drawing.Size(157, 40);
            this.MyPageMyPointButton.TabIndex = 19;
            this.MyPageMyPointButton.Text = "- 포인트 조회";
            this.MyPageMyPointButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyPageMyPointButton.UseVisualStyleBackColor = true;
            this.MyPageMyPointButton.Click += new System.EventHandler(this.MyPageMyPointButton_Click);
            // 
            // MyPageInterestButton
            // 
            this.MyPageInterestButton.FlatAppearance.BorderSize = 0;
            this.MyPageInterestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPageInterestButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyPageInterestButton.Location = new System.Drawing.Point(178, 456);
            this.MyPageInterestButton.Name = "MyPageInterestButton";
            this.MyPageInterestButton.Size = new System.Drawing.Size(157, 40);
            this.MyPageInterestButton.TabIndex = 20;
            this.MyPageInterestButton.Text = "- 관심내역 확인";
            this.MyPageInterestButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyPageInterestButton.UseVisualStyleBackColor = true;
            this.MyPageInterestButton.Click += new System.EventHandler(this.MyPageInterestButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Wheat;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(118, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 40);
            this.label3.TabIndex = 21;
            this.label3.Text = "회원정보";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Wheat;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(118, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 40);
            this.label4.TabIndex = 22;
            this.label4.Text = "예매내역";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Wheat;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(118, 508);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 40);
            this.label5.TabIndex = 23;
            this.label5.Text = "포인트";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MyPageChangeInfoButton
            // 
            this.MyPageChangeInfoButton.FlatAppearance.BorderSize = 0;
            this.MyPageChangeInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPageChangeInfoButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyPageChangeInfoButton.Location = new System.Drawing.Point(178, 226);
            this.MyPageChangeInfoButton.Name = "MyPageChangeInfoButton";
            this.MyPageChangeInfoButton.Size = new System.Drawing.Size(157, 40);
            this.MyPageChangeInfoButton.TabIndex = 24;
            this.MyPageChangeInfoButton.Text = "- 개인정보 수정";
            this.MyPageChangeInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyPageChangeInfoButton.UseVisualStyleBackColor = true;
            this.MyPageChangeInfoButton.Click += new System.EventHandler(this.MyPageChangeInfoButton_Click);
            // 
            // MyPageQuitMem
            // 
            this.MyPageQuitMem.BackColor = System.Drawing.Color.White;
            this.MyPageQuitMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyPageQuitMem.Location = new System.Drawing.Point(360, 0);
            this.MyPageQuitMem.Name = "MyPageQuitMem";
            this.MyPageQuitMem.Size = new System.Drawing.Size(769, 622);
            this.MyPageQuitMem.TabIndex = 7;
            // 
            // MyPageMyPoint
            // 
            this.MyPageMyPoint.BackColor = System.Drawing.Color.White;
            this.MyPageMyPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyPageMyPoint.Location = new System.Drawing.Point(360, 0);
            this.MyPageMyPoint.Margin = new System.Windows.Forms.Padding(2);
            this.MyPageMyPoint.Name = "MyPageMyPoint";
            this.MyPageMyPoint.Size = new System.Drawing.Size(769, 622);
            this.MyPageMyPoint.TabIndex = 6;
            // 
            // MyPageInterest
            // 
            this.MyPageInterest.BackColor = System.Drawing.Color.White;
            this.MyPageInterest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyPageInterest.Location = new System.Drawing.Point(360, 0);
            this.MyPageInterest.Name = "MyPageInterest";
            this.MyPageInterest.Size = new System.Drawing.Size(769, 622);
            this.MyPageInterest.TabIndex = 5;
            // 
            // MyPageCheckResv
            // 
            this.MyPageCheckResv.BackColor = System.Drawing.Color.White;
            this.MyPageCheckResv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyPageCheckResv.Location = new System.Drawing.Point(360, 0);
            this.MyPageCheckResv.Name = "MyPageCheckResv";
            this.MyPageCheckResv.Size = new System.Drawing.Size(769, 622);
            this.MyPageCheckResv.TabIndex = 4;
            // 
            // MyPageChangePw
            // 
            this.MyPageChangePw.BackColor = System.Drawing.Color.White;
            this.MyPageChangePw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyPageChangePw.Location = new System.Drawing.Point(360, 0);
            this.MyPageChangePw.Margin = new System.Windows.Forms.Padding(2);
            this.MyPageChangePw.Name = "MyPageChangePw";
            this.MyPageChangePw.Size = new System.Drawing.Size(769, 622);
            this.MyPageChangePw.TabIndex = 3;
            // 
            // MyPageChangeInfo
            // 
            this.MyPageChangeInfo.BackColor = System.Drawing.Color.White;
            this.MyPageChangeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyPageChangeInfo.Location = new System.Drawing.Point(360, 0);
            this.MyPageChangeInfo.Margin = new System.Windows.Forms.Padding(2);
            this.MyPageChangeInfo.Name = "MyPageChangeInfo";
            this.MyPageChangeInfo.Size = new System.Drawing.Size(769, 622);
            this.MyPageChangeInfo.TabIndex = 2;
            // 
            // MyPageConfirmPW
            // 
            this.MyPageConfirmPW.BackColor = System.Drawing.Color.White;
            this.MyPageConfirmPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyPageConfirmPW.Location = new System.Drawing.Point(360, 0);
            this.MyPageConfirmPW.Name = "MyPageConfirmPW";
            this.MyPageConfirmPW.Size = new System.Drawing.Size(769, 622);
            this.MyPageConfirmPW.TabIndex = 1;
            // 
            // MyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MyPageQuitMem);
            this.Controls.Add(this.MyPageMyPoint);
            this.Controls.Add(this.MyPageInterest);
            this.Controls.Add(this.MyPageCheckResv);
            this.Controls.Add(this.MyPageChangePw);
            this.Controls.Add(this.MyPageChangeInfo);
            this.Controls.Add(this.MyPageConfirmPW);
            this.Controls.Add(this.panel1);
            this.Name = "MyPage";
            this.Size = new System.Drawing.Size(1129, 622);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MyPageChangePwButton;
        private System.Windows.Forms.Button MyPageQuitMemButton;
        private System.Windows.Forms.Button MyPageCheckResvButton;
        private System.Windows.Forms.Button MyPageMyPointButton;
        private System.Windows.Forms.Button MyPageInterestButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MyPageChangeInfoButton;
        private MyPageConfirmPW MyPageConfirmPW;
        private MyPageChangeInfo MyPageChangeInfo;
        private MyPageChangePw MyPageChangePw;
        private MyPageCheckResv MyPageCheckResv;
        private MyPageInterest MyPageInterest;
        private MyPageMyPoint MyPageMyPoint;
        private MyPageQuitMem MyPageQuitMem;

    }
}
