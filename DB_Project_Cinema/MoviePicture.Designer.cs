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
            this.label1 = new System.Windows.Forms.Label();
            this.BackToHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture3)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture1
            // 
            this.Picture1.BackColor = System.Drawing.Color.Wheat;
            this.Picture1.Location = new System.Drawing.Point(288, 235);
            this.Picture1.Margin = new System.Windows.Forms.Padding(2);
            this.Picture1.Name = "Picture1";
            this.Picture1.Size = new System.Drawing.Size(258, 140);
            this.Picture1.TabIndex = 1;
            this.Picture1.TabStop = false;
            // 
            // Picture2
            // 
            this.Picture2.BackColor = System.Drawing.Color.Wheat;
            this.Picture2.Location = new System.Drawing.Point(625, 235);
            this.Picture2.Margin = new System.Windows.Forms.Padding(2);
            this.Picture2.Name = "Picture2";
            this.Picture2.Size = new System.Drawing.Size(258, 140);
            this.Picture2.TabIndex = 2;
            this.Picture2.TabStop = false;
            // 
            // Picture3
            // 
            this.Picture3.BackColor = System.Drawing.Color.Wheat;
            this.Picture3.Location = new System.Drawing.Point(964, 235);
            this.Picture3.Margin = new System.Windows.Forms.Padding(2);
            this.Picture3.Name = "Picture3";
            this.Picture3.Size = new System.Drawing.Size(258, 140);
            this.Picture3.TabIndex = 3;
            this.Picture3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = " ";
            // 
            // BackToHome
            // 
            this.BackToHome.BackColor = System.Drawing.Color.LightGray;
            this.BackToHome.FlatAppearance.BorderSize = 0;
            this.BackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToHome.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BackToHome.Location = new System.Drawing.Point(75, 546);
            this.BackToHome.Margin = new System.Windows.Forms.Padding(2);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(90, 29);
            this.BackToHome.TabIndex = 27;
            this.BackToHome.Text = "<-뒤로가기";
            this.BackToHome.UseVisualStyleBackColor = false;
            this.BackToHome.Click += new System.EventHandler(this.BackToHome_Click);
            // 
            // MoviePicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.BackToHome);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture1;
        private System.Windows.Forms.PictureBox Picture2;
        private System.Windows.Forms.PictureBox Picture3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackToHome;

    }
}
