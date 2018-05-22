namespace DB_Project_Cinema
{
    partial class CinemaProgram
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FindIDandPWButton = new System.Windows.Forms.Button();
            this.MyPageButton = new System.Windows.Forms.Button();
            this.JoinMembershipButton = new System.Windows.Forms.Button();
            this.LoginPageButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DiscountCardButton = new System.Windows.Forms.Button();
            this.ScreenInfoButton = new System.Windows.Forms.Button();
            this.TicketingPageButton = new System.Windows.Forms.Button();
            this.MoviePageButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MyPageMenu = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.JoinMembership = new DB_Project_Cinema.JoinMembership();
            this.MyPage = new DB_Project_Cinema.MyPage();
            this.DiscountCard = new DB_Project_Cinema.DiscountCard();
            this.ScreenInfo = new DB_Project_Cinema.ScreenInfo();
            this.LoginPage = new DB_Project_Cinema.LoginPage();
            this.FindIDandPW = new DB_Project_Cinema.FindIDandPW();
            this.MoviePage = new DB_Project_Cinema.MoviePage();
            this.TicketingPage = new DB_Project_Cinema.TicketingPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 658);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 114);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1160, 114);
            this.label2.TabIndex = 0;
            this.label2.Text = "주소 : 서울시 동대문구 서울시립대로 163\r\n고객센터 : 02-6490-2440~1\r\n소개 : 전체 8개의 상영관 2,100석 좌석 보유";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 105);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(173, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(376, 129);
            this.panel7.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 129);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEOUL CINEMA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.FindIDandPWButton);
            this.panel3.Controls.Add(this.MyPageButton);
            this.panel3.Controls.Add(this.JoinMembershipButton);
            this.panel3.Controls.Add(this.LoginPageButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1160, 40);
            this.panel3.TabIndex = 2;
            // 
            // FindIDandPWButton
            // 
            this.FindIDandPWButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindIDandPWButton.FlatAppearance.BorderSize = 0;
            this.FindIDandPWButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindIDandPWButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FindIDandPWButton.ForeColor = System.Drawing.Color.White;
            this.FindIDandPWButton.Location = new System.Drawing.Point(649, 0);
            this.FindIDandPWButton.Name = "FindIDandPWButton";
            this.FindIDandPWButton.Size = new System.Drawing.Size(122, 40);
            this.FindIDandPWButton.TabIndex = 3;
            this.FindIDandPWButton.Text = "ID/PW 찾기";
            this.FindIDandPWButton.UseVisualStyleBackColor = true;
            this.FindIDandPWButton.Click += new System.EventHandler(this.FindIDandPWButton_Click);
            // 
            // MyPageButton
            // 
            this.MyPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MyPageButton.FlatAppearance.BorderSize = 0;
            this.MyPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPageButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyPageButton.ForeColor = System.Drawing.Color.White;
            this.MyPageButton.Location = new System.Drawing.Point(934, 0);
            this.MyPageButton.Name = "MyPageButton";
            this.MyPageButton.Size = new System.Drawing.Size(100, 40);
            this.MyPageButton.TabIndex = 1;
            this.MyPageButton.Text = "My Page";
            this.MyPageButton.UseVisualStyleBackColor = true;
            this.MyPageButton.Click += new System.EventHandler(this.MyPageButton_Click);
            // 
            // JoinMembershipButton
            // 
            this.JoinMembershipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.JoinMembershipButton.FlatAppearance.BorderSize = 0;
            this.JoinMembershipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JoinMembershipButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JoinMembershipButton.ForeColor = System.Drawing.Color.White;
            this.JoinMembershipButton.Location = new System.Drawing.Point(797, 0);
            this.JoinMembershipButton.Name = "JoinMembershipButton";
            this.JoinMembershipButton.Size = new System.Drawing.Size(100, 40);
            this.JoinMembershipButton.TabIndex = 1;
            this.JoinMembershipButton.Text = "회원가입";
            this.JoinMembershipButton.UseVisualStyleBackColor = true;
            this.JoinMembershipButton.Click += new System.EventHandler(this.JoinMembershipButton_Click);
            // 
            // LoginPageButton
            // 
            this.LoginPageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginPageButton.FlatAppearance.BorderSize = 0;
            this.LoginPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginPageButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginPageButton.ForeColor = System.Drawing.Color.White;
            this.LoginPageButton.Location = new System.Drawing.Point(521, 0);
            this.LoginPageButton.Name = "LoginPageButton";
            this.LoginPageButton.Size = new System.Drawing.Size(100, 40);
            this.LoginPageButton.TabIndex = 0;
            this.LoginPageButton.Text = "로그인";
            this.LoginPageButton.UseVisualStyleBackColor = true;
            this.LoginPageButton.Click += new System.EventHandler(this.LoginPageButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.DiscountCardButton);
            this.panel4.Controls.Add(this.ScreenInfoButton);
            this.panel4.Controls.Add(this.TicketingPageButton);
            this.panel4.Controls.Add(this.MoviePageButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1160, 49);
            this.panel4.TabIndex = 3;
            // 
            // DiscountCardButton
            // 
            this.DiscountCardButton.FlatAppearance.BorderSize = 0;
            this.DiscountCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscountCardButton.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DiscountCardButton.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.DiscountCardButton.Location = new System.Drawing.Point(803, 0);
            this.DiscountCardButton.Name = "DiscountCardButton";
            this.DiscountCardButton.Size = new System.Drawing.Size(125, 48);
            this.DiscountCardButton.TabIndex = 8;
            this.DiscountCardButton.Text = "할인카드";
            this.DiscountCardButton.UseVisualStyleBackColor = true;
            this.DiscountCardButton.Click += new System.EventHandler(this.DiscountCardButton_Click);
            // 
            // ScreenInfoButton
            // 
            this.ScreenInfoButton.FlatAppearance.BorderSize = 0;
            this.ScreenInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScreenInfoButton.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ScreenInfoButton.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.ScreenInfoButton.Location = new System.Drawing.Point(588, 0);
            this.ScreenInfoButton.Name = "ScreenInfoButton";
            this.ScreenInfoButton.Size = new System.Drawing.Size(125, 48);
            this.ScreenInfoButton.TabIndex = 7;
            this.ScreenInfoButton.Text = "상영관";
            this.ScreenInfoButton.UseVisualStyleBackColor = true;
            this.ScreenInfoButton.Click += new System.EventHandler(this.ScreenInfoButton_Click);
            // 
            // TicketingPageButton
            // 
            this.TicketingPageButton.FlatAppearance.BorderSize = 0;
            this.TicketingPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketingPageButton.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TicketingPageButton.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.TicketingPageButton.Location = new System.Drawing.Point(390, 0);
            this.TicketingPageButton.Name = "TicketingPageButton";
            this.TicketingPageButton.Size = new System.Drawing.Size(125, 48);
            this.TicketingPageButton.TabIndex = 7;
            this.TicketingPageButton.Text = "예매";
            this.TicketingPageButton.UseVisualStyleBackColor = true;
            this.TicketingPageButton.Click += new System.EventHandler(this.TicketingPageButton_Click);
            // 
            // MoviePageButton
            // 
            this.MoviePageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MoviePageButton.FlatAppearance.BorderSize = 0;
            this.MoviePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoviePageButton.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MoviePageButton.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.MoviePageButton.Location = new System.Drawing.Point(205, 0);
            this.MoviePageButton.Name = "MoviePageButton";
            this.MoviePageButton.Size = new System.Drawing.Size(125, 48);
            this.MoviePageButton.TabIndex = 6;
            this.MoviePageButton.Text = "영화";
            this.MoviePageButton.UseVisualStyleBackColor = false;
            this.MoviePageButton.Click += new System.EventHandler(this.MoviePageButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 194);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 464);
            this.panel5.TabIndex = 4;
            // 
            // MyPageMenu
            // 
            this.MyPageMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.MyPageMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.MyPageMenu.Location = new System.Drawing.Point(980, 194);
            this.MyPageMenu.Name = "MyPageMenu";
            this.MyPageMenu.Size = new System.Drawing.Size(180, 464);
            this.MyPageMenu.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(180, 194);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(800, 45);
            this.panel8.TabIndex = 6;
            // 
            // JoinMembership
            // 
            this.JoinMembership.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JoinMembership.Location = new System.Drawing.Point(180, 239);
            this.JoinMembership.Name = "JoinMembership";
            this.JoinMembership.Size = new System.Drawing.Size(800, 419);
            this.JoinMembership.TabIndex = 25;
            // 
            // MyPage
            // 
            this.MyPage.BackColor = System.Drawing.Color.White;
            this.MyPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyPage.Location = new System.Drawing.Point(180, 239);
            this.MyPage.Name = "MyPage";
            this.MyPage.Size = new System.Drawing.Size(800, 419);
            this.MyPage.TabIndex = 26;
            // 
            // DiscountCard
            // 
            this.DiscountCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscountCard.Location = new System.Drawing.Point(180, 239);
            this.DiscountCard.Name = "DiscountCard";
            this.DiscountCard.Size = new System.Drawing.Size(800, 419);
            this.DiscountCard.TabIndex = 24;
            // 
            // ScreenInfo
            // 
            this.ScreenInfo.BackColor = System.Drawing.Color.White;
            this.ScreenInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenInfo.Location = new System.Drawing.Point(180, 239);
            this.ScreenInfo.Name = "ScreenInfo";
            this.ScreenInfo.Size = new System.Drawing.Size(800, 419);
            this.ScreenInfo.TabIndex = 11;
            // 
            // LoginPage
            // 
            this.LoginPage.BackColor = System.Drawing.Color.White;
            this.LoginPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginPage.Location = new System.Drawing.Point(180, 239);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(800, 419);
            this.LoginPage.TabIndex = 27;
            // 
            // FindIDandPW
            // 
            this.FindIDandPW.BackColor = System.Drawing.Color.White;
            this.FindIDandPW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindIDandPW.Location = new System.Drawing.Point(180, 239);
            this.FindIDandPW.Name = "FindIDandPW";
            this.FindIDandPW.Size = new System.Drawing.Size(800, 419);
            this.FindIDandPW.TabIndex = 28;
            // 
            // MoviePage
            // 
            this.MoviePage.BackColor = System.Drawing.Color.White;
            this.MoviePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviePage.Location = new System.Drawing.Point(180, 239);
            this.MoviePage.Name = "MoviePage";
            this.MoviePage.Size = new System.Drawing.Size(800, 419);
            this.MoviePage.TabIndex = 29;
            // 
            // TicketingPage
            // 
            this.TicketingPage.BackColor = System.Drawing.Color.White;
            this.TicketingPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketingPage.Location = new System.Drawing.Point(180, 239);
            this.TicketingPage.Name = "TicketingPage";
            this.TicketingPage.Size = new System.Drawing.Size(800, 419);
            this.TicketingPage.TabIndex = 30;
            // 
            // CinemaProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 772);
            this.Controls.Add(this.TicketingPage);
            this.Controls.Add(this.MoviePage);
            this.Controls.Add(this.FindIDandPW);
            this.Controls.Add(this.LoginPage);
            this.Controls.Add(this.JoinMembership);
            this.Controls.Add(this.MyPage);
            this.Controls.Add(this.DiscountCard);
            this.Controls.Add(this.ScreenInfo);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.MyPageMenu);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CinemaProgram";
            this.Text = "SEOUL CINEMA";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel MyPageMenu;
        private System.Windows.Forms.Button MyPageButton;
        private System.Windows.Forms.Button JoinMembershipButton;
        private System.Windows.Forms.Button LoginPageButton;
        private System.Windows.Forms.Button ScreenInfoButton;
        private System.Windows.Forms.Button TicketingPageButton;
        private System.Windows.Forms.Button MoviePageButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private ScreenInfo ScreenInfo;
        private System.Windows.Forms.Button DiscountCardButton;
        private DiscountCard DiscountCard;
        private JoinMembership JoinMembership;
        private MyPage MyPage;
        private LoginPage LoginPage;
        private FindIDandPW FindIDandPW;
        private System.Windows.Forms.Button FindIDandPWButton;
        private MoviePage MoviePage;
        private TicketingPage TicketingPage;
    }
}

