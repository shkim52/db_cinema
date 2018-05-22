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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.MemLoginButton = new System.Windows.Forms.Button();
            this.CustLoginButton = new System.Windows.Forms.Button();
            this.LoginMember = new DB_Project_Cinema.LoginMember();
            this.LoginCustomer = new DB_Project_Cinema.LoginCustomer();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MemLoginButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CustLoginButton, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47519F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.30943F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.21538F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 269);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(305, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MemLoginButton
            // 
            this.MemLoginButton.BackColor = System.Drawing.Color.LightGray;
            this.MemLoginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemLoginButton.FlatAppearance.BorderSize = 0;
            this.MemLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MemLoginButton.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemLoginButton.Location = new System.Drawing.Point(305, 220);
            this.MemLoginButton.Name = "MemLoginButton";
            this.MemLoginButton.Size = new System.Drawing.Size(89, 46);
            this.MemLoginButton.TabIndex = 1;
            this.MemLoginButton.Text = "회원";
            this.MemLoginButton.UseVisualStyleBackColor = false;
            this.MemLoginButton.Click += new System.EventHandler(this.MemLoginButton_Click);
            // 
            // CustLoginButton
            // 
            this.CustLoginButton.BackColor = System.Drawing.Color.LightGray;
            this.CustLoginButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustLoginButton.FlatAppearance.BorderSize = 0;
            this.CustLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustLoginButton.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CustLoginButton.Location = new System.Drawing.Point(405, 220);
            this.CustLoginButton.Name = "CustLoginButton";
            this.CustLoginButton.Size = new System.Drawing.Size(89, 46);
            this.CustLoginButton.TabIndex = 2;
            this.CustLoginButton.Text = "비회원";
            this.CustLoginButton.UseVisualStyleBackColor = false;
            this.CustLoginButton.Click += new System.EventHandler(this.CustLoginButton_Click);
            // 
            // LoginMember
            // 
            this.LoginMember.BackColor = System.Drawing.Color.White;
            this.LoginMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginMember.Location = new System.Drawing.Point(0, 269);
            this.LoginMember.Name = "LoginMember";
            this.LoginMember.Size = new System.Drawing.Size(800, 150);
            this.LoginMember.TabIndex = 1;
            // 
            // LoginCustomer
            // 
            this.LoginCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginCustomer.Location = new System.Drawing.Point(0, 269);
            this.LoginCustomer.Name = "LoginCustomer";
            this.LoginCustomer.Size = new System.Drawing.Size(800, 150);
            this.LoginCustomer.TabIndex = 2;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LoginCustomer);
            this.Controls.Add(this.LoginMember);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(800, 419);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MemLoginButton;
        private System.Windows.Forms.Button CustLoginButton;
        private LoginMember LoginMember;
        private LoginCustomer LoginCustomer;
    }
}
