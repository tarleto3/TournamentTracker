﻿namespace TrackerUI
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
			SuspendLayout();
			// 
			// TournamentViewer
			// 
			AutoScaleDimensions = new SizeF(12F, 30F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1129, 744);
			Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(5, 6, 5, 6);
			Name = "TournamentViewer";
			Text = "Tournament Viewer";
			Load += TournamentViewer_Load;
			ResumeLayout(false);
		}

		#endregion
	}
}