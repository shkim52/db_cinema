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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.FindIDButton = new System.Windows.Forms.Button();
            this.FindID = new DB_Project_Cinema.FindID();
            this.FindPW = new DB_Project_Cinema.FindPW();
            this.FindPWButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.FindIDButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.FindPWButton, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47519F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.30943F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.21538F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 269);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(240, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find ID/PW";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FindIDButton
            // 
            this.FindIDButton.BackColor = System.Drawing.Color.LightGray;
            this.FindIDButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindIDButton.FlatAppearance.BorderSize = 0;
            this.FindIDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindIDButton.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FindIDButton.Location = new System.Drawing.Point(405, 220);
            this.FindIDButton.Name = "FindIDButton";
            this.FindIDButton.Size = new System.Drawing.Size(154, 46);
            this.FindIDButton.TabIndex = 2;
            this.FindIDButton.Text = "아이디 찾기";
            this.FindIDButton.UseVisualStyleBackColor = false;
            this.FindIDButton.Click += new System.EventHandler(this.FindIDButton_Click);
            // 
            // FindID
            // 
            this.FindID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindID.Location = new System.Drawing.Point(0, 269);
            this.FindID.Name = "FindID";
            this.FindID.Size = new System.Drawing.Size(800, 150);
            this.FindID.TabIndex = 2;
            // 
            // FindPW
            // 
            this.FindPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindPW.Location = new System.Drawing.Point(0, 269);
            this.FindPW.Name = "FindPW";
            this.FindPW.Size = new System.Drawing.Size(800, 150);
            this.FindPW.TabIndex = 3;
            // 
            // FindPWButton
            // 
            this.FindPWButton.BackColor = System.Drawing.Color.LightGray;
            this.FindPWButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindPWButton.FlatAppearance.BorderSize = 0;
            this.FindPWButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindPWButton.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FindPWButton.Location = new System.Drawing.Point(240, 220);
            this.FindPWButton.Name = "FindPWButton";
            this.FindPWButton.Size = new System.Drawing.Size(154, 46);
            this.FindPWButton.TabIndex = 3;
            this.FindPWButton.Text = "비밀번호 찾기";
            this.FindPWButton.UseVisualStyleBackColor = false;
            this.FindPWButton.Click += new System.EventHandler(this.FindPWButton_Click);
            // 
            // FindIDandPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FindPW);
            this.Controls.Add(this.FindID);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FindIDandPW";
            this.Size = new System.Drawing.Size(800, 419);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FindIDButton;
        private FindID FindID;
        private FindPW FindPW;
        private System.Windows.Forms.Button FindPWButton;
    }
}
