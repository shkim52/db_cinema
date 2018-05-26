namespace DB_Project_Cinema
{
    partial class MyPageConfirmPW
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ConfirmaPWButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(279, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(448, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "회원 ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(279, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "비밀번호 확인:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(448, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 34);
            this.textBox1.TabIndex = 10;
            // 
            // ConfirmaPWButton
            // 
            this.ConfirmaPWButton.BackColor = System.Drawing.Color.LightGray;
            this.ConfirmaPWButton.FlatAppearance.BorderSize = 0;
            this.ConfirmaPWButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmaPWButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConfirmaPWButton.Location = new System.Drawing.Point(448, 402);
            this.ConfirmaPWButton.Name = "ConfirmaPWButton";
            this.ConfirmaPWButton.Size = new System.Drawing.Size(127, 45);
            this.ConfirmaPWButton.TabIndex = 11;
            this.ConfirmaPWButton.Text = "확인하기";
            this.ConfirmaPWButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(251, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 48);
            this.label1.TabIndex = 12;
            this.label1.Text = "MyPage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyPageConfirmPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ConfirmaPWButton);
            this.Controls.Add(this.label1);
            this.Name = "MyPageConfirmPW";
            this.Size = new System.Drawing.Size(1047, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ConfirmaPWButton;
        private System.Windows.Forms.Label label1;

    }
}
