namespace TrackerUI
{
    partial class Create_Prize_Form
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
            TXT_PlaceNumber = new TextBox();
            LBL_PlaceNumber = new Label();
            TXT_PlaceName = new TextBox();
            LBL_PlaceName = new Label();
            TXT_PrizeAmount = new TextBox();
            LBL_PrizeAmount = new Label();
            TXT_PrizePercent = new TextBox();
            LBL_PrizePercentage = new Label();
            LBL_Or = new Label();
            BTN_CreatePrize = new Button();
            SuspendLayout();
            // 
            // LBL_CreatePrize
            // 
            LBL_CreatePrize.AutoSize = true;
            LBL_CreatePrize.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_CreatePrize.ForeColor = SystemColors.MenuHighlight;
            LBL_CreatePrize.Location = new Point(12, 9);
            LBL_CreatePrize.Name = "LBL_CreatePrize";
            LBL_CreatePrize.Size = new Size(471, 112);
            LBL_CreatePrize.TabIndex = 6;
            LBL_CreatePrize.Text = "Create Prize";
            // 
            // TXT_PlaceNumber
            // 
            TXT_PlaceNumber.Location = new Point(512, 114);
            TXT_PlaceNumber.Name = "TXT_PlaceNumber";
            TXT_PlaceNumber.Size = new Size(208, 88);
            TXT_PlaceNumber.TabIndex = 13;
            TXT_PlaceNumber.TextChanged += TXT_FirstName_TextChanged;
            // 
            // LBL_PlaceNumber
            // 
            LBL_PlaceNumber.AutoSize = true;
            LBL_PlaceNumber.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_PlaceNumber.ForeColor = SystemColors.MenuHighlight;
            LBL_PlaceNumber.Location = new Point(33, 121);
            LBL_PlaceNumber.Name = "LBL_PlaceNumber";
            LBL_PlaceNumber.Size = new Size(408, 81);
            LBL_PlaceNumber.TabIndex = 12;
            LBL_PlaceNumber.Text = "Place Number";
            // 
            // TXT_PlaceName
            // 
            TXT_PlaceName.Location = new Point(512, 197);
            TXT_PlaceName.Name = "TXT_PlaceName";
            TXT_PlaceName.Size = new Size(208, 88);
            TXT_PlaceName.TabIndex = 15;
            // 
            // LBL_PlaceName
            // 
            LBL_PlaceName.AutoSize = true;
            LBL_PlaceName.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_PlaceName.ForeColor = SystemColors.MenuHighlight;
            LBL_PlaceName.Location = new Point(33, 204);
            LBL_PlaceName.Name = "LBL_PlaceName";
            LBL_PlaceName.Size = new Size(349, 81);
            LBL_PlaceName.TabIndex = 14;
            LBL_PlaceName.Text = "Place Name";
            // 
            // TXT_PrizeAmount
            // 
            TXT_PrizeAmount.Location = new Point(512, 277);
            TXT_PrizeAmount.Name = "TXT_PrizeAmount";
            TXT_PrizeAmount.Size = new Size(208, 88);
            TXT_PrizeAmount.TabIndex = 17;
            TXT_PrizeAmount.Text = "0";
            TXT_PrizeAmount.TextChanged += textBox2_TextChanged;
            // 
            // LBL_PrizeAmount
            // 
            LBL_PrizeAmount.AutoSize = true;
            LBL_PrizeAmount.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_PrizeAmount.ForeColor = SystemColors.MenuHighlight;
            LBL_PrizeAmount.Location = new Point(33, 284);
            LBL_PrizeAmount.Name = "LBL_PrizeAmount";
            LBL_PrizeAmount.Size = new Size(393, 81);
            LBL_PrizeAmount.TabIndex = 16;
            LBL_PrizeAmount.Text = "Prize Amount";
            // 
            // TXT_PrizePercent
            // 
            TXT_PrizePercent.Location = new Point(512, 432);
            TXT_PrizePercent.Name = "TXT_PrizePercent";
            TXT_PrizePercent.Size = new Size(208, 88);
            TXT_PrizePercent.TabIndex = 19;
            TXT_PrizePercent.Text = "0";
            // 
            // LBL_PrizePercentage
            // 
            LBL_PrizePercentage.AutoSize = true;
            LBL_PrizePercentage.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_PrizePercentage.ForeColor = SystemColors.MenuHighlight;
            LBL_PrizePercentage.Location = new Point(33, 439);
            LBL_PrizePercentage.Name = "LBL_PrizePercentage";
            LBL_PrizePercentage.Size = new Size(473, 81);
            LBL_PrizePercentage.TabIndex = 18;
            LBL_PrizePercentage.Text = "Prize Percentage";
            // 
            // LBL_Or
            // 
            LBL_Or.AutoSize = true;
            LBL_Or.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LBL_Or.ForeColor = SystemColors.MenuHighlight;
            LBL_Or.Location = new Point(191, 365);
            LBL_Or.Name = "LBL_Or";
            LBL_Or.Size = new Size(164, 81);
            LBL_Or.TabIndex = 20;
            LBL_Or.Text = "-OR-";
            // 
            // BTN_CreatePrize
            // 
            BTN_CreatePrize.FlatAppearance.BorderColor = Color.Silver;
            BTN_CreatePrize.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            BTN_CreatePrize.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            BTN_CreatePrize.FlatStyle = FlatStyle.Flat;
            BTN_CreatePrize.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_CreatePrize.ForeColor = SystemColors.MenuHighlight;
            BTN_CreatePrize.Location = new Point(117, 551);
            BTN_CreatePrize.Name = "BTN_CreatePrize";
            BTN_CreatePrize.Size = new Size(274, 75);
            BTN_CreatePrize.TabIndex = 25;
            BTN_CreatePrize.Text = "Create Prize";
            BTN_CreatePrize.UseVisualStyleBackColor = true;
            BTN_CreatePrize.Click += BTN_CreatePrize_Click;
            // 
            // Create_Prize_Form
            // 
            AutoScaleDimensions = new SizeF(34F, 82F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 793);
            Controls.Add(BTN_CreatePrize);
            Controls.Add(LBL_Or);
            Controls.Add(TXT_PrizePercent);
            Controls.Add(LBL_PrizePercentage);
            Controls.Add(TXT_PrizeAmount);
            Controls.Add(LBL_PrizeAmount);
            Controls.Add(TXT_PlaceName);
            Controls.Add(LBL_PlaceName);
            Controls.Add(TXT_PlaceNumber);
            Controls.Add(LBL_PlaceNumber);
            Controls.Add(LBL_CreatePrize);
            Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Create_Prize_Form";
            Text = "Create_Prize_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_CreatePrize;
        private TextBox TXT_PlaceNumber;
        private Label LBL_PlaceNumber;
        private TextBox TXT_PlaceName;
        private Label LBL_PlaceName;
        private TextBox TXT_PrizeAmount;
        private Label LBL_PrizeAmount;
        private TextBox TXT_PrizePercent;
        private Label LBL_PrizePercentage;
        private Label LBL_Or;
        private Button BTN_CreatePrize;
    }
}