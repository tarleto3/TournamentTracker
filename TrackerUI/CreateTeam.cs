using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
	public partial class CreateTeam : Form
	{
		private BindingList<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
		private BindingList<PersonModel> selectedTeamMembers = new BindingList<PersonModel>();
		private void WireUpLists()
		{
			CMB_SelectTeamMember.DataSource = availableTeamMembers;
			CMB_SelectTeamMember.DisplayMember = "FullName";

			LSB_TeamMembers.DataSource = selectedTeamMembers;
			LSB_TeamMembers.DisplayMember = "FullName";
		}
		public CreateTeam()
		{
			InitializeComponent();
			WireUpLists();
		}

		private void LBL_Team1Score_Click(object sender, EventArgs e)
		{

		}

		private void TXT_Team1Score_TextChanged(object sender, EventArgs e)
		{
		}

		private void BTN_CreateMember_Click(object sender, EventArgs e)
		{
			if (ValidateMemberForm())
			{
				PersonModel p = new PersonModel();

				p.FirstName = TXT_FirstName.Text;
				p.LastName = TXT_LastName.Text;
				p.EmailAddress = TXT_Email.Text;
				p.CellphoneNumber = TXT_Cell.Text;

				GlobalConfig.Connection.CreatePerson(p);

				selectedTeamMembers.Add(p);

				TXT_FirstName.Text = "";
				TXT_LastName.Text = "";
				TXT_Email.Text = "";
				TXT_Cell.Text = "";
			}
			else
			{
				MessageBox.Show("Please fill in all fields");
			}
		}

		private bool ValidateMemberForm()
		{
			bool output = true;

			if (TXT_FirstName.Text.Length == 0)
			{
				output = false;
			}
			if (TXT_LastName.Text.Length == 0)
			{
				output = false;
			}
			if (TXT_Email.Text.Length == 0)
			{
				output = false;
			}
			if (TXT_Cell.Text.Length == 0)
			{
				output = false;
			}
			return output;
		}

		private void BTN_AddTeamMember_Click(object sender, EventArgs e)
		{
			PersonModel p = (PersonModel)CMB_SelectTeamMember.SelectedItem;
			if (p != null)
			{
				availableTeamMembers.Remove(p);
				selectedTeamMembers.Add(p);
			}
		}

		private void BTN_DeleteSelectedMember_Click(object sender, EventArgs e)
		{
			PersonModel p = (PersonModel)LSB_TeamMembers.SelectedItem;
			if (p != null)
			{
				availableTeamMembers.Add(p);
				selectedTeamMembers.Remove(p);
			}
		}

		private void BTN_CreateTeam_Click(object sender, EventArgs e)
		{
			TeamModel t = new TeamModel();

			t.TeamName = TXT_TeamName.Text;
			t.TeamMembers = selectedTeamMembers;

			GlobalConfig.Connection.CreateTeam(t);

			// TODO - Reset Form after Creation of Team.
		}
	}
}
