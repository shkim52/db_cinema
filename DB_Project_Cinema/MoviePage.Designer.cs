namespace DB_Project_Cinema
{
    partial class MoviePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.MovieCategory = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ReviewButton = new System.Windows.Forms.Button();
            this.BackToHomeButton = new System.Windows.Forms.Button();
            this.Movie5DetailButton = new System.Windows.Forms.Button();
            this.Movie4DetailButton = new System.Windows.Forms.Button();
            this.Movie3DetailButton = new System.Windows.Forms.Button();
            this.Movie2DetailButton = new System.Windows.Forms.Button();
            this.Movie1DetailButton = new System.Windows.Forms.Button();
            this.MovieSearchPage = new DB_Project_Cinema.MovieSearchPage();
            this.MovieDetail = new DB_Project_Cinema.MovieDetail1();
            this.ReviewPage = new DB_Project_Cinema.RevieiwPage();
            this.MovieList = new DB_Project_Cinema.MovieList();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.SearchText);
            this.panel1.Controls.Add(this.MovieCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1702, 188);
            this.panel1.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.LightGray;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchButton.Location = new System.Drawing.Point(1038, 131);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(96, 36);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "검색";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(475, 133);
            this.SearchText.Margin = new System.Windows.Forms.Padding(2);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(519, 28);
            this.SearchText.TabIndex = 11;
            // 
            // MovieCategory
            // 
            this.MovieCategory.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieCategory.FormattingEnabled = true;
            this.MovieCategory.ItemHeight = 25;
            this.MovieCategory.Items.AddRange(new object[] {
            "영화명",
            "감독명",
            "장르명"});
            this.MovieCategory.Location = new System.Drawing.Point(342, 131);
            this.MovieCategory.Margin = new System.Windows.Forms.Padding(2);
            this.MovieCategory.Name = "MovieCategory";
            this.MovieCategory.Size = new System.Drawing.Size(93, 29);
            this.MovieCategory.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(618, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 60);
            this.label1.TabIndex = 9;
            this.label1.Text = "Movie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ReviewButton);
            this.panel2.Controls.Add(this.BackToHomeButton);
            this.panel2.Controls.Add(this.Movie5DetailButton);
            this.panel2.Controls.Add(this.Movie4DetailButton);
            this.panel2.Controls.Add(this.Movie3DetailButton);
            this.panel2.Controls.Add(this.Movie2DetailButton);
            this.panel2.Controls.Add(this.Movie1DetailButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 495);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1702, 95);
            this.panel2.TabIndex = 1;
            // 
            // ReviewButton
            // 
            this.ReviewButton.BackColor = System.Drawing.Color.LightGray;
            this.ReviewButton.FlatAppearance.BorderSize = 0;
            this.ReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviewButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReviewButton.Location = new System.Drawing.Point(606, 26);
            this.ReviewButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReviewButton.Name = "ReviewButton";
            this.ReviewButton.Size = new System.Drawing.Size(172, 36);
            this.ReviewButton.TabIndex = 17;
            this.ReviewButton.Text = "리뷰 보기/등록";
            this.ReviewButton.UseVisualStyleBackColor = false;
            this.ReviewButton.Click += new System.EventHandler(this.ReviewButton_Click_2);
            // 
            // BackToHomeButton
            // 
            this.BackToHomeButton.BackColor = System.Drawing.Color.LightGray;
            this.BackToHomeButton.FlatAppearance.BorderSize = 0;
            this.BackToHomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToHomeButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BackToHomeButton.Location = new System.Drawing.Point(314, 26);
            this.BackToHomeButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackToHomeButton.Name = "BackToHomeButton";
            this.BackToHomeButton.Size = new System.Drawing.Size(162, 36);
            this.BackToHomeButton.TabIndex = 13;
            this.BackToHomeButton.Text = "<-홈으로";
            this.BackToHomeButton.UseVisualStyleBackColor = false;
            this.BackToHomeButton.Click += new System.EventHandler(this.BackToHomeButton_Click_2);
            // 
            // Movie5DetailButton
            // 
            this.Movie5DetailButton.BackColor = System.Drawing.Color.Wheat;
            this.Movie5DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie5DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie5DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie5DetailButton.Location = new System.Drawing.Point(1144, 26);
            this.Movie5DetailButton.Margin = new System.Windows.Forms.Padding(2);
            this.Movie5DetailButton.Name = "Movie5DetailButton";
            this.Movie5DetailButton.Size = new System.Drawing.Size(202, 36);
            this.Movie5DetailButton.TabIndex = 14;
            this.Movie5DetailButton.Text = "영화이름";
            this.Movie5DetailButton.UseVisualStyleBackColor = false;
            this.Movie5DetailButton.Click += new System.EventHandler(this.Movie5DetailButton_Click_1);
            // 
            // Movie4DetailButton
            // 
            this.Movie4DetailButton.BackColor = System.Drawing.Color.Wheat;
            this.Movie4DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie4DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie4DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie4DetailButton.Location = new System.Drawing.Point(898, 26);
            this.Movie4DetailButton.Margin = new System.Windows.Forms.Padding(2);
            this.Movie4DetailButton.Name = "Movie4DetailButton";
            this.Movie4DetailButton.Size = new System.Drawing.Size(202, 36);
            this.Movie4DetailButton.TabIndex = 16;
            this.Movie4DetailButton.Text = "영화이름";
            this.Movie4DetailButton.UseVisualStyleBackColor = false;
            this.Movie4DetailButton.Click += new System.EventHandler(this.Movie4DetailButton_Click_1);
            // 
            // Movie3DetailButton
            // 
            this.Movie3DetailButton.BackColor = System.Drawing.Color.Wheat;
            this.Movie3DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie3DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie3DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie3DetailButton.Location = new System.Drawing.Point(639, 26);
            this.Movie3DetailButton.Margin = new System.Windows.Forms.Padding(2);
            this.Movie3DetailButton.Name = "Movie3DetailButton";
            this.Movie3DetailButton.Size = new System.Drawing.Size(202, 36);
            this.Movie3DetailButton.TabIndex = 15;
            this.Movie3DetailButton.Text = "영화이름";
            this.Movie3DetailButton.UseVisualStyleBackColor = false;
            this.Movie3DetailButton.Click += new System.EventHandler(this.Movie3DetailButton_Click_1);
            // 
            // Movie2DetailButton
            // 
            this.Movie2DetailButton.BackColor = System.Drawing.Color.Wheat;
            this.Movie2DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie2DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie2DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie2DetailButton.Location = new System.Drawing.Point(372, 26);
            this.Movie2DetailButton.Margin = new System.Windows.Forms.Padding(2);
            this.Movie2DetailButton.Name = "Movie2DetailButton";
            this.Movie2DetailButton.Size = new System.Drawing.Size(202, 36);
            this.Movie2DetailButton.TabIndex = 14;
            this.Movie2DetailButton.Text = "영화이름";
            this.Movie2DetailButton.UseVisualStyleBackColor = false;
            this.Movie2DetailButton.Click += new System.EventHandler(this.Movie2DetailButton_Click_1);
            // 
            // Movie1DetailButton
            // 
            this.Movie1DetailButton.BackColor = System.Drawing.Color.Wheat;
            this.Movie1DetailButton.FlatAppearance.BorderSize = 0;
            this.Movie1DetailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Movie1DetailButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Movie1DetailButton.Location = new System.Drawing.Point(106, 26);
            this.Movie1DetailButton.Margin = new System.Windows.Forms.Padding(2);
            this.Movie1DetailButton.Name = "Movie1DetailButton";
            this.Movie1DetailButton.Size = new System.Drawing.Size(202, 36);
            this.Movie1DetailButton.TabIndex = 13;
            this.Movie1DetailButton.Text = "영화이름";
            this.Movie1DetailButton.UseVisualStyleBackColor = false;
            this.Movie1DetailButton.Click += new System.EventHandler(this.Movie1DetailButton_Click_2);
            // 
            // MovieSearchPage
            // 
            this.MovieSearchPage.BackColor = System.Drawing.Color.White;
            this.MovieSearchPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MovieSearchPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieSearchPage.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieSearchPage.Location = new System.Drawing.Point(0, 188);
            this.MovieSearchPage.Margin = new System.Windows.Forms.Padding(2);
            this.MovieSearchPage.Name = "MovieSearchPage";
            this.MovieSearchPage.Size = new System.Drawing.Size(1702, 307);
            this.MovieSearchPage.TabIndex = 5;
            // 
            // MovieDetail
            // 
            this.MovieDetail.BackColor = System.Drawing.Color.White;
            this.MovieDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieDetail.Location = new System.Drawing.Point(0, 188);
            this.MovieDetail.Margin = new System.Windows.Forms.Padding(2);
            this.MovieDetail.Name = "MovieDetail";
            this.MovieDetail.Size = new System.Drawing.Size(1702, 307);
            this.MovieDetail.TabIndex = 4;
            // 
            // ReviewPage
            // 
            this.ReviewPage.BackColor = System.Drawing.Color.White;
            this.ReviewPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReviewPage.Location = new System.Drawing.Point(0, 188);
            this.ReviewPage.Margin = new System.Windows.Forms.Padding(2);
            this.ReviewPage.Name = "ReviewPage";
            this.ReviewPage.Size = new System.Drawing.Size(1702, 307);
            this.ReviewPage.TabIndex = 3;
            // 
            // MovieList
            // 
            this.MovieList.BackColor = System.Drawing.Color.White;
            this.MovieList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieList.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieList.Location = new System.Drawing.Point(0, 188);
            this.MovieList.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MovieList.Name = "MovieList";
            this.MovieList.Size = new System.Drawing.Size(1702, 307);
            this.MovieList.TabIndex = 2;
            // 
            // MoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MovieSearchPage);
            this.Controls.Add(this.MovieDetail);
            this.Controls.Add(this.ReviewPage);
            this.Controls.Add(this.MovieList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MoviePage";
            this.Size = new System.Drawing.Size(1702, 590);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ListBox MovieCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ReviewButton;
        private System.Windows.Forms.Button BackToHomeButton;
        private System.Windows.Forms.Button Movie5DetailButton;
        private System.Windows.Forms.Button Movie4DetailButton;
        private System.Windows.Forms.Button Movie3DetailButton;
        private System.Windows.Forms.Button Movie2DetailButton;
        private System.Windows.Forms.Button Movie1DetailButton;
        private MovieList MovieList;
        private RevieiwPage ReviewPage;
        private MovieDetail1 MovieDetail;
        private MovieSearchPage MovieSearchPage;

    }
}
