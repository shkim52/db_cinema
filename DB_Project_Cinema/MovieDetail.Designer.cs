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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Movie_Intro
            // 
            this.Movie_Intro.Location = new System.Drawing.Point(545, 87);
            this.Movie_Intro.Name = "Movie_Intro";
            this.Movie_Intro.Size = new System.Drawing.Size(675, 189);
            this.Movie_Intro.TabIndex = 9;
            this.Movie_Intro.Text = "영화설명";
            // 
            // SetInterestButton
            // 
            this.SetInterestButton.BackColor = System.Drawing.Color.LightGray;
            this.SetInterestButton.FlatAppearance.BorderSize = 0;
            this.SetInterestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetInterestButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SetInterestButton.Location = new System.Drawing.Point(548, 313);
            this.SetInterestButton.Name = "SetInterestButton";
            this.SetInterestButton.Size = new System.Drawing.Size(194, 34);
            this.SetInterestButton.TabIndex = 10;
            this.SetInterestButton.Text = "관심리스트 넣기";
            this.SetInterestButton.UseVisualStyleBackColor = false;
            // 
            // Movie_NM
            // 
            this.Movie_NM.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie_NM.Location = new System.Drawing.Point(543, 20);
            this.Movie_NM.Name = "Movie_NM";
            this.Movie_NM.Size = new System.Drawing.Size(430, 46);
            this.Movie_NM.TabIndex = 11;
            this.Movie_NM.Text = "영화제목";
            this.Movie_NM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(346, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "영화평점";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox1.Location = new System.Drawing.Point(321, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 206);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // MovieDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Movie_Intro);
            this.Controls.Add(this.SetInterestButton);
            this.Controls.Add(this.Movie_NM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MovieDetail";
            this.Size = new System.Drawing.Size(1293, 391);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Movie_Intro;
        private System.Windows.Forms.Button SetInterestButton;
        private System.Windows.Forms.Label Movie_NM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}
