namespace DB_Project_Cinema
{
    partial class MoviePicture
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
            this.Picture1 = new System.Windows.Forms.PictureBox();
            this.Picture2 = new System.Windows.Forms.PictureBox();
            this.Picture3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture3)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture1
            // 
            this.Picture1.BackColor = System.Drawing.Color.Wheat;
            this.Picture1.Location = new System.Drawing.Point(133, 146);
            this.Picture1.Margin = new System.Windows.Forms.Padding(2);
            this.Picture1.Name = "Picture1";
            this.Picture1.Size = new System.Drawing.Size(258, 140);
            this.Picture1.TabIndex = 1;
            this.Picture1.TabStop = false;
            // 
            // Picture2
            // 
            this.Picture2.BackColor = System.Drawing.Color.Wheat;
            this.Picture2.Location = new System.Drawing.Point(470, 146);
            this.Picture2.Margin = new System.Windows.Forms.Padding(2);
            this.Picture2.Name = "Picture2";
            this.Picture2.Size = new System.Drawing.Size(258, 140);
            this.Picture2.TabIndex = 2;
            this.Picture2.TabStop = false;
            // 
            // Picture3
            // 
            this.Picture3.BackColor = System.Drawing.Color.Wheat;
            this.Picture3.Location = new System.Drawing.Point(809, 146);
            this.Picture3.Margin = new System.Windows.Forms.Padding(2);
            this.Picture3.Name = "Picture3";
            this.Picture3.Size = new System.Drawing.Size(258, 140);
            this.Picture3.TabIndex = 3;
            this.Picture3.TabStop = false;
            // 
            // MoviePicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.Picture3);
            this.Controls.Add(this.Picture2);
            this.Controls.Add(this.Picture1);
            this.Name = "MoviePicture";
            this.Size = new System.Drawing.Size(1368, 675);
            this.Load += new System.EventHandler(this.MoviePicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture1;
        private System.Windows.Forms.PictureBox Picture2;
        private System.Windows.Forms.PictureBox Picture3;

    }
}
