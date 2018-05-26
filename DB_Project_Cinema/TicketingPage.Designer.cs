namespace DB_Project_Cinema
{
    partial class TicketingPage
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
            this.BackToSelcetTimeButton = new System.Windows.Forms.Button();
            this.BackToChooseSeatButton = new System.Windows.Forms.Button();
            this.PaymentPageButton = new System.Windows.Forms.Button();
            this.ChooseSeatPageButton = new System.Windows.Forms.Button();
            this.Payment = new DB_Project_Cinema.Payment();
            this.ChooseSeat = new DB_Project_Cinema.ChooseSeat();
            this.SelectShowTime = new DB_Project_Cinema.SelectShowTime();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PaymentPageButton);
            this.panel1.Controls.Add(this.ChooseSeatPageButton);
            this.panel1.Controls.Add(this.BackToSelcetTimeButton);
            this.panel1.Controls.Add(this.BackToChooseSeatButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1472, 89);
            this.panel1.TabIndex = 4;
            // 
            // BackToSelcetTimeButton
            // 
            this.BackToSelcetTimeButton.BackColor = System.Drawing.Color.IndianRed;
            this.BackToSelcetTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToSelcetTimeButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BackToSelcetTimeButton.ForeColor = System.Drawing.Color.White;
            this.BackToSelcetTimeButton.Location = new System.Drawing.Point(144, 17);
            this.BackToSelcetTimeButton.Name = "BackToSelcetTimeButton";
            this.BackToSelcetTimeButton.Size = new System.Drawing.Size(114, 44);
            this.BackToSelcetTimeButton.TabIndex = 4;
            this.BackToSelcetTimeButton.Text = "<-뒤로";
            this.BackToSelcetTimeButton.UseVisualStyleBackColor = false;
            this.BackToSelcetTimeButton.Click += new System.EventHandler(this.BackToSelcetTimeButton_Click_1);
            // 
            // BackToChooseSeatButton
            // 
            this.BackToChooseSeatButton.BackColor = System.Drawing.Color.IndianRed;
            this.BackToChooseSeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToChooseSeatButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BackToChooseSeatButton.ForeColor = System.Drawing.Color.White;
            this.BackToChooseSeatButton.Location = new System.Drawing.Point(144, 17);
            this.BackToChooseSeatButton.Name = "BackToChooseSeatButton";
            this.BackToChooseSeatButton.Size = new System.Drawing.Size(114, 44);
            this.BackToChooseSeatButton.TabIndex = 5;
            this.BackToChooseSeatButton.Text = "<-뒤로";
            this.BackToChooseSeatButton.UseVisualStyleBackColor = false;
            this.BackToChooseSeatButton.Click += new System.EventHandler(this.BackToChooseSeatButton_Click_1);
            // 
            // PaymentPageButton
            // 
            this.PaymentPageButton.BackColor = System.Drawing.Color.IndianRed;
            this.PaymentPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentPageButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PaymentPageButton.ForeColor = System.Drawing.Color.White;
            this.PaymentPageButton.Location = new System.Drawing.Point(1196, 17);
            this.PaymentPageButton.Name = "PaymentPageButton";
            this.PaymentPageButton.Size = new System.Drawing.Size(114, 44);
            this.PaymentPageButton.TabIndex = 6;
            this.PaymentPageButton.Text = "결제선택->";
            this.PaymentPageButton.UseVisualStyleBackColor = false;
            this.PaymentPageButton.Click += new System.EventHandler(this.PaymentPageButton_Click_1);
            // 
            // ChooseSeatPageButton
            // 
            this.ChooseSeatPageButton.BackColor = System.Drawing.Color.IndianRed;
            this.ChooseSeatPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseSeatPageButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChooseSeatPageButton.ForeColor = System.Drawing.Color.White;
            this.ChooseSeatPageButton.Location = new System.Drawing.Point(1196, 17);
            this.ChooseSeatPageButton.Name = "ChooseSeatPageButton";
            this.ChooseSeatPageButton.Size = new System.Drawing.Size(114, 44);
            this.ChooseSeatPageButton.TabIndex = 7;
            this.ChooseSeatPageButton.Text = "자리선택->";
            this.ChooseSeatPageButton.UseVisualStyleBackColor = false;
            this.ChooseSeatPageButton.Click += new System.EventHandler(this.ChooseSeatPageButton_Click_1);
            // 
            // Payment
            // 
            this.Payment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Payment.Location = new System.Drawing.Point(0, 0);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(1472, 415);
            this.Payment.TabIndex = 7;
            // 
            // ChooseSeat
            // 
            this.ChooseSeat.BackColor = System.Drawing.Color.White;
            this.ChooseSeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChooseSeat.Location = new System.Drawing.Point(0, 0);
            this.ChooseSeat.Margin = new System.Windows.Forms.Padding(2);
            this.ChooseSeat.Name = "ChooseSeat";
            this.ChooseSeat.Size = new System.Drawing.Size(1472, 415);
            this.ChooseSeat.TabIndex = 6;
            // 
            // SelectShowTime
            // 
            this.SelectShowTime.BackColor = System.Drawing.Color.White;
            this.SelectShowTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectShowTime.Location = new System.Drawing.Point(0, 0);
            this.SelectShowTime.Name = "SelectShowTime";
            this.SelectShowTime.Size = new System.Drawing.Size(1472, 415);
            this.SelectShowTime.TabIndex = 5;
            // 
            // TicketingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.ChooseSeat);
            this.Controls.Add(this.SelectShowTime);
            this.Controls.Add(this.panel1);
            this.Name = "TicketingPage";
            this.Size = new System.Drawing.Size(1472, 504);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackToSelcetTimeButton;
        private System.Windows.Forms.Button BackToChooseSeatButton;
        private System.Windows.Forms.Button PaymentPageButton;
        private System.Windows.Forms.Button ChooseSeatPageButton;
        private SelectShowTime SelectShowTime;
        private ChooseSeat ChooseSeat;
        private Payment Payment;
    }
}
