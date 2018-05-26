namespace DB_Project_Cinema
{
    partial class ChooseSeat
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ChooseNumberList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SCR_NM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SEAT_CNT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TOT_SEAT_CNT = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(452, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(525, 49);
            this.label6.TabIndex = 7;
            this.label6.Text = "TICKET";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(331, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "인원:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChooseNumberList
            // 
            this.ChooseNumberList.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChooseNumberList.FormattingEnabled = true;
            this.ChooseNumberList.ItemHeight = 28;
            this.ChooseNumberList.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ChooseNumberList.Location = new System.Drawing.Point(399, 144);
            this.ChooseNumberList.Margin = new System.Windows.Forms.Padding(2);
            this.ChooseNumberList.Name = "ChooseNumberList";
            this.ChooseNumberList.Size = new System.Drawing.Size(82, 32);
            this.ChooseNumberList.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(692, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "상영관 : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SCR_NM
            // 
            this.SCR_NM.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SCR_NM.Location = new System.Drawing.Point(796, 144);
            this.SCR_NM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SCR_NM.Name = "SCR_NM";
            this.SCR_NM.Size = new System.Drawing.Size(61, 31);
            this.SCR_NM.TabIndex = 14;
            this.SCR_NM.Text = "1관";
            this.SCR_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(879, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "남은 좌석 : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SEAT_CNT
            // 
            this.SEAT_CNT.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SEAT_CNT.Location = new System.Drawing.Point(999, 144);
            this.SEAT_CNT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SEAT_CNT.Name = "SEAT_CNT";
            this.SEAT_CNT.Size = new System.Drawing.Size(21, 31);
            this.SEAT_CNT.TabIndex = 16;
            this.SEAT_CNT.Text = "0";
            this.SEAT_CNT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(1043, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "/";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TOT_SEAT_CNT
            // 
            this.TOT_SEAT_CNT.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TOT_SEAT_CNT.Location = new System.Drawing.Point(1060, 144);
            this.TOT_SEAT_CNT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TOT_SEAT_CNT.Name = "TOT_SEAT_CNT";
            this.TOT_SEAT_CNT.Size = new System.Drawing.Size(51, 31);
            this.TOT_SEAT_CNT.TabIndex = 18;
            this.TOT_SEAT_CNT.Text = "400";
            this.TOT_SEAT_CNT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(329, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 305);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(329, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(805, 55);
            this.label2.TabIndex = 19;
            this.label2.Text = "SCREEN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(1027, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "/";
            // 
            // ChooseSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TOT_SEAT_CNT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SEAT_CNT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SCR_NM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseNumberList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChooseSeat";
            this.Size = new System.Drawing.Size(1303, 634);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ChooseNumberList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SCR_NM;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SEAT_CNT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TOT_SEAT_CNT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;

    }
}
