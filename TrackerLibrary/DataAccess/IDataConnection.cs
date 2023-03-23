using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
	public interface IDataConnection
	{
		PrizeModel CreatePrize(PrizeModel model);
		PersonModel CreatePerson(PersonModel model);
		TeamModel CreateTeam(TeamModel model);
		TournamentModel CreateTournament(TournamentModel model);


		BindingList<PersonModel> GetPerson_All();
		BindingList<TeamModel> GetTeam_All();
	}
}
