namespace DB_Project_Cinema
{
    partial class MoviePage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTypeList = new System.Windows.Forms.ListBox();
            this.MovieSearchText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Movie1DetailButton = new System.Windows.Forms.Button();
            this.Movie2DetailButton = new System.Windows.Forms.Button();
            this.Movie3DetailButton = new System.Windows.Forms.Button();
            this.Movie4DetailButton = new System.Windows.Forms.Button();
            this.Movie5DetailButton = new System.Windows.Forms.Button();
            this.BackToHomeButton = new System.Windows.Forms.Button();
            this.ReviewButton = new System.Windows.Forms.Button();
            this.MovieList = new DB_Project_Cinema.MovieList();
            this.MovieDetail = new DB_Project_Cinema.MovieDetail();
            this.ReviewPage = new DB_Project_Cinema.RevieiwPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.SearchTypeList, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.MovieSearchText, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.SearchButton, 9, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.82253F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.01719F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.651685F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.5086F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 185);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(36, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "영화검색";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchTypeList
            // 
            this.SearchTypeList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchTypeList.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchTypeList.FormattingEnabled = true;
            this.SearchTypeList.ItemHeight = 25;
            this.SearchTypeList.Items.AddRange(new object[] {
            "영화명",
            "감독명",
            "장르명"});
            this.SearchTypeList.Location = new System.Drawing.Point(36, 134);
            this.SearchTypeList.Name = "SearchTypeList";
            this.SearchTypeList.Size = new System.Drawing.Size(124, 29);
            this.SearchTypeList.TabIndex = 1;
            // 
            // MovieSearchText
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.MovieSearchText, 5);
            this.MovieSearchText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MovieSearchText.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieSearchText.Location = new System.Drawing.Point(177, 132);
            this.MovieSearchText.Name = "MovieSearchText";
            this.MovieSearchText.Size = new System.Drawing.Size(406, 31);
            this.MovieSearchText.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.BackColor = System.Drawing.Color.LightGray;
            this.SearchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchButton.Location = new System.Drawing.Point(600, 126);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(124, 37);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "검색";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(318, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "MOVIE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 11;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.59299F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.7035F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.7035F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.7035F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.7035F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.59299F));
            this.tableLayoutPanel2.Controls.Add(this.Movie1DetailButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.Movie2DetailButton, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.Movie3DetailButton, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.Movie4DetailButton, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.Movie5DetailButton, 9, 1);
            this.tableLayoutPanel2.Controls.Add(this.BackToHomeButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.ReviewButton, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 304);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(762, 86);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Movie1DetailButton
            // 
            this.Movie1DetailButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Movie1DetailButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Movie1DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie1DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie1DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie1DetailButton.Location = new System.Drawing.Point(-26, 7);
            this.Movie1DetailButton.Name = "Movie1DetailButton";
            this.Movie1DetailButton.Size = new System.Drawing.Size(194, 34);
            this.Movie1DetailButton.TabIndex = 0;
            this.Movie1DetailButton.Text = "영화이름";
            this.Movie1DetailButton.UseVisualStyleBackColor = false;
            this.Movie1DetailButton.Click += new System.EventHandler(this.Movie1DetailButton_Click);
            // 
            // Movie2DetailButton
            // 
            this.Movie2DetailButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Movie2DetailButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Movie2DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie2DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie2DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie2DetailButton.Location = new System.Drawing.Point(130, 7);
            this.Movie2DetailButton.Name = "Movie2DetailButton";
            this.Movie2DetailButton.Size = new System.Drawing.Size(194, 34);
            this.Movie2DetailButton.TabIndex = 1;
            this.Movie2DetailButton.Text = "영화이름";
            this.Movie2DetailButton.UseVisualStyleBackColor = false;
            // 
            // Movie3DetailButton
            // 
            this.Movie3DetailButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Movie3DetailButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Movie3DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie3DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie3DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie3DetailButton.Location = new System.Drawing.Point(286, 7);
            this.Movie3DetailButton.Name = "Movie3DetailButton";
            this.Movie3DetailButton.Size = new System.Drawing.Size(194, 34);
            this.Movie3DetailButton.TabIndex = 2;
            this.Movie3DetailButton.Text = "영화이름";
            this.Movie3DetailButton.UseVisualStyleBackColor = false;
            // 
            // Movie4DetailButton
            // 
            this.Movie4DetailButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Movie4DetailButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Movie4DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie4DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie4DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie4DetailButton.Location = new System.Drawing.Point(442, 7);
            this.Movie4DetailButton.Name = "Movie4DetailButton";
            this.Movie4DetailButton.Size = new System.Drawing.Size(194, 34);
            this.Movie4DetailButton.TabIndex = 3;
            this.Movie4DetailButton.Text = "영화이름";
            this.Movie4DetailButton.UseVisualStyleBackColor = false;
            // 
            // Movie5DetailButton
            // 
            this.Movie5DetailButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Movie5DetailButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Movie5DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie5DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie5DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie5DetailButton.Location = new System.Drawing.Point(598, 7);
            this.Movie5DetailButton.Name = "Movie5DetailButton";
            this.Movie5DetailButton.Size = new System.Drawing.Size(194, 34);
            this.Movie5DetailButton.TabIndex = 4;
            this.Movie5DetailButton.Text = "영화이름";
            this.Movie5DetailButton.UseVisualStyleBackColor = false;
            // 
            // BackToHomeButton
            // 
            this.BackToHomeButton.BackColor = System.Drawing.Color.LightGray;
            this.BackToHomeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackToHomeButton.FlatAppearance.BorderSize = 0;
            this.BackToHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToHomeButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BackToHomeButton.Location = new System.Drawing.Point(174, 7);
            this.BackToHomeButton.Name = "BackToHomeButton";
            this.BackToHomeButton.Size = new System.Drawing.Size(1, 34);
            this.BackToHomeButton.TabIndex = 5;
            this.BackToHomeButton.Text = "<-홈으로";
            this.BackToHomeButton.UseVisualStyleBackColor = false;
            this.BackToHomeButton.Click += new System.EventHandler(this.BackToHomeButton_Click);
            // 
            // ReviewButton
            // 
            this.ReviewButton.BackColor = System.Drawing.Color.LightGray;
            this.ReviewButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReviewButton.FlatAppearance.BorderSize = 0;
            this.ReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviewButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReviewButton.Location = new System.Drawing.Point(330, 7);
            this.ReviewButton.Name = "ReviewButton";
            this.ReviewButton.Size = new System.Drawing.Size(1, 34);
            this.ReviewButton.TabIndex = 6;
            this.ReviewButton.Text = "리뷰 보기/등록";
            this.ReviewButton.UseVisualStyleBackColor = false;
            this.ReviewButton.Click += new System.EventHandler(this.ReviewButton_Click);
            // 
            // MovieList
            // 
            this.MovieList.BackColor = System.Drawing.Color.White;
            this.MovieList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieList.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieList.Location = new System.Drawing.Point(0, 185);
            this.MovieList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieList.Name = "MovieList";
            this.MovieList.Size = new System.Drawing.Size(762, 119);
            this.MovieList.TabIndex = 2;
            // 
            // MovieDetail
            // 
            this.MovieDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieDetail.Location = new System.Drawing.Point(0, 185);
            this.MovieDetail.Name = "MovieDetail";
            this.MovieDetail.Size = new System.Drawing.Size(762, 119);
            this.MovieDetail.TabIndex = 3;
            // 
            // ReviewPage
            // 
            this.ReviewPage.BackColor = System.Drawing.Color.White;
            this.ReviewPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReviewPage.Location = new System.Drawing.Point(0, 185);
            this.ReviewPage.Name = "ReviewPage";
            this.ReviewPage.Size = new System.Drawing.Size(762, 119);
            this.ReviewPage.TabIndex = 4;
            // 
            // MoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ReviewPage);
            this.Controls.Add(this.MovieDetail);
            this.Controls.Add(this.MovieList);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MoviePage";
            this.Size = new System.Drawing.Size(762, 390);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox SearchTypeList;
        private System.Windows.Forms.TextBox MovieSearchText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Movie1DetailButton;
        private System.Windows.Forms.Button Movie2DetailButton;
        private System.Windows.Forms.Button Movie3DetailButton;
        private System.Windows.Forms.Button Movie4DetailButton;
        private System.Windows.Forms.Button Movie5DetailButton;
        private MovieList MovieList;
        private MovieDetail MovieDetail;
        private System.Windows.Forms.Button BackToHomeButton;
        private System.Windows.Forms.Button ReviewButton;
        private RevieiwPage ReviewPage;
    }
}
