namespace DB_Project_Cinema
{
    partial class MovieSearchPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MovieNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectorNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActorNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coutry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieNM,
            this.Genre,
            this.DirectorNM,
            this.ActorNM,
            this.Rating,
            this.ReleaseDate,
            this.ShowTime,
            this.Coutry});
            this.dataGridView1.Location = new System.Drawing.Point(119, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(928, 316);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MovieNM
            // 
            this.MovieNM.HeaderText = "영화명";
            this.MovieNM.Name = "MovieNM";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "장르";
            this.Genre.Name = "Genre";
            // 
            // DirectorNM
            // 
            this.DirectorNM.HeaderText = "감독명";
            this.DirectorNM.Name = "DirectorNM";
            // 
            // ActorNM
            // 
            this.ActorNM.HeaderText = "배우명";
            this.ActorNM.Name = "ActorNM";
            // 
            // Rating
            // 
            this.Rating.HeaderText = "관람등급";
            this.Rating.Name = "Rating";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "개봉일";
            this.ReleaseDate.Name = "ReleaseDate";
            // 
            // ShowTime
            // 
            this.ShowTime.HeaderText = "상영시간";
            this.ShowTime.Name = "ShowTime";
            // 
            // Coutry
            // 
            this.Coutry.HeaderText = "국가";
            this.Coutry.Name = "Coutry";
            // 
            // MovieSearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MovieSearchPage";
            this.Size = new System.Drawing.Size(1182, 881);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectorNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActorNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coutry;
    }
}
