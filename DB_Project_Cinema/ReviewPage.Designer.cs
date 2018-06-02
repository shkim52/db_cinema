namespace DB_Project_Cinema
{
    partial class ReviewPage
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
            this.MovieNM = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Review = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReviewRegisterButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MovieNM
            // 
            this.MovieNM.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MovieNM.Location = new System.Drawing.Point(477, 17);
            this.MovieNM.Name = "MovieNM";
            this.MovieNM.Size = new System.Drawing.Size(510, 52);
            this.MovieNM.TabIndex = 8;
            this.MovieNM.Text = "영화제목";
            this.MovieNM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.listBox1.Location = new System.Drawing.Point(306, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(94, 29);
            this.listBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(226, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "평점";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Review
            // 
            this.Review.Location = new System.Drawing.Point(411, 91);
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(753, 28);
            this.Review.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(411, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(753, 40);
            this.label4.TabIndex = 12;
            this.label4.Text = "리뷰";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReviewRegisterButton
            // 
            this.ReviewRegisterButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ReviewRegisterButton.Location = new System.Drawing.Point(1185, 86);
            this.ReviewRegisterButton.Name = "ReviewRegisterButton";
            this.ReviewRegisterButton.Size = new System.Drawing.Size(74, 34);
            this.ReviewRegisterButton.TabIndex = 13;
            this.ReviewRegisterButton.Text = "등록";
            this.ReviewRegisterButton.UseVisualStyleBackColor = true;
            this.ReviewRegisterButton.Click += new System.EventHandler(this.ReviewRegisterButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(306, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "평점";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RevieiwPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MovieNM);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Review);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReviewRegisterButton);
            this.Controls.Add(this.label3);
            this.Name = "RevieiwPage";
            this.Size = new System.Drawing.Size(1536, 536);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieNM;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Review;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ReviewRegisterButton;
        private System.Windows.Forms.Label label3;

    }
}
