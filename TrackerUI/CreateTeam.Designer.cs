namespace TrackerUI
{
	partial class CreateTeam
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
			TXT_TeamName = new TextBox();
			LBL_TeamName = new Label();
			LBL_CreateTeam = new Label();
			CMB_SelectTeamMember = new ComboBox();
			LBL_SelectTeamMember = new Label();
			BTN_AddTeamMember = new Button();
			GRP_AddNewMember = new GroupBox();
			BTN_CreateMember = new Button();
			TXT_Cell = new TextBox();
			LBL_Cell = new Label();
			TXT_Email = new TextBox();
			LBL_Email = new Label();
			TXT_LastName = new TextBox();
			LBL_LastName = new Label();
			TXT_FirstName = new TextBox();
			LBL_FirstName = new Label();
			LSB_TeamMembers = new ListBox();
			BTN_DeleteSelectedMember = new Button();
			BTN_CreateTeam = new Button();
			GRP_AddNewMember.SuspendLayout();
			SuspendLayout();
			// 
			// TXT_TeamName
			// 
			TXT_TeamName.Location = new Point(33, 101);
			TXT_TeamName.Name = "TXT_TeamName";
			TXT_TeamName.Size = new Size(348, 43);
			TXT_TeamName.TabIndex = 7;
			// 
			// LBL_TeamName
			// 
			LBL_TeamName.AutoSize = true;
			LBL_TeamName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_TeamName.ForeColor = SystemColors.MenuHighlight;
			LBL_TeamName.Location = new Point(22, 61);
			LBL_TeamName.Name = "LBL_TeamName";
			LBL_TeamName.Size = new Size(157, 37);
			LBL_TeamName.TabIndex = 6;
			LBL_TeamName.Text = "Team Name";
			// 
			// LBL_CreateTeam
			// 
			LBL_CreateTeam.AutoSize = true;
			LBL_CreateTeam.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_CreateTeam.ForeColor = SystemColors.MenuHighlight;
			LBL_CreateTeam.Location = new Point(12, 9);
			LBL_CreateTeam.Name = "LBL_CreateTeam";
			LBL_CreateTeam.Size = new Size(218, 51);
			LBL_CreateTeam.TabIndex = 5;
			LBL_CreateTeam.Text = "Create Team";
			// 
			// CMB_SelectTeamMember
			// 
			CMB_SelectTeamMember.FormattingEnabled = true;
			CMB_SelectTeamMember.Location = new Point(33, 197);
			CMB_SelectTeamMember.Name = "CMB_SelectTeamMember";
			CMB_SelectTeamMember.Size = new Size(348, 45);
			CMB_SelectTeamMember.TabIndex = 10;
			// 
			// LBL_SelectTeamMember
			// 
			LBL_SelectTeamMember.AutoSize = true;
			LBL_SelectTeamMember.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_SelectTeamMember.ForeColor = SystemColors.MenuHighlight;
			LBL_SelectTeamMember.Location = new Point(22, 157);
			LBL_SelectTeamMember.Name = "LBL_SelectTeamMember";
			LBL_SelectTeamMember.Size = new Size(263, 37);
			LBL_SelectTeamMember.TabIndex = 9;
			LBL_SelectTeamMember.Text = "Select Team Member";
			// 
			// BTN_AddTeamMember
			// 
			BTN_AddTeamMember.FlatAppearance.BorderColor = Color.Silver;
			BTN_AddTeamMember.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			BTN_AddTeamMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			BTN_AddTeamMember.FlatStyle = FlatStyle.Flat;
			BTN_AddTeamMember.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
			BTN_AddTeamMember.ForeColor = SystemColors.MenuHighlight;
			BTN_AddTeamMember.Location = new Point(100, 268);
			BTN_AddTeamMember.Name = "BTN_AddTeamMember";
			BTN_AddTeamMember.Size = new Size(167, 41);
			BTN_AddTeamMember.TabIndex = 16;
			BTN_AddTeamMember.Text = "Add Member";
			BTN_AddTeamMember.UseVisualStyleBackColor = true;
			BTN_AddTeamMember.Click += BTN_AddTeamMember_Click;
			// 
			// GRP_AddNewMember
			// 
			GRP_AddNewMember.Controls.Add(BTN_CreateMember);
			GRP_AddNewMember.Controls.Add(TXT_Cell);
			GRP_AddNewMember.Controls.Add(LBL_Cell);
			GRP_AddNewMember.Controls.Add(TXT_Email);
			GRP_AddNewMember.Controls.Add(LBL_Email);
			GRP_AddNewMember.Controls.Add(TXT_LastName);
			GRP_AddNewMember.Controls.Add(LBL_LastName);
			GRP_AddNewMember.Controls.Add(TXT_FirstName);
			GRP_AddNewMember.Controls.Add(LBL_FirstName);
			GRP_AddNewMember.Location = new Point(33, 340);
			GRP_AddNewMember.Name = "GRP_AddNewMember";
			GRP_AddNewMember.Size = new Size(348, 355);
			GRP_AddNewMember.TabIndex = 17;
			GRP_AddNewMember.TabStop = false;
			GRP_AddNewMember.Text = "Add New Member";
			// 
			// BTN_CreateMember
			// 
			BTN_CreateMember.FlatAppearance.BorderColor = Color.Silver;
			BTN_CreateMember.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			BTN_CreateMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			BTN_CreateMember.FlatStyle = FlatStyle.Flat;
			BTN_CreateMember.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
			BTN_CreateMember.ForeColor = SystemColors.MenuHighlight;
			BTN_CreateMember.Location = new Point(67, 278);
			BTN_CreateMember.Name = "BTN_CreateMember";
			BTN_CreateMember.Size = new Size(185, 41);
			BTN_CreateMember.TabIndex = 19;
			BTN_CreateMember.Text = "Create Member";
			BTN_CreateMember.UseVisualStyleBackColor = true;
			BTN_CreateMember.Click += BTN_CreateMember_Click;
			// 
			// TXT_Cell
			// 
			TXT_Cell.Location = new Point(156, 193);
			TXT_Cell.Name = "TXT_Cell";
			TXT_Cell.Size = new Size(159, 43);
			TXT_Cell.TabIndex = 17;
			// 
			// LBL_Cell
			// 
			LBL_Cell.AutoSize = true;
			LBL_Cell.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_Cell.ForeColor = SystemColors.MenuHighlight;
			LBL_Cell.Location = new Point(6, 199);
			LBL_Cell.Name = "LBL_Cell";
			LBL_Cell.Size = new Size(62, 37);
			LBL_Cell.TabIndex = 16;
			LBL_Cell.Text = "Cell";
			// 
			// TXT_Email
			// 
			TXT_Email.Location = new Point(156, 144);
			TXT_Email.Name = "TXT_Email";
			TXT_Email.Size = new Size(159, 43);
			TXT_Email.TabIndex = 15;
			// 
			// LBL_Email
			// 
			LBL_Email.AutoSize = true;
			LBL_Email.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_Email.ForeColor = SystemColors.MenuHighlight;
			LBL_Email.Location = new Point(6, 150);
			LBL_Email.Name = "LBL_Email";
			LBL_Email.Size = new Size(82, 37);
			LBL_Email.TabIndex = 14;
			LBL_Email.Text = "Email";
			// 
			// TXT_LastName
			// 
			TXT_LastName.Location = new Point(156, 95);
			TXT_LastName.Name = "TXT_LastName";
			TXT_LastName.Size = new Size(159, 43);
			TXT_LastName.TabIndex = 13;
			// 
			// LBL_LastName
			// 
			LBL_LastName.AutoSize = true;
			LBL_LastName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_LastName.ForeColor = SystemColors.MenuHighlight;
			LBL_LastName.Location = new Point(6, 101);
			LBL_LastName.Name = "LBL_LastName";
			LBL_LastName.Size = new Size(142, 37);
			LBL_LastName.TabIndex = 12;
			LBL_LastName.Text = "Last Name";
			// 
			// TXT_FirstName
			// 
			TXT_FirstName.Location = new Point(156, 46);
			TXT_FirstName.Name = "TXT_FirstName";
			TXT_FirstName.Size = new Size(159, 43);
			TXT_FirstName.TabIndex = 11;
			TXT_FirstName.TextChanged += TXT_Team1Score_TextChanged;
			// 
			// LBL_FirstName
			// 
			LBL_FirstName.AutoSize = true;
			LBL_FirstName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			LBL_FirstName.ForeColor = SystemColors.MenuHighlight;
			LBL_FirstName.Location = new Point(6, 52);
			LBL_FirstName.Name = "LBL_FirstName";
			LBL_FirstName.Size = new Size(144, 37);
			LBL_FirstName.TabIndex = 10;
			LBL_FirstName.Text = "First Name";
			LBL_FirstName.Click += LBL_Team1Score_Click;
			// 
			// LSB_TeamMembers
			// 
			LSB_TeamMembers.BorderStyle = BorderStyle.FixedSingle;
			LSB_TeamMembers.FormattingEnabled = true;
			LSB_TeamMembers.ItemHeight = 37;
			LSB_TeamMembers.Location = new Point(435, 101);
			LSB_TeamMembers.Name = "LSB_TeamMembers";
			LSB_TeamMembers.Size = new Size(302, 594);
			LSB_TeamMembers.TabIndex = 18;
			// 
			// BTN_DeleteSelectedMember
			// 
			BTN_DeleteSelectedMember.FlatAppearance.BorderColor = Color.Silver;
			BTN_DeleteSelectedMember.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			BTN_DeleteSelectedMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			BTN_DeleteSelectedMember.FlatStyle = FlatStyle.Flat;
			BTN_DeleteSelectedMember.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
			BTN_DeleteSelectedMember.ForeColor = SystemColors.MenuHighlight;
			BTN_DeleteSelectedMember.Location = new Point(772, 324);
			BTN_DeleteSelectedMember.Name = "BTN_DeleteSelectedMember";
			BTN_DeleteSelectedMember.Size = new Size(139, 86);
			BTN_DeleteSelectedMember.TabIndex = 23;
			BTN_DeleteSelectedMember.Text = "Delete Selected";
			BTN_DeleteSelectedMember.UseVisualStyleBackColor = true;
			BTN_DeleteSelectedMember.Click += BTN_DeleteSelectedMember_Click;
			// 
			// BTN_CreateTeam
			// 
			BTN_CreateTeam.FlatAppearance.BorderColor = Color.Silver;
			BTN_CreateTeam.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
			BTN_CreateTeam.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
			BTN_CreateTeam.FlatStyle = FlatStyle.Flat;
			BTN_CreateTeam.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
			BTN_CreateTeam.ForeColor = SystemColors.MenuHighlight;
			BTN_CreateTeam.Location = new Point(313, 743);
			BTN_CreateTeam.Name = "BTN_CreateTeam";
			BTN_CreateTeam.Size = new Size(206, 65);
			BTN_CreateTeam.TabIndex = 20;
			BTN_CreateTeam.Text = "Create Team";
			BTN_CreateTeam.UseVisualStyleBackColor = true;
			// 
			// CreateTeam
			// 
			AutoScaleDimensions = new SizeF(15F, 37F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1025, 831);
			Controls.Add(BTN_CreateTeam);
			Controls.Add(BTN_DeleteSelectedMember);
			Controls.Add(LSB_TeamMembers);
			Controls.Add(GRP_AddNewMember);
			Controls.Add(BTN_AddTeamMember);
			Controls.Add(CMB_SelectTeamMember);
			Controls.Add(LBL_SelectTeamMember);
			Controls.Add(TXT_TeamName);
			Controls.Add(LBL_TeamName);
			Controls.Add(LBL_CreateTeam);
			Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
			Margin = new Padding(6, 7, 6, 7);
			Name = "CreateTeam";
			Text = "Create Team";
			GRP_AddNewMember.ResumeLayout(false);
			GRP_AddNewMember.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox TXT_TeamName;
		private Label LBL_TeamName;
		private Label LBL_CreateTeam;
		private ComboBox CMB_SelectTeamMember;
		private Label LBL_SelectTeamMember;
		private Button BTN_AddTeamMember;
		private GroupBox GRP_AddNewMember;
		private TextBox TXT_FirstName;
		private Label LBL_FirstName;
		private TextBox TXT_LastName;
		private Label LBL_LastName;
		private Button BTN_CreateMember;
		private TextBox TXT_Cell;
		private Label LBL_Cell;
		private TextBox TXT_Email;
		private Label LBL_Email;
		private ListBox LSB_TeamMembers;
		private Button BTN_DeleteSelectedMember;
		private Button BTN_CreateTeam;
	}
}