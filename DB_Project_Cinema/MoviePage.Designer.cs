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
            this.MovieCategory = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ExpectedMovie = new System.Windows.Forms.Button();
            this.PlayingMovie = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MovieCategory);
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.SearchText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1594, 157);
            this.panel1.TabIndex = 0;
            // 
            // MovieCategory
            // 
            this.MovieCategory.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieCategory.FormattingEnabled = true;
            this.MovieCategory.Items.AddRange(new object[] {
            "영화명",
            "감독명",
            "장르명"});
            this.MovieCategory.Location = new System.Drawing.Point(392, 111);
            this.MovieCategory.Name = "MovieCategory";
            this.MovieCategory.Size = new System.Drawing.Size(102, 28);
            this.MovieCategory.TabIndex = 13;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.LightGray;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchButton.Location = new System.Drawing.Point(968, 109);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(77, 30);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "검색";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchText.Location = new System.Drawing.Point(533, 111);
            this.SearchText.Margin = new System.Windows.Forms.Padding(2);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(401, 27);
            this.SearchText.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(632, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "Movie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.ExpectedMovie);
            this.panel2.Controls.Add(this.PlayingMovie);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 157);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1594, 74);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(0, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1594, 10);
            this.panel4.TabIndex = 0;
            // 
            // ExpectedMovie
            // 
            this.ExpectedMovie.BackColor = System.Drawing.Color.LightGray;
            this.ExpectedMovie.FlatAppearance.BorderSize = 0;
            this.ExpectedMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpectedMovie.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ExpectedMovie.Location = new System.Drawing.Point(764, 15);
            this.ExpectedMovie.Margin = new System.Windows.Forms.Padding(2);
            this.ExpectedMovie.Name = "ExpectedMovie";
            this.ExpectedMovie.Size = new System.Drawing.Size(130, 32);
            this.ExpectedMovie.TabIndex = 1;
            this.ExpectedMovie.Text = "상영예정작";
            this.ExpectedMovie.UseVisualStyleBackColor = false;
            this.ExpectedMovie.Click += new System.EventHandler(this.ExpectedMovie_Click);
            // 
            // PlayingMovie
            // 
            this.PlayingMovie.BackColor = System.Drawing.Color.LightGray;
            this.PlayingMovie.FlatAppearance.BorderSize = 0;
            this.PlayingMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayingMovie.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlayingMovie.Location = new System.Drawing.Point(582, 15);
            this.PlayingMovie.Margin = new System.Windows.Forms.Padding(2);
            this.PlayingMovie.Name = "PlayingMovie";
            this.PlayingMovie.Size = new System.Drawing.Size(130, 32);
            this.PlayingMovie.TabIndex = 0;
            this.PlayingMovie.Text = "현재상영작";
            this.PlayingMovie.UseVisualStyleBackColor = false;
            this.PlayingMovie.Click += new System.EventHandler(this.PlayingMovie_Click);
            // 
            // panel3
            // 
            this.panel3.AccessibleName = "panel3";
            this.panel3.Location = new System.Drawing.Point(0, 231);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1594, 441);
            this.panel3.TabIndex = 7;
            // 
            // MoviePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MoviePage";
            this.Size = new System.Drawing.Size(1594, 674);
            this.Load += new System.EventHandler(this.MoviePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PlayingMovie;
        private System.Windows.Forms.Button ExpectedMovie;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox MovieCategory;
        private System.Windows.Forms.Panel panel4;

    }
}
