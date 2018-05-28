namespace DB_Project_Cinema
{
    partial class MovieDetail
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
            this.Movie_Intro = new System.Windows.Forms.Label();
            this.SetInterestButton = new System.Windows.Forms.Button();
            this.Movie_NM = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Poster = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.ReleaseDate = new System.Windows.Forms.Label();
            this.ShowTime = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.DirectorNM = new System.Windows.Forms.Label();
            this.ActorNM = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.Distributor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Poster)).BeginInit();
            this.SuspendLayout();
            // 
            // Movie_Intro
            // 
            this.Movie_Intro.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie_Intro.Location = new System.Drawing.Point(501, 224);
            this.Movie_Intro.Name = "Movie_Intro";
            this.Movie_Intro.Size = new System.Drawing.Size(809, 167);
            this.Movie_Intro.TabIndex = 9;
            this.Movie_Intro.Text = "영화설명";
            // 
            // SetInterestButton
            // 
            this.SetInterestButton.BackColor = System.Drawing.Color.LightGray;
            this.SetInterestButton.FlatAppearance.BorderSize = 0;
            this.SetInterestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetInterestButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SetInterestButton.Location = new System.Drawing.Point(176, 327);
            this.SetInterestButton.Name = "SetInterestButton";
            this.SetInterestButton.Size = new System.Drawing.Size(194, 34);
            this.SetInterestButton.TabIndex = 10;
            this.SetInterestButton.Text = "관심리스트 넣기";
            this.SetInterestButton.UseVisualStyleBackColor = false;
            // 
            // Movie_NM
            // 
            this.Movie_NM.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie_NM.Location = new System.Drawing.Point(396, 10);
            this.Movie_NM.Name = "Movie_NM";
            this.Movie_NM.Size = new System.Drawing.Size(430, 46);
            this.Movie_NM.TabIndex = 11;
            this.Movie_NM.Text = "영화제목";
            this.Movie_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(258, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "영화평점";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Poster
            // 
            this.Poster.BackColor = System.Drawing.Color.Wheat;
            this.Poster.Location = new System.Drawing.Point(203, 45);
            this.Poster.Name = "Poster";
            this.Poster.Size = new System.Drawing.Size(148, 206);
            this.Poster.TabIndex = 13;
            this.Poster.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(198, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "평점:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(396, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "장르:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(396, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "감독명:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(682, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "배우명:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(396, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "국가:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(840, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 29);
            this.label7.TabIndex = 19;
            this.label7.Text = "상영시간:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(1065, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "등급:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(604, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 29);
            this.label9.TabIndex = 21;
            this.label9.Text = "개봉일:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(819, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 29);
            this.label10.TabIndex = 22;
            this.label10.Text = "배급사:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Genre
            // 
            this.Genre.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Genre.Location = new System.Drawing.Point(456, 71);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(142, 29);
            this.Genre.TabIndex = 23;
            this.Genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReleaseDate.Location = new System.Drawing.Point(682, 71);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(152, 29);
            this.ReleaseDate.TabIndex = 24;
            this.ReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShowTime
            // 
            this.ShowTime.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ShowTime.Location = new System.Drawing.Point(937, 71);
            this.ShowTime.Name = "ShowTime";
            this.ShowTime.Size = new System.Drawing.Size(50, 29);
            this.ShowTime.TabIndex = 25;
            this.ShowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rating
            // 
            this.Rating.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Rating.Location = new System.Drawing.Point(1125, 71);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(218, 29);
            this.Rating.TabIndex = 26;
            this.Rating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DirectorNM
            // 
            this.DirectorNM.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DirectorNM.Location = new System.Drawing.Point(474, 119);
            this.DirectorNM.Name = "DirectorNM";
            this.DirectorNM.Size = new System.Drawing.Size(202, 29);
            this.DirectorNM.TabIndex = 27;
            this.DirectorNM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ActorNM
            // 
            this.ActorNM.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ActorNM.Location = new System.Drawing.Point(759, 120);
            this.ActorNM.Name = "ActorNM";
            this.ActorNM.Size = new System.Drawing.Size(650, 28);
            this.ActorNM.TabIndex = 28;
            this.ActorNM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Country
            // 
            this.Country.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Country.Location = new System.Drawing.Point(456, 168);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(198, 29);
            this.Country.TabIndex = 29;
            this.Country.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Distributor
            // 
            this.Distributor.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Distributor.Location = new System.Drawing.Point(897, 168);
            this.Distributor.Name = "Distributor";
            this.Distributor.Size = new System.Drawing.Size(368, 29);
            this.Distributor.TabIndex = 30;
            this.Distributor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(979, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 31);
            this.label11.TabIndex = 31;
            this.label11.Text = "분";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(396, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 29);
            this.label12.TabIndex = 32;
            this.label12.Text = "영화소개:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovieDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Distributor);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.ActorNM);
            this.Controls.Add(this.DirectorNM);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.ShowTime);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Movie_Intro);
            this.Controls.Add(this.SetInterestButton);
            this.Controls.Add(this.Movie_NM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Poster);
            this.Name = "MovieDetail";
            this.Size = new System.Drawing.Size(1519, 391);
            ((System.ComponentModel.ISupportInitialize)(this.Poster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Movie_Intro;
        private System.Windows.Forms.Button SetInterestButton;
        private System.Windows.Forms.Label Movie_NM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Poster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label ReleaseDate;
        private System.Windows.Forms.Label ShowTime;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label DirectorNM;
        private System.Windows.Forms.Label ActorNM;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Label Distributor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;

    }
}
