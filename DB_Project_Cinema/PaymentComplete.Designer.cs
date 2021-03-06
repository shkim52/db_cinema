﻿namespace DB_Project_Cinema
{
    partial class PaymentComplete
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TicketNo = new System.Windows.Forms.Label();
            this.MovieName = new System.Windows.Forms.Label();
            this.ScheDate = new System.Windows.Forms.Label();
            this.ScheStarTime = new System.Windows.Forms.Label();
            this.ScheEndTime = new System.Windows.Forms.Label();
            this.ScrName = new System.Windows.Forms.Label();
            this.SeatNo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PaymentPrice = new System.Windows.Forms.Label();
            this.MoviePoster = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(636, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "예매가 완료되었습니다!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("NanumGothicExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(482, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "티켓 번호:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("NanumGothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(478, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "상영 날짜, 시간:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("NanumGothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(459, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "상영관, 좌석 번호:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TicketNo
            // 
            this.TicketNo.Font = new System.Drawing.Font("NanumGothicExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TicketNo.ForeColor = System.Drawing.Color.DarkRed;
            this.TicketNo.Location = new System.Drawing.Point(631, 166);
            this.TicketNo.Name = "TicketNo";
            this.TicketNo.Size = new System.Drawing.Size(327, 36);
            this.TicketNo.TabIndex = 5;
            this.TicketNo.Text = "-";
            this.TicketNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MovieName
            // 
            this.MovieName.Font = new System.Drawing.Font("NanumGothicExtraBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieName.Location = new System.Drawing.Point(274, 64);
            this.MovieName.Name = "MovieName";
            this.MovieName.Size = new System.Drawing.Size(351, 36);
            this.MovieName.TabIndex = 6;
            this.MovieName.Text = "데드풀";
            this.MovieName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScheDate
            // 
            this.ScheDate.Location = new System.Drawing.Point(626, 227);
            this.ScheDate.Name = "ScheDate";
            this.ScheDate.Size = new System.Drawing.Size(105, 36);
            this.ScheDate.TabIndex = 7;
            this.ScheDate.Text = "-";
            this.ScheDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScheStarTime
            // 
            this.ScheStarTime.Location = new System.Drawing.Point(771, 227);
            this.ScheStarTime.Name = "ScheStarTime";
            this.ScheStarTime.Size = new System.Drawing.Size(100, 36);
            this.ScheStarTime.TabIndex = 8;
            this.ScheStarTime.Text = "-";
            this.ScheStarTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScheEndTime
            // 
            this.ScheEndTime.Location = new System.Drawing.Point(899, 227);
            this.ScheEndTime.Name = "ScheEndTime";
            this.ScheEndTime.Size = new System.Drawing.Size(111, 36);
            this.ScheEndTime.TabIndex = 9;
            this.ScheEndTime.Text = "-";
            this.ScheEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScrName
            // 
            this.ScrName.Location = new System.Drawing.Point(628, 263);
            this.ScrName.Name = "ScrName";
            this.ScrName.Size = new System.Drawing.Size(96, 36);
            this.ScrName.TabIndex = 10;
            this.ScrName.Text = "-";
            this.ScrName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SeatNo
            // 
            this.SeatNo.Location = new System.Drawing.Point(738, 263);
            this.SeatNo.Name = "SeatNo";
            this.SeatNo.Size = new System.Drawing.Size(398, 36);
            this.SeatNo.TabIndex = 11;
            this.SeatNo.Text = "-";
            this.SeatNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("NanumGothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(513, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 36);
            this.label13.TabIndex = 12;
            this.label13.Text = "결제 금액:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PaymentPrice
            // 
            this.PaymentPrice.Location = new System.Drawing.Point(628, 299);
            this.PaymentPrice.Name = "PaymentPrice";
            this.PaymentPrice.Size = new System.Drawing.Size(154, 36);
            this.PaymentPrice.TabIndex = 13;
            this.PaymentPrice.Text = "-";
            this.PaymentPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MoviePoster
            // 
            this.MoviePoster.Location = new System.Drawing.Point(243, 135);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(221, 252);
            this.MoviePoster.TabIndex = 14;
            this.MoviePoster.TabStop = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(860, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = "~";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(734, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 36);
            this.label7.TabIndex = 16;
            this.label7.Text = ",";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(713, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 36);
            this.label8.TabIndex = 17;
            this.label8.Text = ",";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaymentComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MoviePoster);
            this.Controls.Add(this.PaymentPrice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SeatNo);
            this.Controls.Add(this.ScrName);
            this.Controls.Add(this.ScheEndTime);
            this.Controls.Add(this.ScheStarTime);
            this.Controls.Add(this.ScheDate);
            this.Controls.Add(this.MovieName);
            this.Controls.Add(this.TicketNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PaymentComplete";
            this.Size = new System.Drawing.Size(1224, 858);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TicketNo;
        private System.Windows.Forms.Label MovieName;
        private System.Windows.Forms.Label ScheDate;
        private System.Windows.Forms.Label ScheStarTime;
        private System.Windows.Forms.Label ScheEndTime;
        private System.Windows.Forms.Label ScrName;
        private System.Windows.Forms.Label SeatNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label PaymentPrice;
        private System.Windows.Forms.PictureBox MoviePoster;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
