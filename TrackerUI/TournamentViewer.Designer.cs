namespace TrackerUI
{
	partial class TournamentViewer
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewer));
			LBL_Header = new Label();
			LBL_Round = new Label();
			CMB_Round = new ComboBox();
			LBL_TournamentName = new Label();
			CHK_UnplayedOnly = new CheckBox();
			LSB_Matchup = new ListBox();
			LBL_Team1Name = new Label();
			LBL_Team1Score = new Label();
			TXT_Team1Score = new TextBox();
			TXT_Team2Score = new TextBox();
			LBL_Team2Score = new Label();
			LBL_Team2Name = new Label();
			LBL_Versus = new Label();
			BTN_Score = new Button();
			BTN_CreateTeam = new Button();
			SuspendLayout();
			// 
			// LBL_Header
			// 
			LBL_Header.AutoSize = true;
			LBL_Header.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_Header.ForeColor = SystemColors.MenuHighlight;
			LBL_Header.Location = new Point(13, 14);
			LBL_Header.Name = "LBL_Header";
			LBL_Header.Size = new Size(217, 51);
			LBL_Header.TabIndex = 0;
			LBL_Header.Text = "Tournament:";
			// 
			// LBL_Round
			// 
			LBL_Round.AutoSize = true;
			LBL_Round.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_Round.ForeColor = SystemColors.MenuHighlight;
			LBL_Round.Location = new Point(20, 94);
			LBL_Round.Name = "LBL_Round";
			LBL_Round.Size = new Size(94, 37);
			LBL_Round.TabIndex = 2;
			LBL_Round.Text = "Round";
			// 
			// CMB_Round
			// 
			CMB_Round.FormattingEnabled = true;
			CMB_Round.Location = new Point(120, 93);
			CMB_Round.Name = "CMB_Round";
			CMB_Round.Size = new Size(415, 38);
			CMB_Round.TabIndex = 3;
			// 
			// LBL_TournamentName
			// 
			LBL_TournamentName.AutoSize = true;
			LBL_TournamentName.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_TournamentName.ForeColor = SystemColors.MenuHighlight;
			LBL_TournamentName.Location = new Point(231, 14);
			LBL_TournamentName.Name = "LBL_TournamentName";
			LBL_TournamentName.Size = new Size(161, 51);
			LBL_TournamentName.TabIndex = 4;
			LBL_TournamentName.Text = "<name>";
			LBL_TournamentName.Click += label1_Click;
			// 
			// CHK_UnplayedOnly
			// 
			CHK_UnplayedOnly.AutoSize = true;
			CHK_UnplayedOnly.FlatStyle = FlatStyle.Flat;
			CHK_UnplayedOnly.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			CHK_UnplayedOnly.ForeColor = SystemColors.MenuHighlight;
			CHK_UnplayedOnly.Location = new Point(120, 137);
			CHK_UnplayedOnly.Name = "CHK_UnplayedOnly";
			CHK_UnplayedOnly.Size = new Size(209, 41);
			CHK_UnplayedOnly.TabIndex = 5;
			CHK_UnplayedOnly.Text = "Unplayed Only";
			CHK_UnplayedOnly.UseVisualStyleBackColor = true;
			// 
			// LSB_Matchup
			// 
			LSB_Matchup.BorderStyle = BorderStyle.FixedSingle;
			LSB_Matchup.FormattingEnabled = true;
			LSB_Matchup.ItemHeight = 30;
			LSB_Matchup.Location = new Point(29, 213);
			LSB_Matchup.Name = "LSB_Matchup";
			LSB_Matchup.Size = new Size(472, 422);
			LSB_Matchup.TabIndex = 6;
			// 
			// LBL_Team1Name
			// 
			LBL_Team1Name.AutoSize = true;
			LBL_Team1Name.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_Team1Name.ForeColor = SystemColors.MenuHighlight;
			LBL_Team1Name.Location = new Point(544, 213);
			LBL_Team1Name.Name = "LBL_Team1Name";
			LBL_Team1Name.Size = new Size(119, 37);
			LBL_Team1Name.TabIndex = 7;
			LBL_Team1Name.Text = "<name>";
			// 
			// LBL_Team1Score
			// 
			LBL_Team1Score.AutoSize = true;
			LBL_Team1Score.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_Team1Score.ForeColor = SystemColors.MenuHighlight;
			LBL_Team1Score.Location = new Point(559, 267);
			LBL_Team1Score.Name = "LBL_Team1Score";
			LBL_Team1Score.Size = new Size(82, 37);
			LBL_Team1Score.TabIndex = 8;
			LBL_Team1Score.Text = "Score";
			// 
			// TXT_Team1Score
			// 
			TXT_Team1Score.Location = new Point(646, 269);
			TXT_Team1Score.Name = "TXT_Team1Score";
			TXT_Team1Score.Size = new Size(225, 35);
			TXT_Team1Score.TabIndex = 9;
			// 
			// TXT_Team2Score
			// 
			TXT_Team2Score.Location = new Point(647, 471);
			TXT_Team2Score.Name = "TXT_Team2Score";
			TXT_Team2Score.Size = new Size(225, 35);
			TXT_Team2Score.TabIndex = 12;
			// 
			// LBL_Team2Score
			// 
			LBL_Team2Score.AutoSize = true;
			LBL_Team2Score.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_Team2Score.ForeColor = SystemColors.MenuHighlight;
			LBL_Team2Score.Location = new Point(559, 469);
			LBL_Team2Score.Name = "LBL_Team2Score";
			LBL_Team2Score.Size = new Size(82, 37);
			LBL_Team2Score.TabIndex = 11;
			LBL_Team2Score.Text = "Score";
			// 
			// LBL_Team2Name
			// 
			LBL_Team2Name.AutoSize = true;
			LBL_Team2Name.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_Team2Name.ForeColor = SystemColors.MenuHighlight;
			LBL_Team2Name.Location = new Point(544, 409);
			LBL_Team2Name.Name = "LBL_Team2Name";
			LBL_Team2Name.Size = new Size(119, 37);
			LBL_Team2Name.TabIndex = 10;
			LBL_Team2Name.Text = "<name>";
			// 
			// LBL_Versus
			// 
			LBL_Versus.AutoSize = true;
			LBL_Versus.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_Versus.ForeColor = SystemColors.MenuHighlight;
			LBL_Versus.Location = new Point(678, 350);
			LBL_Versus.Name = "LBL_Versus";
			LBL_Versus.Size = new Size(57, 30);
			LBL_Versus.TabIndex = 13;
			LBL_Versus.Text = "-VS-";
			LBL_Versus.Click += LBL_Versus_Click;
			// 
			// BTN_Score
			// 
			BTN_Score.FlatAppearance.BorderColor = Color.Silver;
			BTN_Score.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			BTN_Score.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			BTN_Score.FlatStyle = FlatStyle.Flat;
			BTN_Score.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
			BTN_Score.ForeColor = SystemColors.MenuHighlight;
			BTN_Score.Location = new Point(866, 350);
			BTN_Score.Name = "BTN_Score";
			BTN_Score.Size = new Size(139, 59);
			BTN_Score.TabIndex = 14;
			BTN_Score.Text = "Score";
			BTN_Score.UseVisualStyleBackColor = true;
			BTN_Score.Click += button1_Click;
			// 
			// BTN_CreateTeam
			// 
			BTN_CreateTeam.FlatAppearance.BorderColor = Color.Silver;
			BTN_CreateTeam.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			BTN_CreateTeam.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			BTN_CreateTeam.FlatStyle = FlatStyle.Flat;
			BTN_CreateTeam.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
			BTN_CreateTeam.ForeColor = SystemColors.MenuHighlight;
			BTN_CreateTeam.Location = new Point(463, 676);
			BTN_CreateTeam.Name = "BTN_CreateTeam";
			BTN_CreateTeam.Size = new Size(225, 41);
			BTN_CreateTeam.TabIndex = 24;
			BTN_CreateTeam.Text = "Create Team";
			BTN_CreateTeam.UseVisualStyleBackColor = true;
			// 
			// TournamentViewer
			// 
			AutoScaleDimensions = new SizeF(12F, 30F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1136, 768);
			Controls.Add(BTN_CreateTeam);
			Controls.Add(BTN_Score);
			Controls.Add(LBL_Versus);
			Controls.Add(TXT_Team2Score);
			Controls.Add(LBL_Team2Score);
			Controls.Add(LBL_Team2Name);
			Controls.Add(TXT_Team1Score);
			Controls.Add(LBL_Team1Score);
			Controls.Add(LBL_Team1Name);
			Controls.Add(LSB_Matchup);
			Controls.Add(CHK_UnplayedOnly);
			Controls.Add(LBL_TournamentName);
			Controls.Add(CMB_Round);
			Controls.Add(LBL_Round);
			Controls.Add(LBL_Header);
			Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(5, 6, 5, 6);
			Name = "TournamentViewer";
			Text = "Tournament Viewer";
			Load += TournamentViewer_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label LBL_Header;
		private Label LBL_Round;
		private ComboBox CMB_Round;
		private Label LBL_TournamentName;
		private CheckBox CHK_UnplayedOnly;
		private ListBox LSB_Matchup;
		private Label LBL_Team1Name;
		private Label LBL_Team1Score;
		private TextBox TXT_Team1Score;
		private TextBox TXT_Team2Score;
		private Label LBL_Team2Score;
		private Label LBL_Team2Name;
		private Label LBL_Versus;
		private Button BTN_Score;
		private Button BTN_CreateTeam;
	}
}