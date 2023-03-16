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
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(558, 326);
            Controls.Add(LNK_AddNewTeam);
            Controls.Add(CMB_SelectTeam);
            Controls.Add(LBL_SelectTeam);
            Controls.Add(TXT_EntryFee);
            Controls.Add(LBL_EntryFee);
            Controls.Add(TXT_TournamentName);
            Controls.Add(LBL_TournamentName);
            Controls.Add(LBL_Header);
            Margin = new Padding(1, 1, 1, 1);
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
    }
}