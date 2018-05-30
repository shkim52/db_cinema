namespace DB_Project_Cinema
{
    partial class FindPW
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
            this.label2 = new System.Windows.Forms.Label();
            this.ID_INPUT = new System.Windows.Forms.TextBox();
            this.SID_INPUT = new System.Windows.Forms.TextBox();
            this.FindPWButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(410, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "아이디:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(385, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "생년월일:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ID_INPUT
            // 
            this.ID_INPUT.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID_INPUT.Location = new System.Drawing.Point(518, 17);
            this.ID_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.ID_INPUT.Name = "ID_INPUT";
            this.ID_INPUT.Size = new System.Drawing.Size(204, 30);
            this.ID_INPUT.TabIndex = 7;
            // 
            // SID_INPUT
            // 
            this.SID_INPUT.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SID_INPUT.Location = new System.Drawing.Point(518, 58);
            this.SID_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.SID_INPUT.MaxLength = 13;
            this.SID_INPUT.Name = "SID_INPUT";
            this.SID_INPUT.Size = new System.Drawing.Size(204, 30);
            this.SID_INPUT.TabIndex = 8;
            // 
            // FindPWButton
            // 
            this.FindPWButton.BackColor = System.Drawing.Color.LightGray;
            this.FindPWButton.FlatAppearance.BorderSize = 0;
            this.FindPWButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindPWButton.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FindPWButton.Location = new System.Drawing.Point(757, 14);
            this.FindPWButton.Margin = new System.Windows.Forms.Padding(2);
            this.FindPWButton.Name = "FindPWButton";
            this.FindPWButton.Size = new System.Drawing.Size(93, 75);
            this.FindPWButton.TabIndex = 9;
            this.FindPWButton.Text = "비밀번호 찾기";
            this.FindPWButton.UseVisualStyleBackColor = false;
            this.FindPWButton.Click += new System.EventHandler(this.FindPWButton_Click);
            // 
            // FindPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID_INPUT);
            this.Controls.Add(this.SID_INPUT);
            this.Controls.Add(this.FindPWButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FindPW";
            this.Size = new System.Drawing.Size(1028, 391);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_INPUT;
        private System.Windows.Forms.TextBox SID_INPUT;
        private System.Windows.Forms.Button FindPWButton;

    }
}
