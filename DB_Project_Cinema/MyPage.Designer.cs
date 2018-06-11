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
            this.SubPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SubPanel.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 518);
            this.panel1.TabIndex = 0;
            // 
            // MyPageChangePwButton
            // 
            this.MyPageChangePwButton.FlatAppearance.BorderSize = 0;
            this.MyPageChangePwButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPageChangePwButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyPageChangePwButton.Location = new System.Drawing.Point(220, 229);
            this.MyPageChangePwButton.Margin = new System.Windows.Forms.Padding(2);
            this.MyPageChangePwButton.Name = "MyPageChangePwButton";
            this.MyPageChangePwButton.Size = new System.Drawing.Size(126, 33);
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
            this.MyPageQuitMemButton.Location = new System.Drawing.Point(220, 267);
            this.MyPageQuitMemButton.Margin = new System.Windows.Forms.Padding(2);
            this.MyPageQuitMemButton.Name = "MyPageQuitMemButton";
            this.MyPageQuitMemButton.Size = new System.Drawing.Size(126, 33);
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
            this.MyPageCheckResvButton.Location = new System.Drawing.Point(220, 344);
            this.MyPageCheckResvButton.Margin = new System.Windows.Forms.Padding(2);
            this.MyPageCheckResvButton.Name = "MyPageCheckResvButton";
            this.MyPageCheckResvButton.Size = new System.Drawing.Size(126, 33);
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
            this.MyPageMyPointButton.Location = new System.Drawing.Point(220, 461);
            this.MyPageMyPointButton.Margin = new System.Windows.Forms.Padding(2);
            this.MyPageMyPointButton.Name = "MyPageMyPointButton";
            this.MyPageMyPointButton.Size = new System.Drawing.Size(126, 33);
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
            this.MyPageInterestButton.Location = new System.Drawing.Point(220, 382);
            this.MyPageInterestButton.Margin = new System.Windows.Forms.Padding(2);
            this.MyPageInterestButton.Name = "MyPageInterestButton";
            this.MyPageInterestButton.Size = new System.Drawing.Size(126, 33);
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
            this.label3.Location = new System.Drawing.Point(172, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 33);
            this.label3.TabIndex = 21;
            this.label3.Text = "회원정보";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Wheat;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(172, 308);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 33);
            this.label4.TabIndex = 22;
            this.label4.Text = "예매내역";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Wheat;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(172, 425);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 33);
            this.label5.TabIndex = 23;
            this.label5.Text = "포인트";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MyPageChangeInfoButton
            // 
            this.MyPageChangeInfoButton.FlatAppearance.BorderSize = 0;
            this.MyPageChangeInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPageChangeInfoButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyPageChangeInfoButton.Location = new System.Drawing.Point(220, 190);
            this.MyPageChangeInfoButton.Margin = new System.Windows.Forms.Padding(2);
            this.MyPageChangeInfoButton.Name = "MyPageChangeInfoButton";
            this.MyPageChangeInfoButton.Size = new System.Drawing.Size(126, 33);
            this.MyPageChangeInfoButton.TabIndex = 24;
            this.MyPageChangeInfoButton.Text = "- 개인정보 수정";
            this.MyPageChangeInfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyPageChangeInfoButton.UseVisualStyleBackColor = true;
            this.MyPageChangeInfoButton.Click += new System.EventHandler(this.MyPageChangeInfoButton_Click);
            // 
            // SubPanel
            // 
            this.SubPanel.Controls.Add(this.label1);
            this.SubPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubPanel.Location = new System.Drawing.Point(382, 0);
            this.SubPanel.Name = "SubPanel";
            this.SubPanel.Size = new System.Drawing.Size(521, 518);
            this.SubPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(281, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "어서오세요.";
            // 
            // MyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SubPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MyPage";
            this.Size = new System.Drawing.Size(903, 518);
            this.panel1.ResumeLayout(false);
            this.SubPanel.ResumeLayout(false);
            this.SubPanel.PerformLayout();
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
        private System.Windows.Forms.Panel SubPanel;
        private System.Windows.Forms.Label label1;

    }
}
