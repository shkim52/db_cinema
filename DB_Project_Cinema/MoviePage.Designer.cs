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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTypeList = new System.Windows.Forms.ListBox();
            this.MovieSearchText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Movie1DetailButton = new System.Windows.Forms.Button();
            this.Movie2DetailButton = new System.Windows.Forms.Button();
            this.Movie3DetailButton = new System.Windows.Forms.Button();
            this.Movie4DetailButton = new System.Windows.Forms.Button();
            this.Movie5DetailButton = new System.Windows.Forms.Button();
            this.BackToHomeButton = new System.Windows.Forms.Button();
            this.ReviewButton = new System.Windows.Forms.Button();
            this.ReviewPage = new DB_Project_Cinema.RevieiwPage();
            this.MovieList = new DB_Project_Cinema.MovieList();
            this.MovieDetail = new DB_Project_Cinema.MovieDetail();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SearchTypeList);
            this.panel1.Controls.Add(this.MovieSearchText);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1559, 205);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BackToHomeButton);
            this.panel2.Controls.Add(this.ReviewButton);
            this.panel2.Controls.Add(this.Movie1DetailButton);
            this.panel2.Controls.Add(this.Movie2DetailButton);
            this.panel2.Controls.Add(this.Movie3DetailButton);
            this.panel2.Controls.Add(this.Movie4DetailButton);
            this.panel2.Controls.Add(this.Movie5DetailButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 567);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1559, 99);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(314, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "영화검색";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchTypeList
            // 
            this.SearchTypeList.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchTypeList.FormattingEnabled = true;
            this.SearchTypeList.ItemHeight = 25;
            this.SearchTypeList.Items.AddRange(new object[] {
            "영화명",
            "감독명",
            "장르명"});
            this.SearchTypeList.Location = new System.Drawing.Point(319, 141);
            this.SearchTypeList.Name = "SearchTypeList";
            this.SearchTypeList.Size = new System.Drawing.Size(124, 29);
            this.SearchTypeList.TabIndex = 12;
            // 
            // MovieSearchText
            // 
            this.MovieSearchText.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieSearchText.Location = new System.Drawing.Point(507, 141);
            this.MovieSearchText.Name = "MovieSearchText";
            this.MovieSearchText.Size = new System.Drawing.Size(532, 31);
            this.MovieSearchText.TabIndex = 13;
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.BackColor = System.Drawing.Color.LightGray;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchButton.Location = new System.Drawing.Point(1105, 141);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(124, 37);
            this.SearchButton.TabIndex = 14;
            this.SearchButton.Text = "검색";
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(658, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "MOVIE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Movie1DetailButton
            // 
            this.Movie1DetailButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Movie1DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie1DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie1DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie1DetailButton.Location = new System.Drawing.Point(115, 31);
            this.Movie1DetailButton.Name = "Movie1DetailButton";
            this.Movie1DetailButton.Size = new System.Drawing.Size(194, 34);
            this.Movie1DetailButton.TabIndex = 5;
            this.Movie1DetailButton.Text = "영화이름";
            this.Movie1DetailButton.UseVisualStyleBackColor = false;
            this.Movie1DetailButton.Click += new System.EventHandler(this.Movie1DetailButton_Click_1);
            // 
            // Movie2DetailButton
            // 
            this.Movie2DetailButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Movie2DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie2DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie2DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie2DetailButton.Location = new System.Drawing.Point(377, 31);
            this.Movie2DetailButton.Name = "Movie2DetailButton";
            this.Movie2DetailButton.Size = new System.Drawing.Size(194, 34);
            this.Movie2DetailButton.TabIndex = 6;
            this.Movie2DetailButton.Text = "영화이름";
            this.Movie2DetailButton.UseVisualStyleBackColor = false;
            this.Movie2DetailButton.Click += new System.EventHandler(this.Movie2DetailButton_Click);
            // 
            // Movie3DetailButton
            // 
            this.Movie3DetailButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Movie3DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie3DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie3DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie3DetailButton.Location = new System.Drawing.Point(634, 31);
            this.Movie3DetailButton.Name = "Movie3DetailButton";
            this.Movie3DetailButton.Size = new System.Drawing.Size(194, 34);
            this.Movie3DetailButton.TabIndex = 7;
            this.Movie3DetailButton.Text = "영화이름";
            this.Movie3DetailButton.UseVisualStyleBackColor = false;
            this.Movie3DetailButton.Click += new System.EventHandler(this.Movie3DetailButton_Click);
            // 
            // Movie4DetailButton
            // 
            this.Movie4DetailButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Movie4DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie4DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie4DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie4DetailButton.Location = new System.Drawing.Point(895, 31);
            this.Movie4DetailButton.Name = "Movie4DetailButton";
            this.Movie4DetailButton.Size = new System.Drawing.Size(194, 34);
            this.Movie4DetailButton.TabIndex = 8;
            this.Movie4DetailButton.Text = "영화이름";
            this.Movie4DetailButton.UseVisualStyleBackColor = false;
            this.Movie4DetailButton.Click += new System.EventHandler(this.Movie4DetailButton_Click);
            // 
            // Movie5DetailButton
            // 
            this.Movie5DetailButton.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Movie5DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie5DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie5DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie5DetailButton.Location = new System.Drawing.Point(1146, 31);
            this.Movie5DetailButton.Name = "Movie5DetailButton";
            this.Movie5DetailButton.Size = new System.Drawing.Size(194, 34);
            this.Movie5DetailButton.TabIndex = 9;
            this.Movie5DetailButton.Text = "영화이름";
            this.Movie5DetailButton.UseVisualStyleBackColor = false;
            // 
            // BackToHomeButton
            // 
            this.BackToHomeButton.BackColor = System.Drawing.Color.LightGray;
            this.BackToHomeButton.FlatAppearance.BorderSize = 0;
            this.BackToHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToHomeButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BackToHomeButton.Location = new System.Drawing.Point(212, 31);
            this.BackToHomeButton.Name = "BackToHomeButton";
            this.BackToHomeButton.Size = new System.Drawing.Size(176, 34);
            this.BackToHomeButton.TabIndex = 10;
            this.BackToHomeButton.Text = "<-홈으로";
            this.BackToHomeButton.UseVisualStyleBackColor = false;
            this.BackToHomeButton.Click += new System.EventHandler(this.BackToHomeButton_Click_1);
            // 
            // ReviewButton
            // 
            this.ReviewButton.BackColor = System.Drawing.Color.LightGray;
            this.ReviewButton.FlatAppearance.BorderSize = 0;
            this.ReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviewButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReviewButton.Location = new System.Drawing.Point(490, 31);
            this.ReviewButton.Name = "ReviewButton";
            this.ReviewButton.Size = new System.Drawing.Size(176, 34);
            this.ReviewButton.TabIndex = 11;
            this.ReviewButton.Text = "리뷰 보기/등록";
            this.ReviewButton.UseVisualStyleBackColor = false;
            this.ReviewButton.Click += new System.EventHandler(this.ReviewButton_Click_1);
            // 
            // ReviewPage
            // 
            this.ReviewPage.BackColor = System.Drawing.Color.White;
            this.ReviewPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReviewPage.Location = new System.Drawing.Point(0, 205);
            this.ReviewPage.Name = "ReviewPage";
            this.ReviewPage.Size = new System.Drawing.Size(1559, 362);
            this.ReviewPage.TabIndex = 9;
            // 
            // MovieList
            // 
            this.MovieList.BackColor = System.Drawing.Color.White;
            this.MovieList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieList.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieList.Location = new System.Drawing.Point(0, 205);
            this.MovieList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieList.Name = "MovieList";
            this.MovieList.Size = new System.Drawing.Size(1559, 362);
            this.MovieList.TabIndex = 8;
            // 
            // MovieDetail
            // 
            this.MovieDetail.BackColor = System.Drawing.Color.White;
            this.MovieDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieDetail.Location = new System.Drawing.Point(0, 205);
            this.MovieDetail.Name = "MovieDetail";
            this.MovieDetail.Size = new System.Drawing.Size(1559, 362);
            this.MovieDetail.TabIndex = 7;
            // 
            // MoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ReviewPage);
            this.Controls.Add(this.MovieList);
            this.Controls.Add(this.MovieDetail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MoviePage";
            this.Size = new System.Drawing.Size(1559, 666);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox SearchTypeList;
        private System.Windows.Forms.TextBox MovieSearchText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Movie1DetailButton;
        private System.Windows.Forms.Button Movie2DetailButton;
        private System.Windows.Forms.Button Movie3DetailButton;
        private System.Windows.Forms.Button Movie4DetailButton;
        private System.Windows.Forms.Button Movie5DetailButton;
        private MovieDetail MovieDetail;
        private MovieList MovieList;
        private RevieiwPage ReviewPage;
        private System.Windows.Forms.Button BackToHomeButton;
        private System.Windows.Forms.Button ReviewButton;

    }
}
