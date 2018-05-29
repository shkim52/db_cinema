namespace DB_Project_Cinema
{
    partial class MovieList
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
            this.label1 = new System.Windows.Forms.Label();
            this.Poster1 = new System.Windows.Forms.PictureBox();
            this.Poster2 = new System.Windows.Forms.PictureBox();
            this.Poster3 = new System.Windows.Forms.PictureBox();
            this.Poster4 = new System.Windows.Forms.PictureBox();
            this.Poster5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Poster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poster2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poster3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poster4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poster5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(78, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "상영중인 영화";
            // 
            // Poster1
            // 
            this.Poster1.BackColor = System.Drawing.Color.Wheat;
            this.Poster1.Location = new System.Drawing.Point(79, 70);
            this.Poster1.Name = "Poster1";
            this.Poster1.Size = new System.Drawing.Size(147, 210);
            this.Poster1.TabIndex = 7;
            this.Poster1.TabStop = false;
            // 
            // Poster2
            // 
            this.Poster2.BackColor = System.Drawing.Color.Wheat;
            this.Poster2.Location = new System.Drawing.Point(260, 70);
            this.Poster2.Name = "Poster2";
            this.Poster2.Size = new System.Drawing.Size(147, 210);
            this.Poster2.TabIndex = 8;
            this.Poster2.TabStop = false;
            // 
            // Poster3
            // 
            this.Poster3.BackColor = System.Drawing.Color.Wheat;
            this.Poster3.Location = new System.Drawing.Point(442, 70);
            this.Poster3.Name = "Poster3";
            this.Poster3.Size = new System.Drawing.Size(147, 210);
            this.Poster3.TabIndex = 9;
            this.Poster3.TabStop = false;
            // 
            // Poster4
            // 
            this.Poster4.BackColor = System.Drawing.Color.Wheat;
            this.Poster4.Location = new System.Drawing.Point(622, 70);
            this.Poster4.Name = "Poster4";
            this.Poster4.Size = new System.Drawing.Size(147, 210);
            this.Poster4.TabIndex = 10;
            this.Poster4.TabStop = false;
            // 
            // Poster5
            // 
            this.Poster5.BackColor = System.Drawing.Color.Wheat;
            this.Poster5.Location = new System.Drawing.Point(796, 70);
            this.Poster5.Name = "Poster5";
            this.Poster5.Size = new System.Drawing.Size(147, 210);
            this.Poster5.TabIndex = 11;
            this.Poster5.TabStop = false;
            // 
            // MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Poster1);
            this.Controls.Add(this.Poster2);
            this.Controls.Add(this.Poster3);
            this.Controls.Add(this.Poster4);
            this.Controls.Add(this.Poster5);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MovieList";
            this.Size = new System.Drawing.Size(1042, 354);
            ((System.ComponentModel.ISupportInitialize)(this.Poster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poster2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poster3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poster4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poster5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Poster1;
        private System.Windows.Forms.PictureBox Poster2;
        private System.Windows.Forms.PictureBox Poster3;
        private System.Windows.Forms.PictureBox Poster4;
        private System.Windows.Forms.PictureBox Poster5;

    }
}
