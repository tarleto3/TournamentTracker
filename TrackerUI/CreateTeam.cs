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
		private List<PersonModel> availableTeamMembers = = GlobalConfig.Connection.GetPerson_All();
		private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
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

			if(TXT_FirstName.Text.Length == 0)
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
	}
}
