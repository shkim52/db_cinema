namespace DB_Project_Cinema
{
    partial class MovieSearchList
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
            this.DirectorNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieNM,
            this.DirectorNM,
            this.Rating});
            this.dataGridView1.Location = new System.Drawing.Point(378, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(650, 104);
            this.dataGridView1.TabIndex = 0;
            // 
            // MovieNM
            // 
            this.MovieNM.HeaderText = "영화명";
            this.MovieNM.Name = "MovieNM";
            this.MovieNM.ReadOnly = true;
            // 
            // DirectorNM
            // 
            this.DirectorNM.HeaderText = "감독명";
            this.DirectorNM.Name = "DirectorNM";
            this.DirectorNM.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "관람등급";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            // 
            // MovieSearchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Name = "MovieSearchList";
            this.Size = new System.Drawing.Size(1165, 501);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirectorNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
    }
}
