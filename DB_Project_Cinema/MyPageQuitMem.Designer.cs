﻿namespace DB_Project_Cinema
{
    partial class MyPageQuitMem
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
            this.label3 = new System.Windows.Forms.Label();
            this.QuitMemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(174, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 80);
            this.label1.TabIndex = 4;
            this.label1.Text = "MyPage";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(276, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "회원 탈퇴시 개인정보를 비롯한 모든 정보들이 삭제됩니다. ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(276, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "회원 탈퇴하시겠습니까?";
            // 
            // QuitMemButton
            // 
            this.QuitMemButton.BackColor = System.Drawing.Color.LightGray;
            this.QuitMemButton.FlatAppearance.BorderSize = 0;
            this.QuitMemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuitMemButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.QuitMemButton.Location = new System.Drawing.Point(610, 346);
            this.QuitMemButton.Name = "QuitMemButton";
            this.QuitMemButton.Size = new System.Drawing.Size(108, 49);
            this.QuitMemButton.TabIndex = 7;
            this.QuitMemButton.Text = "회원탈퇴";
            this.QuitMemButton.UseVisualStyleBackColor = false;
            // 
            // MyPageQuitMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuitMemButton);
            this.Name = "MyPageQuitMem";
            this.Size = new System.Drawing.Size(1043, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button QuitMemButton;

    }
}
