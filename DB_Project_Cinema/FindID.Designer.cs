﻿namespace DB_Project_Cinema
{
    partial class FindID
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
            this.SID_INPUT = new System.Windows.Forms.TextBox();
            this.TELNO_INPUT = new System.Windows.Forms.TextBox();
            this.FindIDButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(379, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "주민등록번호:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(390, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "휴대폰번호:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SID_INPUT
            // 
            this.SID_INPUT.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SID_INPUT.Location = new System.Drawing.Point(522, 18);
            this.SID_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.SID_INPUT.MaxLength = 13;
            this.SID_INPUT.Name = "SID_INPUT";
            this.SID_INPUT.PasswordChar = '*';
            this.SID_INPUT.Size = new System.Drawing.Size(211, 30);
            this.SID_INPUT.TabIndex = 7;
            // 
            // TELNO_INPUT
            // 
            this.TELNO_INPUT.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TELNO_INPUT.Location = new System.Drawing.Point(522, 62);
            this.TELNO_INPUT.Margin = new System.Windows.Forms.Padding(2);
            this.TELNO_INPUT.MaxLength = 11;
            this.TELNO_INPUT.Name = "TELNO_INPUT";
            this.TELNO_INPUT.Size = new System.Drawing.Size(211, 30);
            this.TELNO_INPUT.TabIndex = 8;
            // 
            // FindIDButton
            // 
            this.FindIDButton.BackColor = System.Drawing.Color.LightGray;
            this.FindIDButton.FlatAppearance.BorderSize = 0;
            this.FindIDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindIDButton.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FindIDButton.Location = new System.Drawing.Point(762, 16);
            this.FindIDButton.Margin = new System.Windows.Forms.Padding(2);
            this.FindIDButton.Name = "FindIDButton";
            this.FindIDButton.Size = new System.Drawing.Size(83, 77);
            this.FindIDButton.TabIndex = 9;
            this.FindIDButton.Text = "아이디 찾기";
            this.FindIDButton.UseVisualStyleBackColor = false;
            this.FindIDButton.Click += new System.EventHandler(this.FindIDButton_Click);
            // 
            // FindID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SID_INPUT);
            this.Controls.Add(this.TELNO_INPUT);
            this.Controls.Add(this.FindIDButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FindID";
            this.Size = new System.Drawing.Size(951, 392);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SID_INPUT;
        private System.Windows.Forms.TextBox TELNO_INPUT;
        private System.Windows.Forms.Button FindIDButton;

    }
}
