namespace TrackerUI
{
	partial class TournamentDashboard
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			LBL_CreatePrize = new Label();
			CMB_LoadTeam = new ComboBox();
			LBL_LoadTeam = new Label();
			BTN_LoadTournament = new Button();
			BTN_CreateTournament = new Button();
			SuspendLayout();
			// 
			// LBL_CreatePrize
			// 
			LBL_CreatePrize.AutoSize = true;
			LBL_CreatePrize.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_CreatePrize.ForeColor = SystemColors.MenuHighlight;
			LBL_CreatePrize.Location = new Point(196, 39);
			LBL_CreatePrize.Name = "LBL_CreatePrize";
			LBL_CreatePrize.Size = new Size(393, 51);
			LBL_CreatePrize.TabIndex = 7;
			LBL_CreatePrize.Text = "Tournament Dashboard";
			// 
			// CMB_LoadTeam
			// 
			CMB_LoadTeam.FormattingEnabled = true;
			CMB_LoadTeam.Location = new Point(196, 165);
			CMB_LoadTeam.Name = "CMB_LoadTeam";
			CMB_LoadTeam.Size = new Size(393, 45);
			CMB_LoadTeam.TabIndex = 10;
			// 
			// LBL_LoadTeam
			// 
			LBL_LoadTeam.AutoSize = true;
			LBL_LoadTeam.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_LoadTeam.ForeColor = SystemColors.MenuHighlight;
			LBL_LoadTeam.Location = new Point(280, 125);
			LBL_LoadTeam.Name = "LBL_LoadTeam";
			LBL_LoadTeam.Size = new Size(243, 37);
			LBL_LoadTeam.TabIndex = 9;
			LBL_LoadTeam.Text = "Load Existing Team";
			// 
			// BTN_LoadTournament
			// 
			BTN_LoadTournament.FlatAppearance.BorderColor = Color.Silver;
			BTN_LoadTournament.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			BTN_LoadTournament.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			BTN_LoadTournament.FlatStyle = FlatStyle.Flat;
			BTN_LoadTournament.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
			BTN_LoadTournament.ForeColor = SystemColors.MenuHighlight;
			BTN_LoadTournament.Location = new Point(280, 244);
			BTN_LoadTournament.Name = "BTN_LoadTournament";
			BTN_LoadTournament.Size = new Size(225, 41);
			BTN_LoadTournament.TabIndex = 24;
			BTN_LoadTournament.Text = "Load Tournament";
			BTN_LoadTournament.UseVisualStyleBackColor = true;
			// 
			// BTN_CreateTournament
			// 
			BTN_CreateTournament.FlatAppearance.BorderColor = Color.Silver;
			BTN_CreateTournament.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			BTN_CreateTournament.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			BTN_CreateTournament.FlatStyle = FlatStyle.Flat;
			BTN_CreateTournament.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
			BTN_CreateTournament.ForeColor = SystemColors.MenuHighlight;
			BTN_CreateTournament.Location = new Point(249, 319);
			BTN_CreateTournament.Name = "BTN_CreateTournament";
			BTN_CreateTournament.Size = new Size(274, 75);
			BTN_CreateTournament.TabIndex = 26;
			BTN_CreateTournament.Text = "Create Tournament";
			BTN_CreateTournament.UseVisualStyleBackColor = true;
			// 
			// TournamentDashboard
			// 
			AutoScaleDimensions = new SizeF(15F, 37F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(760, 466);
			Controls.Add(BTN_CreateTournament);
			Controls.Add(BTN_LoadTournament);
			Controls.Add(CMB_LoadTeam);
			Controls.Add(LBL_LoadTeam);
			Controls.Add(LBL_CreatePrize);
			Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(6, 7, 6, 7);
			Name = "TournamentDashboard";
			Text = "TournamentDashboard";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label LBL_CreatePrize;
		private ComboBox CMB_LoadTeam;
		private Label LBL_LoadTeam;
		private Button BTN_LoadTournament;
		private Button BTN_CreateTournament;
	}
}