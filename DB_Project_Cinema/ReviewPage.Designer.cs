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
            this.label2 = new System.Windows.Forms.Label();
            this.Review = new System.Windows.Forms.TextBox();
            this.ReviewRegisterButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemReview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackToHome = new System.Windows.Forms.Button();
            this.MovieScore = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieNM
            // 
            this.MovieNM.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieNM.Location = new System.Drawing.Point(253, -1);
            this.MovieNM.Name = "MovieNM";
            this.MovieNM.Size = new System.Drawing.Size(510, 56);
            this.MovieNM.TabIndex = 8;
            this.MovieNM.Text = "영화제목";
            this.MovieNM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(181, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "평점";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Review
            // 
            this.Review.Location = new System.Drawing.Point(338, 56);
            this.Review.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(469, 27);
            this.Review.TabIndex = 11;
            // 
            // ReviewRegisterButton
            // 
            this.ReviewRegisterButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReviewRegisterButton.Location = new System.Drawing.Point(822, 56);
            this.ReviewRegisterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReviewRegisterButton.Name = "ReviewRegisterButton";
            this.ReviewRegisterButton.Size = new System.Drawing.Size(60, 29);
            this.ReviewRegisterButton.TabIndex = 13;
            this.ReviewRegisterButton.Text = "등록";
            this.ReviewRegisterButton.UseVisualStyleBackColor = true;
            this.ReviewRegisterButton.Click += new System.EventHandler(this.ReviewRegisterButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemID,
            this.Score,
            this.MemReview});
            this.dataGridView1.Location = new System.Drawing.Point(206, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(659, 121);
            this.dataGridView1.TabIndex = 14;
            // 
            // MemID
            // 
            this.MemID.FillWeight = 150F;
            this.MemID.HeaderText = "회원아이디";
            this.MemID.Name = "MemID";
            this.MemID.ReadOnly = true;
            this.MemID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MemID.Width = 150;
            // 
            // Score
            // 
            this.Score.HeaderText = "평점";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MemReview
            // 
            this.MemReview.FillWeight = 400F;
            this.MemReview.HeaderText = "리뷰";
            this.MemReview.Name = "MemReview";
            this.MemReview.ReadOnly = true;
            this.MemReview.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MemReview.Width = 400;
            // 
            // BackToHome
            // 
            this.BackToHome.BackColor = System.Drawing.Color.LightGray;
            this.BackToHome.FlatAppearance.BorderSize = 0;
            this.BackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToHome.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BackToHome.Location = new System.Drawing.Point(34, 467);
            this.BackToHome.Margin = new System.Windows.Forms.Padding(2);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(94, 26);
            this.BackToHome.TabIndex = 26;
            this.BackToHome.Text = "<-뒤로가기";
            this.BackToHome.UseVisualStyleBackColor = false;
            this.BackToHome.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // MovieScore
            // 
            this.MovieScore.FormattingEnabled = true;
            this.MovieScore.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.MovieScore.Location = new System.Drawing.Point(242, 55);
            this.MovieScore.Name = "MovieScore";
            this.MovieScore.Size = new System.Drawing.Size(75, 28);
            this.MovieScore.TabIndex = 27;
            // 
            // ReviewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MovieScore);
            this.Controls.Add(this.BackToHome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MovieNM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Review);
            this.Controls.Add(this.ReviewRegisterButton);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReviewPage";
            this.Size = new System.Drawing.Size(1536, 529);
            this.Load += new System.EventHandler(this.ReviewPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieNM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Review;
        private System.Windows.Forms.Button ReviewRegisterButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BackToHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemReview;
        private System.Windows.Forms.ComboBox MovieScore;

    }
}
