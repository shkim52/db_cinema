﻿namespace DB_Project_Cinema
{
    partial class Payment
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
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.UsePoint = new System.Windows.Forms.TextBox();
            this.SavePoint = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CardNumber1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CardPW = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TelDCPrice = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.DifferencePrice = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.TelNM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.PhoneVerification = new System.Windows.Forms.Button();
            this.CreditCard = new System.Windows.Forms.CheckBox();
            this.AccountTransfer = new System.Windows.Forms.CheckBox();
            this.CardCategory = new System.Windows.Forms.ComboBox();
            this.BankCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AccountNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AccountPW = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ApprovalRequest = new System.Windows.Forms.Button();
            this.AccountVerification = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.PointDc = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.CardNumber2 = new System.Windows.Forms.TextBox();
            this.CardNumber3 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.CardNumber4 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(628, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 42;
            this.label1.Text = "PAYMENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(302, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "통신 카드사 할인";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(650, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "기본 결제";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(315, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 45;
            this.label5.Text = "통신사:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(302, 314);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(310, 29);
            this.label9.TabIndex = 49;
            this.label9.Text = "포인트 할인";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(302, 346);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 29);
            this.label10.TabIndex = 50;
            this.label10.Text = "현재 보유 포인트:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(302, 375);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 38);
            this.label11.TabIndex = 51;
            this.label11.Text = "사용할 포인트:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UsePoint
            // 
            this.UsePoint.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UsePoint.Location = new System.Drawing.Point(466, 382);
            this.UsePoint.Margin = new System.Windows.Forms.Padding(2);
            this.UsePoint.MaxLength = 7;
            this.UsePoint.Name = "UsePoint";
            this.UsePoint.Size = new System.Drawing.Size(74, 27);
            this.UsePoint.TabIndex = 56;
            this.UsePoint.Text = "0";
            this.UsePoint.TextChanged += new System.EventHandler(this.UsePoint_TextChanged);
            this.UsePoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsePoint_KeyPress);
            // 
            // SavePoint
            // 
            this.SavePoint.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SavePoint.Location = new System.Drawing.Point(462, 346);
            this.SavePoint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SavePoint.Name = "SavePoint";
            this.SavePoint.Size = new System.Drawing.Size(73, 29);
            this.SavePoint.TabIndex = 59;
            this.SavePoint.Text = "0";
            this.SavePoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(670, 196);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 29);
            this.label14.TabIndex = 61;
            this.label14.Text = "카드종류:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(670, 228);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 29);
            this.label15.TabIndex = 62;
            this.label15.Text = "카드번호:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CardNumber1
            // 
            this.CardNumber1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CardNumber1.Location = new System.Drawing.Point(751, 229);
            this.CardNumber1.Margin = new System.Windows.Forms.Padding(2);
            this.CardNumber1.MaxLength = 4;
            this.CardNumber1.Name = "CardNumber1";
            this.CardNumber1.Size = new System.Drawing.Size(37, 27);
            this.CardNumber1.TabIndex = 63;
            this.CardNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumber_KeyPress);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(670, 259);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 29);
            this.label17.TabIndex = 64;
            this.label17.Text = "비밀번호:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CardPW
            // 
            this.CardPW.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CardPW.Location = new System.Drawing.Point(751, 261);
            this.CardPW.Margin = new System.Windows.Forms.Padding(2);
            this.CardPW.MaxLength = 4;
            this.CardPW.Name = "CardPW";
            this.CardPW.PasswordChar = '*';
            this.CardPW.Size = new System.Drawing.Size(193, 27);
            this.CardPW.TabIndex = 65;
            this.CardPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardPW_KeyPress);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Wheat;
            this.label16.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(1034, 125);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(179, 29);
            this.label16.TabIndex = 67;
            this.label16.Text = "총 결제금액";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPrice
            // 
            this.TotalPrice.BackColor = System.Drawing.Color.OldLace;
            this.TotalPrice.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TotalPrice.Location = new System.Drawing.Point(1034, 154);
            this.TotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(179, 29);
            this.TotalPrice.TabIndex = 68;
            this.TotalPrice.Text = "0";
            this.TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Wheat;
            this.label19.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(1034, 183);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(179, 29);
            this.label19.TabIndex = 69;
            this.label19.Text = "통신사 할인금액";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelDCPrice
            // 
            this.TelDCPrice.BackColor = System.Drawing.Color.OldLace;
            this.TelDCPrice.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TelDCPrice.Location = new System.Drawing.Point(1034, 213);
            this.TelDCPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TelDCPrice.Name = "TelDCPrice";
            this.TelDCPrice.Size = new System.Drawing.Size(179, 29);
            this.TelDCPrice.TabIndex = 70;
            this.TelDCPrice.Text = "0";
            this.TelDCPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Wheat;
            this.label21.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(1034, 300);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(179, 29);
            this.label21.TabIndex = 71;
            this.label21.Text = "남은 결제금액";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DifferencePrice
            // 
            this.DifferencePrice.BackColor = System.Drawing.Color.OldLace;
            this.DifferencePrice.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DifferencePrice.Location = new System.Drawing.Point(1034, 329);
            this.DifferencePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DifferencePrice.Name = "DifferencePrice";
            this.DifferencePrice.Size = new System.Drawing.Size(179, 29);
            this.DifferencePrice.TabIndex = 72;
            this.DifferencePrice.Text = "0";
            this.DifferencePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label24.Location = new System.Drawing.Point(539, 346);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 29);
            this.label24.TabIndex = 74;
            this.label24.Text = "Point";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaymentButton
            // 
            this.PaymentButton.BackColor = System.Drawing.Color.IndianRed;
            this.PaymentButton.FlatAppearance.BorderSize = 0;
            this.PaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentButton.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PaymentButton.ForeColor = System.Drawing.Color.White;
            this.PaymentButton.Location = new System.Drawing.Point(1108, 412);
            this.PaymentButton.Margin = new System.Windows.Forms.Padding(2);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(105, 38);
            this.PaymentButton.TabIndex = 77;
            this.PaymentButton.Text = "v 결제하기";
            this.PaymentButton.UseVisualStyleBackColor = false;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // TelNM
            // 
            this.TelNM.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TelNM.FormattingEnabled = true;
            this.TelNM.Location = new System.Drawing.Point(411, 156);
            this.TelNM.Margin = new System.Windows.Forms.Padding(2);
            this.TelNM.Name = "TelNM";
            this.TelNM.Size = new System.Drawing.Size(167, 28);
            this.TelNM.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(299, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 79;
            this.label4.Text = "휴대폰 번호:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(411, 204);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneNumber.MaxLength = 11;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(167, 25);
            this.PhoneNumber.TabIndex = 80;
            this.PhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumber_KeyPress_1);
            // 
            // PhoneVerification
            // 
            this.PhoneVerification.BackColor = System.Drawing.Color.LightGray;
            this.PhoneVerification.FlatAppearance.BorderSize = 0;
            this.PhoneVerification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PhoneVerification.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PhoneVerification.Location = new System.Drawing.Point(485, 245);
            this.PhoneVerification.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneVerification.Name = "PhoneVerification";
            this.PhoneVerification.Size = new System.Drawing.Size(93, 27);
            this.PhoneVerification.TabIndex = 81;
            this.PhoneVerification.Text = "휴대폰 인증";
            this.PhoneVerification.UseVisualStyleBackColor = false;
            this.PhoneVerification.Click += new System.EventHandler(this.PhoneVerification_Click);
            // 
            // CreditCard
            // 
            this.CreditCard.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CreditCard.Location = new System.Drawing.Point(659, 153);
            this.CreditCard.Margin = new System.Windows.Forms.Padding(2);
            this.CreditCard.Name = "CreditCard";
            this.CreditCard.Size = new System.Drawing.Size(110, 30);
            this.CreditCard.TabIndex = 82;
            this.CreditCard.Text = "신용카드";
            this.CreditCard.UseVisualStyleBackColor = true;
            this.CreditCard.Click += new System.EventHandler(this.CreditCard_Click);
            // 
            // AccountTransfer
            // 
            this.AccountTransfer.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AccountTransfer.Location = new System.Drawing.Point(650, 314);
            this.AccountTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.AccountTransfer.Name = "AccountTransfer";
            this.AccountTransfer.Size = new System.Drawing.Size(110, 25);
            this.AccountTransfer.TabIndex = 83;
            this.AccountTransfer.Text = "계좌이체";
            this.AccountTransfer.UseVisualStyleBackColor = true;
            this.AccountTransfer.Click += new System.EventHandler(this.AccountTransfer_Click);
            // 
            // CardCategory
            // 
            this.CardCategory.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CardCategory.FormattingEnabled = true;
            this.CardCategory.Items.AddRange(new object[] {
            "신한카드",
            "KB국민카드",
            "NH농협카드",
            "삼성카드",
            "현대카드",
            "우리카드",
            "하나카드",
            "롯데카드"});
            this.CardCategory.Location = new System.Drawing.Point(751, 197);
            this.CardCategory.Margin = new System.Windows.Forms.Padding(2);
            this.CardCategory.Name = "CardCategory";
            this.CardCategory.Size = new System.Drawing.Size(193, 28);
            this.CardCategory.TabIndex = 84;
            this.CardCategory.Text = "신한카드";
            // 
            // BankCategory
            // 
            this.BankCategory.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BankCategory.FormattingEnabled = true;
            this.BankCategory.Items.AddRange(new object[] {
            "신한은행",
            "KB국민은행",
            "NH농협은행",
            "우리은행",
            "KEB하나은행"});
            this.BankCategory.Location = new System.Drawing.Point(751, 351);
            this.BankCategory.Margin = new System.Windows.Forms.Padding(2);
            this.BankCategory.Name = "BankCategory";
            this.BankCategory.Size = new System.Drawing.Size(193, 28);
            this.BankCategory.TabIndex = 90;
            this.BankCategory.Text = "신한은행";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(646, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 29);
            this.label6.TabIndex = 85;
            this.label6.Text = "게좌이체은행:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(670, 382);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 29);
            this.label7.TabIndex = 91;
            this.label7.Text = "게좌번호:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AccountNumber
            // 
            this.AccountNumber.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AccountNumber.Location = new System.Drawing.Point(751, 384);
            this.AccountNumber.Margin = new System.Windows.Forms.Padding(2);
            this.AccountNumber.MaxLength = 15;
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Size = new System.Drawing.Size(193, 27);
            this.AccountNumber.TabIndex = 92;
            this.AccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountNumber_KeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(670, 414);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 29);
            this.label8.TabIndex = 93;
            this.label8.Text = "비밀번호:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AccountPW
            // 
            this.AccountPW.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AccountPW.Location = new System.Drawing.Point(751, 415);
            this.AccountPW.Margin = new System.Windows.Forms.Padding(2);
            this.AccountPW.MaxLength = 4;
            this.AccountPW.Name = "AccountPW";
            this.AccountPW.PasswordChar = '*';
            this.AccountPW.Size = new System.Drawing.Size(193, 27);
            this.AccountPW.TabIndex = 94;
            this.AccountPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AccountPW_KeyPress);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Malgun Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.IndianRed;
            this.label12.Location = new System.Drawing.Point(300, 426);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(342, 26);
            this.label12.TabIndex = 95;
            this.label12.Text = "* 적립포인트는 1000Point 이상부터 사용할 수 있습니다.";
            // 
            // ApprovalRequest
            // 
            this.ApprovalRequest.BackColor = System.Drawing.Color.LightGray;
            this.ApprovalRequest.FlatAppearance.BorderSize = 0;
            this.ApprovalRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApprovalRequest.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ApprovalRequest.Location = new System.Drawing.Point(850, 303);
            this.ApprovalRequest.Margin = new System.Windows.Forms.Padding(2);
            this.ApprovalRequest.Name = "ApprovalRequest";
            this.ApprovalRequest.Size = new System.Drawing.Size(93, 27);
            this.ApprovalRequest.TabIndex = 96;
            this.ApprovalRequest.Text = "승인요청";
            this.ApprovalRequest.UseVisualStyleBackColor = false;
            this.ApprovalRequest.Click += new System.EventHandler(this.ApprovalRequest_Click);
            // 
            // AccountVerification
            // 
            this.AccountVerification.BackColor = System.Drawing.Color.LightGray;
            this.AccountVerification.FlatAppearance.BorderSize = 0;
            this.AccountVerification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountVerification.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.AccountVerification.Location = new System.Drawing.Point(850, 459);
            this.AccountVerification.Margin = new System.Windows.Forms.Padding(2);
            this.AccountVerification.Name = "AccountVerification";
            this.AccountVerification.Size = new System.Drawing.Size(93, 27);
            this.AccountVerification.TabIndex = 97;
            this.AccountVerification.Text = "계좌검증";
            this.AccountVerification.UseVisualStyleBackColor = false;
            this.AccountVerification.Click += new System.EventHandler(this.AccountVerification_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Wheat;
            this.label13.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(1034, 242);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 29);
            this.label13.TabIndex = 98;
            this.label13.Text = "포인트";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PointDc
            // 
            this.PointDc.BackColor = System.Drawing.Color.OldLace;
            this.PointDc.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PointDc.Location = new System.Drawing.Point(1034, 271);
            this.PointDc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PointDc.Name = "PointDc";
            this.PointDc.Size = new System.Drawing.Size(179, 29);
            this.PointDc.TabIndex = 99;
            this.PointDc.Text = "0";
            this.PointDc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Malgun Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.IndianRed;
            this.label18.Location = new System.Drawing.Point(300, 452);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(313, 33);
            this.label18.TabIndex = 100;
            this.label18.Text = "* 포인트 할인은 신용카드 승인을 받거나 계좌검증을 받았을 시에 적용됩니다.";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(791, 233);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(8, 23);
            this.label20.TabIndex = 104;
            this.label20.Text = "-";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardNumber2
            // 
            this.CardNumber2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CardNumber2.Location = new System.Drawing.Point(803, 229);
            this.CardNumber2.Margin = new System.Windows.Forms.Padding(2);
            this.CardNumber2.MaxLength = 4;
            this.CardNumber2.Name = "CardNumber2";
            this.CardNumber2.Size = new System.Drawing.Size(37, 27);
            this.CardNumber2.TabIndex = 107;
            this.CardNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumber2_KeyPress);
            // 
            // CardNumber3
            // 
            this.CardNumber3.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CardNumber3.Location = new System.Drawing.Point(853, 229);
            this.CardNumber3.Margin = new System.Windows.Forms.Padding(2);
            this.CardNumber3.MaxLength = 4;
            this.CardNumber3.Name = "CardNumber3";
            this.CardNumber3.Size = new System.Drawing.Size(37, 27);
            this.CardNumber3.TabIndex = 110;
            this.CardNumber3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumber3_KeyPress);
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(841, 233);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(8, 23);
            this.label25.TabIndex = 109;
            this.label25.Text = "-";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardNumber4
            // 
            this.CardNumber4.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CardNumber4.Location = new System.Drawing.Point(907, 229);
            this.CardNumber4.Margin = new System.Windows.Forms.Padding(2);
            this.CardNumber4.MaxLength = 4;
            this.CardNumber4.Name = "CardNumber4";
            this.CardNumber4.Size = new System.Drawing.Size(37, 27);
            this.CardNumber4.TabIndex = 112;
            this.CardNumber4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CardNumber4_KeyPress);
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(895, 233);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(8, 23);
            this.label26.TabIndex = 111;
            this.label26.Text = "-";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CardNumber4);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.CardNumber3);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.CardNumber2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PointDc);
            this.Controls.Add(this.AccountVerification);
            this.Controls.Add(this.ApprovalRequest);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AccountNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AccountPW);
            this.Controls.Add(this.BankCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CardCategory);
            this.Controls.Add(this.AccountTransfer);
            this.Controls.Add(this.CreditCard);
            this.Controls.Add(this.PhoneVerification);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TelNM);
            this.Controls.Add(this.PaymentButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.UsePoint);
            this.Controls.Add(this.SavePoint);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CardNumber1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CardPW);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.TelDCPrice);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.DifferencePrice);
            this.Controls.Add(this.label24);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(1368, 641);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox UsePoint;
        private System.Windows.Forms.Label SavePoint;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox CardNumber1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox CardPW;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label TelDCPrice;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label DifferencePrice;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.ComboBox TelNM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Button PhoneVerification;
        private System.Windows.Forms.CheckBox CreditCard;
        private System.Windows.Forms.CheckBox AccountTransfer;
        private System.Windows.Forms.ComboBox CardCategory;
        private System.Windows.Forms.ComboBox BankCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AccountNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AccountPW;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ApprovalRequest;
        private System.Windows.Forms.Button AccountVerification;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label PointDc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox CardNumber2;
        private System.Windows.Forms.TextBox CardNumber3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox CardNumber4;
        private System.Windows.Forms.Label label26;

    }
}
