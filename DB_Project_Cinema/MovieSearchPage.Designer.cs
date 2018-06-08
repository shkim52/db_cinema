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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieSearchPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.poster = new System.Windows.Forms.DataGridViewImageColumn();
            this.MovieNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirectorNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActorNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.poster,
            this.MovieNM,
            this.Genre,
            this.DirectorNM,
            this.ActorNM,
            this.Rating,
            this.ReleaseDate,
            this.MovieDetail});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(119, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(810, 350);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 145;
            this.dataGridView1.Size = new System.Drawing.Size(803, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // poster
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 3);
            this.poster.DefaultCellStyle = dataGridViewCellStyle1;
            this.poster.HeaderText = "포스터";
            this.poster.Name = "poster";
            // 
            // MovieNM
            // 
            this.MovieNM.HeaderText = "영화명";
            this.MovieNM.Name = "MovieNM";
            this.MovieNM.ReadOnly = true;
            this.MovieNM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "장르";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            this.Genre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DirectorNM
            // 
            this.DirectorNM.HeaderText = "감독명";
            this.DirectorNM.Name = "DirectorNM";
            this.DirectorNM.ReadOnly = true;
            this.DirectorNM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ActorNM
            // 
            this.ActorNM.FillWeight = 200F;
            this.ActorNM.HeaderText = "배우명";
            this.ActorNM.Name = "ActorNM";
            this.ActorNM.ReadOnly = true;
            this.ActorNM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "관람등급";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "개봉일";
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MovieDetail
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 55, 0, 55);
            this.MovieDetail.DefaultCellStyle = dataGridViewCellStyle2;
            this.MovieDetail.HeaderText = "상세보기";
            this.MovieDetail.Name = "MovieDetail";
            this.MovieDetail.ReadOnly = true;
            this.MovieDetail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
        private System.Windows.Forms.DataGridViewImageColumn poster;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectorNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActorNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewButtonColumn MovieDetail;
    }
}
