namespace DB_Project_Cinema
{
    partial class LoginPage
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
            this.MemLoginButton = new System.Windows.Forms.Button();
            this.CustLoginButton = new System.Windows.Forms.Button();
            this.LoginCustomer = new DB_Project_Cinema.LoginCustomer();
            this.LoginMember = new DB_Project_Cinema.LoginMember();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MemLoginButton);
            this.panel1.Controls.Add(this.CustLoginButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 282);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(687, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemLoginButton
            // 
            this.MemLoginButton.BackColor = System.Drawing.Color.LightGray;
            this.MemLoginButton.FlatAppearance.BorderSize = 0;
            this.MemLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemLoginButton.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemLoginButton.Location = new System.Drawing.Point(640, 231);
            this.MemLoginButton.Name = "MemLoginButton";
            this.MemLoginButton.Size = new System.Drawing.Size(89, 45);
            this.MemLoginButton.TabIndex = 4;
            this.MemLoginButton.Text = "회원";
            this.MemLoginButton.UseVisualStyleBackColor = false;
            this.MemLoginButton.Click += new System.EventHandler(this.MemLoginButton_Click_1);
            // 
            // CustLoginButton
            // 
            this.CustLoginButton.BackColor = System.Drawing.Color.LightGray;
            this.CustLoginButton.FlatAppearance.BorderSize = 0;
            this.CustLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustLoginButton.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CustLoginButton.Location = new System.Drawing.Point(740, 231);
            this.CustLoginButton.Name = "CustLoginButton";
            this.CustLoginButton.Size = new System.Drawing.Size(89, 45);
            this.CustLoginButton.TabIndex = 5;
            this.CustLoginButton.Text = "비회원";
            this.CustLoginButton.UseVisualStyleBackColor = false;
            this.CustLoginButton.Click += new System.EventHandler(this.CustLoginButton_Click_1);
            // 
            // LoginCustomer
            // 
            this.LoginCustomer.BackColor = System.Drawing.Color.White;
            this.LoginCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginCustomer.Location = new System.Drawing.Point(0, 282);
            this.LoginCustomer.Name = "LoginCustomer";
            this.LoginCustomer.Size = new System.Drawing.Size(1354, 256);
            this.LoginCustomer.TabIndex = 5;
            // 
            // LoginMember
            // 
            this.LoginMember.BackColor = System.Drawing.Color.White;
            this.LoginMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMember.Location = new System.Drawing.Point(0, 282);
            this.LoginMember.Name = "LoginMember";
            this.LoginMember.Size = new System.Drawing.Size(1354, 256);
            this.LoginMember.TabIndex = 4;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LoginCustomer);
            this.Controls.Add(this.LoginMember);
            this.Controls.Add(this.panel1);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(1354, 538);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MemLoginButton;
        private System.Windows.Forms.Button CustLoginButton;
        private LoginMember LoginMember;
        private LoginCustomer LoginCustomer;

    }
}
