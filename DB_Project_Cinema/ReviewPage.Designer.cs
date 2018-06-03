namespace DB_Project_Cinema
{
    partial class ReviewPage
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
            this.MovieNM = new System.Windows.Forms.Label();
            this.MovieScore = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Review = new System.Windows.Forms.TextBox();
            this.ReviewRegisterButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemReview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieNM
            // 
            this.MovieNM.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieNM.Location = new System.Drawing.Point(477, 24);
            this.MovieNM.Name = "MovieNM";
            this.MovieNM.Size = new System.Drawing.Size(510, 56);
            this.MovieNM.TabIndex = 8;
            this.MovieNM.Text = "영화제목";
            this.MovieNM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MovieScore
            // 
            this.MovieScore.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieScore.FormattingEnabled = true;
            this.MovieScore.ItemHeight = 25;
            this.MovieScore.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.MovieScore.Location = new System.Drawing.Point(311, 104);
            this.MovieScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieScore.Name = "MovieScore";
            this.MovieScore.Size = new System.Drawing.Size(94, 29);
            this.MovieScore.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(231, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 56);
            this.label2.TabIndex = 10;
            this.label2.Text = "평점";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Review
            // 
            this.Review.Location = new System.Drawing.Point(416, 104);
            this.Review.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(753, 31);
            this.Review.TabIndex = 11;
            // 
            // ReviewRegisterButton
            // 
            this.ReviewRegisterButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReviewRegisterButton.Location = new System.Drawing.Point(1189, 104);
            this.ReviewRegisterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReviewRegisterButton.Name = "ReviewRegisterButton";
            this.ReviewRegisterButton.Size = new System.Drawing.Size(74, 47);
            this.ReviewRegisterButton.TabIndex = 13;
            this.ReviewRegisterButton.Text = "등록";
            this.ReviewRegisterButton.UseVisualStyleBackColor = true;
            this.ReviewRegisterButton.Click += new System.EventHandler(this.ReviewRegisterButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemID,
            this.Score,
            this.MemReview});
            this.dataGridView1.Location = new System.Drawing.Point(257, 193);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 178);
            this.dataGridView1.TabIndex = 14;
            // 
            // MemID
            // 
            this.MemID.HeaderText = "회원아이디";
            this.MemID.Name = "MemID";
            // 
            // Score
            // 
            this.Score.HeaderText = "평점";
            this.Score.Name = "Score";
            // 
            // MemReview
            // 
            this.MemReview.HeaderText = "리뷰";
            this.MemReview.Name = "MemReview";
            // 
            // ReviewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MovieNM);
            this.Controls.Add(this.MovieScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Review);
            this.Controls.Add(this.ReviewRegisterButton);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReviewPage";
            this.Size = new System.Drawing.Size(1536, 744);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieNM;
        private System.Windows.Forms.ListBox MovieScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Review;
        private System.Windows.Forms.Button ReviewRegisterButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemReview;

    }
}
