namespace DB_Project_Cinema
{
    partial class ScreenInfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ScreenNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenIntro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenSeatCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(405, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 61);
            this.label1.TabIndex = 6;
            this.label1.Text = "SCREEN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScreenNM,
            this.ScreenIntro,
            this.ScreenSeatCnt});
            this.dataGridView1.Location = new System.Drawing.Point(279, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(752, 592);
            this.dataGridView1.TabIndex = 17;
            // 
            // ScreenNM
            // 
            this.ScreenNM.HeaderText = "상영관 이름";
            this.ScreenNM.Name = "ScreenNM";
            this.ScreenNM.ReadOnly = true;
            this.ScreenNM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ScreenIntro
            // 
            this.ScreenIntro.FillWeight = 300F;
            this.ScreenIntro.HeaderText = "상영관 설명";
            this.ScreenIntro.Name = "ScreenIntro";
            this.ScreenIntro.ReadOnly = true;
            this.ScreenIntro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ScreenIntro.Width = 300;
            // 
            // ScreenSeatCnt
            // 
            this.ScreenSeatCnt.HeaderText = "좌석 수";
            this.ScreenSeatCnt.Name = "ScreenSeatCnt";
            this.ScreenSeatCnt.ReadOnly = true;
            this.ScreenSeatCnt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ScreenInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ScreenInfo";
            this.Size = new System.Drawing.Size(1326, 869);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenNM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenIntro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenSeatCnt;

    }
}
