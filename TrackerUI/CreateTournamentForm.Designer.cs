namespace CreateTournamentForm
{
	partial class CreateTournamentForm
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
			LBL_Header = new Label();
			LBL_TournamentName = new Label();
			TXT_TournamentName = new TextBox();
			TXT_EntryFee = new TextBox();
			LBL_EntryFee = new Label();
			CMB_SelectTeam = new ComboBox();
			LBL_SelectTeam = new Label();
			LNK_AddNewTeam = new LinkLabel();
			BTN_AddTeam = new Button();
			BTN_CreatePrize = new Button();
			LSB_TournamentPlayers = new ListBox();
			LBL_TeamsPlayers = new Label();
			BTN_DeletePlayer = new Button();
			BTN_DeleteSelectedPrize = new Button();
			LBL_Prizes = new Label();
			LSB_Prizes = new ListBox();
			BTN_CreateTournament = new Button();
			SuspendLayout();
			// 
			// LBL_Header
			// 
			LBL_Header.AutoSize = true;
			LBL_Header.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_Header.ForeColor = SystemColors.MenuHighlight;
			LBL_Header.Location = new Point(12, 9);
			LBL_Header.Name = "LBL_Header";
			LBL_Header.Size = new Size(323, 51);
			LBL_Header.TabIndex = 1;
			LBL_Header.Text = "Create Tournament";
			LBL_Header.Click += LBL_Header_Click;
			// 
			// LBL_TournamentName
			// 
			LBL_TournamentName.AutoSize = true;
			LBL_TournamentName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_TournamentName.ForeColor = SystemColors.MenuHighlight;
			LBL_TournamentName.Location = new Point(22, 61);
			LBL_TournamentName.Name = "LBL_TournamentName";
			LBL_TournamentName.Size = new Size(236, 37);
			LBL_TournamentName.TabIndex = 3;
			LBL_TournamentName.Text = "Tournament Name";
			LBL_TournamentName.Click += LBL_Round_Click;
			// 
			// TXT_TournamentName
			// 
			TXT_TournamentName.Location = new Point(33, 101);
			TXT_TournamentName.Name = "TXT_TournamentName";
			TXT_TournamentName.Size = new Size(279, 23);
			TXT_TournamentName.TabIndex = 4;
			TXT_TournamentName.TextChanged += textBox1_TextChanged;
			// 
			// TXT_EntryFee
			// 
			TXT_EntryFee.Location = new Point(33, 177);
			TXT_EntryFee.Name = "TXT_EntryFee";
			TXT_EntryFee.Size = new Size(279, 23);
			TXT_EntryFee.TabIndex = 6;
			// 
			// LBL_EntryFee
			// 
			LBL_EntryFee.AutoSize = true;
			LBL_EntryFee.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_EntryFee.ForeColor = SystemColors.MenuHighlight;
			LBL_EntryFee.Location = new Point(22, 137);
			LBL_EntryFee.Name = "LBL_EntryFee";
			LBL_EntryFee.Size = new Size(125, 37);
			LBL_EntryFee.TabIndex = 5;
			LBL_EntryFee.Text = "Entry Fee";
			// 
			// CMB_SelectTeam
			// 
			CMB_SelectTeam.FormattingEnabled = true;
			CMB_SelectTeam.Location = new Point(33, 257);
			CMB_SelectTeam.Name = "CMB_SelectTeam";
			CMB_SelectTeam.Size = new Size(279, 23);
			CMB_SelectTeam.TabIndex = 8;
			CMB_SelectTeam.SelectedIndexChanged += CMB_Round_SelectedIndexChanged;
			// 
			// LBL_SelectTeam
			// 
			LBL_SelectTeam.AutoSize = true;
			LBL_SelectTeam.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_SelectTeam.ForeColor = SystemColors.MenuHighlight;
			LBL_SelectTeam.Location = new Point(22, 217);
			LBL_SelectTeam.Name = "LBL_SelectTeam";
			LBL_SelectTeam.Size = new Size(156, 37);
			LBL_SelectTeam.TabIndex = 7;
			LBL_SelectTeam.Text = "Select Team";
			LBL_SelectTeam.Click += LBL_Round_Click_1;
			// 
			// LNK_AddNewTeam
			// 
			LNK_AddNewTeam.AutoSize = true;
			LNK_AddNewTeam.Location = new Point(252, 235);
			LNK_AddNewTeam.Name = "LNK_AddNewTeam";
			LNK_AddNewTeam.Size = new Size(40, 15);
			LNK_AddNewTeam.TabIndex = 9;
			LNK_AddNewTeam.TabStop = true;
			LNK_AddNewTeam.Text = "Add +";
			// 
			// BTN_AddTeam
			// 
			BTN_AddTeam.FlatAppearance.BorderColor = Color.Silver;
			BTN_AddTeam.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			BTN_AddTeam.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			BTN_AddTeam.FlatStyle = FlatStyle.Flat;
			BTN_AddTeam.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
			BTN_AddTeam.ForeColor = SystemColors.MenuHighlight;
			BTN_AddTeam.Location = new Point(39, 298);
			BTN_AddTeam.Name = "BTN_AddTeam";
			BTN_AddTeam.Size = new Size(167, 41);
			BTN_AddTeam.TabIndex = 15;
			BTN_AddTeam.Text = "Add Team";
			BTN_AddTeam.UseVisualStyleBackColor = true;
			// 
			// BTN_CreatePrize
			// 
			BTN_CreatePrize.FlatAppearance.BorderColor = Color.Silver;
			BTN_CreatePrize.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			BTN_CreatePrize.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			BTN_CreatePrize.FlatStyle = FlatStyle.Flat;
			BTN_CreatePrize.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
			BTN_CreatePrize.ForeColor = SystemColors.MenuHighlight;
			BTN_CreatePrize.Location = new Point(39, 356);
			BTN_CreatePrize.Name = "BTN_CreatePrize";
			BTN_CreatePrize.Size = new Size(167, 41);
			BTN_CreatePrize.TabIndex = 16;
			BTN_CreatePrize.Text = "Create Prize";
			BTN_CreatePrize.UseVisualStyleBackColor = true;
			// 
			// LSB_TournamentPlayers
			// 
			LSB_TournamentPlayers.BorderStyle = BorderStyle.FixedSingle;
			LSB_TournamentPlayers.FormattingEnabled = true;
			LSB_TournamentPlayers.ItemHeight = 15;
			LSB_TournamentPlayers.Location = new Point(375, 101);
			LSB_TournamentPlayers.Name = "LSB_TournamentPlayers";
			LSB_TournamentPlayers.Size = new Size(260, 122);
			LSB_TournamentPlayers.TabIndex = 17;
			// 
			// LBL_TeamsPlayers
			// 
			LBL_TeamsPlayers.AutoSize = true;
			LBL_TeamsPlayers.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_TeamsPlayers.ForeColor = SystemColors.MenuHighlight;
			LBL_TeamsPlayers.Location = new Point(375, 61);
			LBL_TeamsPlayers.Name = "LBL_TeamsPlayers";
			LBL_TeamsPlayers.Size = new Size(198, 37);
			LBL_TeamsPlayers.TabIndex = 18;
			LBL_TeamsPlayers.Text = "Teams / Players";
			// 
			// BTN_DeletePlayer
			// 
			BTN_DeletePlayer.FlatAppearance.BorderColor = Color.Silver;
			BTN_DeletePlayer.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			BTN_DeletePlayer.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			BTN_DeletePlayer.FlatStyle = FlatStyle.Flat;
			BTN_DeletePlayer.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
			BTN_DeletePlayer.ForeColor = SystemColors.MenuHighlight;
			BTN_DeletePlayer.Location = new Point(656, 122);
			BTN_DeletePlayer.Name = "BTN_DeletePlayer";
			BTN_DeletePlayer.Size = new Size(139, 78);
			BTN_DeletePlayer.TabIndex = 19;
			BTN_DeletePlayer.Text = "Delete Player";
			BTN_DeletePlayer.UseVisualStyleBackColor = true;
			// 
			// BTN_DeleteSelectedPrize
			// 
			BTN_DeleteSelectedPrize.FlatAppearance.BorderColor = Color.Silver;
			BTN_DeleteSelectedPrize.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			BTN_DeleteSelectedPrize.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			BTN_DeleteSelectedPrize.FlatStyle = FlatStyle.Flat;
			BTN_DeleteSelectedPrize.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
			BTN_DeleteSelectedPrize.ForeColor = SystemColors.MenuHighlight;
			BTN_DeleteSelectedPrize.Location = new Point(656, 298);
			BTN_DeleteSelectedPrize.Name = "BTN_DeleteSelectedPrize";
			BTN_DeleteSelectedPrize.Size = new Size(139, 86);
			BTN_DeleteSelectedPrize.TabIndex = 22;
			BTN_DeleteSelectedPrize.Text = "Delete Selected";
			BTN_DeleteSelectedPrize.UseVisualStyleBackColor = true;
			// 
			// LBL_Prizes
			// 
			LBL_Prizes.AutoSize = true;
			LBL_Prizes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_Prizes.ForeColor = SystemColors.MenuHighlight;
			LBL_Prizes.Location = new Point(375, 235);
			LBL_Prizes.Name = "LBL_Prizes";
			LBL_Prizes.Size = new Size(85, 37);
			LBL_Prizes.TabIndex = 21;
			LBL_Prizes.Text = "Prizes";
			LBL_Prizes.Click += LBL_Prizes_Click;
			// 
			// LSB_Prizes
			// 
			LSB_Prizes.BorderStyle = BorderStyle.FixedSingle;
			LSB_Prizes.FormattingEnabled = true;
			LSB_Prizes.ItemHeight = 15;
			LSB_Prizes.Location = new Point(375, 275);
			LSB_Prizes.Name = "LSB_Prizes";
			LSB_Prizes.Size = new Size(260, 122);
			LSB_Prizes.TabIndex = 20;
			// 
			// BTN_CreateTournament
			// 
			BTN_CreateTournament.FlatAppearance.BorderColor = Color.Silver;
			BTN_CreateTournament.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			BTN_CreateTournament.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			BTN_CreateTournament.FlatStyle = FlatStyle.Flat;
			BTN_CreateTournament.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
			BTN_CreateTournament.ForeColor = SystemColors.MenuHighlight;
			BTN_CreateTournament.Location = new Point(293, 421);
			BTN_CreateTournament.Name = "BTN_CreateTournament";
			BTN_CreateTournament.Size = new Size(225, 41);
			BTN_CreateTournament.TabIndex = 23;
			BTN_CreateTournament.Text = "Create Tournament";
			BTN_CreateTournament.UseVisualStyleBackColor = true;
			// 
			// CreateTournamentForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(890, 492);
			Controls.Add(BTN_CreateTournament);
			Controls.Add(BTN_DeleteSelectedPrize);
			Controls.Add(LBL_Prizes);
			Controls.Add(LSB_Prizes);
			Controls.Add(BTN_DeletePlayer);
			Controls.Add(LBL_TeamsPlayers);
			Controls.Add(LSB_TournamentPlayers);
			Controls.Add(BTN_CreatePrize);
			Controls.Add(BTN_AddTeam);
			Controls.Add(LNK_AddNewTeam);
			Controls.Add(CMB_SelectTeam);
			Controls.Add(LBL_SelectTeam);
			Controls.Add(TXT_EntryFee);
			Controls.Add(LBL_EntryFee);
			Controls.Add(TXT_TournamentName);
			Controls.Add(LBL_TournamentName);
			Controls.Add(LBL_Header);
			Margin = new Padding(1);
			Name = "CreateTournamentForm";
			Text = "Create Tournament";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label LBL_Header;
		private Label LBL_TournamentName;
		private TextBox TXT_TournamentName;
		private TextBox TXT_EntryFee;
		private Label LBL_EntryFee;
		private ComboBox CMB_SelectTeam;
		private Label LBL_SelectTeam;
		private LinkLabel LNK_AddNewTeam;
		private Button BTN_AddTeam;
		private Button BTN_CreatePrize;
		private ListBox LSB_TournamentPlayers;
		private Label LBL_TeamsPlayers;
		private Button BTN_DeletePlayer;
		private Button BTN_DeleteSelectedPrize;
		private Label LBL_Prizes;
		private ListBox LSB_Prizes;
		private Button BTN_CreateTournament;
	}
}