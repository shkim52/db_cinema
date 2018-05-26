namespace DB_Project_Cinema
{
    partial class FindIDandPW
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FindIDButton = new System.Windows.Forms.Button();
            this.FindPWButton = new System.Windows.Forms.Button();
            this.FindPW = new DB_Project_Cinema.FindPW();
            this.FindID = new DB_Project_Cinema.FindID();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FindIDButton);
            this.panel1.Controls.Add(this.FindPWButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 288);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(595, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find ID/PW";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FindIDButton
            // 
            this.FindIDButton.BackColor = System.Drawing.Color.LightGray;
            this.FindIDButton.FlatAppearance.BorderSize = 0;
            this.FindIDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindIDButton.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FindIDButton.Location = new System.Drawing.Point(602, 239);
            this.FindIDButton.Name = "FindIDButton";
            this.FindIDButton.Size = new System.Drawing.Size(154, 46);
            this.FindIDButton.TabIndex = 5;
            this.FindIDButton.Text = "아이디 찾기";
            this.FindIDButton.UseVisualStyleBackColor = false;
            this.FindIDButton.Click += new System.EventHandler(this.FindIDButton_Click_1);
            // 
            // FindPWButton
            // 
            this.FindPWButton.BackColor = System.Drawing.Color.LightGray;
            this.FindPWButton.FlatAppearance.BorderSize = 0;
            this.FindPWButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindPWButton.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FindPWButton.Location = new System.Drawing.Point(773, 239);
            this.FindPWButton.Name = "FindPWButton";
            this.FindPWButton.Size = new System.Drawing.Size(154, 46);
            this.FindPWButton.TabIndex = 6;
            this.FindPWButton.Text = "비밀번호 찾기";
            this.FindPWButton.UseVisualStyleBackColor = false;
            this.FindPWButton.Click += new System.EventHandler(this.FindPWButton_Click_1);
            // 
            // FindPW
            // 
            this.FindPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindPW.Location = new System.Drawing.Point(0, 288);
            this.FindPW.Margin = new System.Windows.Forms.Padding(2);
            this.FindPW.Name = "FindPW";
            this.FindPW.Size = new System.Drawing.Size(1256, 290);
            this.FindPW.TabIndex = 6;
            // 
            // FindID
            // 
            this.FindID.BackColor = System.Drawing.Color.White;
            this.FindID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindID.Location = new System.Drawing.Point(0, 288);
            this.FindID.Margin = new System.Windows.Forms.Padding(2);
            this.FindID.Name = "FindID";
            this.FindID.Size = new System.Drawing.Size(1256, 290);
            this.FindID.TabIndex = 5;
            // 
            // FindIDandPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FindPW);
            this.Controls.Add(this.FindID);
            this.Controls.Add(this.panel1);
            this.Name = "FindIDandPW";
            this.Size = new System.Drawing.Size(1256, 578);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FindIDButton;
        private System.Windows.Forms.Button FindPWButton;
        private FindID FindID;
        private FindPW FindPW;
    }
}
