namespace DB_Project_Cinema
{
    partial class ScreenInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ScreenNM = new System.Windows.Forms.Label();
            this.ScreenIntro = new System.Windows.Forms.Label();
            this.ScreenSeatCnt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(587, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "SCREEN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(327, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "상영관";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(489, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(512, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "상영관 설명";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1007, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "좌석 수";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScreenNM
            // 
            this.ScreenNM.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScreenNM.Location = new System.Drawing.Point(350, 195);
            this.ScreenNM.Name = "ScreenNM";
            this.ScreenNM.Size = new System.Drawing.Size(89, 36);
            this.ScreenNM.TabIndex = 11;
            this.ScreenNM.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScreenIntro
            // 
            this.ScreenIntro.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScreenIntro.Location = new System.Drawing.Point(526, 195);
            this.ScreenIntro.Name = "ScreenIntro";
            this.ScreenIntro.Size = new System.Drawing.Size(444, 27);
            this.ScreenIntro.TabIndex = 12;
            this.ScreenIntro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScreenSeatCnt
            // 
            this.ScreenSeatCnt.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScreenSeatCnt.Location = new System.Drawing.Point(1050, 195);
            this.ScreenSeatCnt.Name = "ScreenSeatCnt";
            this.ScreenSeatCnt.Size = new System.Drawing.Size(98, 34);
            this.ScreenSeatCnt.TabIndex = 13;
            this.ScreenSeatCnt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ScreenInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ScreenSeatCnt);
            this.Controls.Add(this.ScreenIntro);
            this.Controls.Add(this.ScreenNM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Name = "ScreenInfo";
            this.Size = new System.Drawing.Size(1326, 514);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ScreenNM;
        private System.Windows.Forms.Label ScreenIntro;
        private System.Windows.Forms.Label ScreenSeatCnt;

    }
}
