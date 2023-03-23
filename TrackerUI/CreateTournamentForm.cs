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
    public partial class CreateTournamentForm : Form
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

            LSB_TournamentPlayers.DataSource = availableTeams;
            LSB_TournamentPlayers.DisplayMember = "TeamName";

            LSB_Prizes.DataSource = prizes;
            LSB_Prizes.DisplayMember = "PlaceName";

        }

        private void LSB_TournamentPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTN_AddTeam_Click(object sender, EventArgs e)
        {
            //PersonModel p = (PersonModel)CMB_SelectTeamMember.SelectedItem;
            //if (p != null)
            //{
            //    availableTeamMembers.Remove(p);
            //    selectedTeamMembers.Add(p);
            //}

            TeamModel t = (TeamModel)CMB_SelectTeam.SelectedItem;

            if(t == null )
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);
            }WireUpLists();
        }
    }
}