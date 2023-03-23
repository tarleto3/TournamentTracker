using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
	public partial class CreateTournamentForm : Form, IPrizeRequestor, ITeamRequestor
	{
		BindingList<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
		BindingList<TeamModel> selectedTeams = new BindingList<TeamModel>();
		BindingList<PrizeModel> prizes = new BindingList<PrizeModel>();
		public CreateTournamentForm()
		{
			InitializeComponent();
			WireUpLists();
		}

		private void LBL_Header_Click(object sender, EventArgs e)
		{

		}

		private void LBL_Round_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void LBL_Round_Click_1(object sender, EventArgs e)
		{

		}

		private void CMB_Round_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void LBL_Prizes_Click(object sender, EventArgs e)
		{

		}

		private void WireUpLists()
		{
			CMB_SelectTeam.DataSource = availableTeams;
			CMB_SelectTeam.DisplayMember = "TeamName";

			LSB_TournamentTeams.DataSource = selectedTeams;
			LSB_TournamentTeams.DisplayMember = "TeamName";

			LSB_Prizes.DataSource = prizes;
			LSB_Prizes.DisplayMember = "PlaceName";

		}

		private void LSB_TournamentPlayers_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void BTN_AddTeam_Click(object sender, EventArgs e)
		{

			TeamModel t = (TeamModel)CMB_SelectTeam.SelectedItem;

			if (t != null)
			{
				availableTeams.Remove(t);
				selectedTeams.Add(t);
			}
		}

		private void BTN_CreatePrize_Click(object sender, EventArgs e)
		{
			// TODO - Call Create Prize Form, Get a PrizeModel back, put into list of selected prizes. 

			Create_Prize_Form frm = new Create_Prize_Form(this);
			frm.Show();
		}

		public void PrizeComplete(PrizeModel model)
		{
			prizes.Add(model);
		}

		private void LNK_AddNewTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			CreateTeam frm = new CreateTeam(this);
			frm.Show();
		}

		public void TeamComplete(TeamModel model)
		{
			selectedTeams.Add(model);
		}

		private void BTN_DeletePlayer_Click(object sender, EventArgs e)
		{
			TeamModel t = (TeamModel)LSB_TournamentTeams.SelectedItem;

			if (t != null)
			{
				selectedTeams.Remove(t);
				availableTeams.Add(t);
			}
		}

		private void BTN_DeleteSelectedPrize_Click(object sender, EventArgs e)
		{
			PrizeModel p = (PrizeModel)LSB_Prizes.SelectedItem;

			if (p != null)
			{
				prizes.Remove(p);
			}
		}

		private void BTN_CreateTournament_Click(object sender, EventArgs e)
		{
			decimal fee;

			bool feeIsDecimal = decimal.TryParse(TXT_EntryFee.Text, out fee);

			if (!feeIsDecimal)
			{
				MessageBox.Show("Please enter a valid entry fee as a decimal number.", "Invalid Fee",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			TournamentModel tm = new TournamentModel();

			tm.TournamentName = TXT_TournamentName.Text;
			tm.EntryFee = fee;

			tm.Prizes = prizes;
			tm.EnteredTeams = selectedTeams;

			GlobalConfig.Connection.CreateTournament(tm);
			// TODO - Create Matchups
		}
	}
}