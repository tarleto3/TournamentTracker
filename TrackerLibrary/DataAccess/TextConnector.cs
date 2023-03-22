﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
using System.ComponentModel;

namespace TrackerLibrary.DataAccess
{
	public class TextConnector : IDataConnection
	{
		private const string PrizesFile = "PrizeModels.csv";
		private const string PeopleFile = "PersonModels.csv";
		private const string TeamsFile = "TeamModels.csv";

		public PersonModel CreatePerson(PersonModel model)
		{
			BindingList<PersonModel> persons = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

			int currentId = 1;

			if (persons.Count > 0)
			{
				currentId = persons.OrderByDescending(p => p.Id).First().Id + 1;
			}

			model.Id = currentId;

			persons.Add(model);
			persons.SaveToPeopleFile(PeopleFile);

			return model;
		}

		public PrizeModel CreatePrize(PrizeModel model)
		{
			List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();


			int currentId = 1;

			if (prizes.Count > 0)
			{
				currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
			}

			model.Id = currentId;

			prizes.Add(model);

			prizes.SaveToPrizeFile(PrizesFile);

			return model;
		}

		public TeamModel CreateTeam(TeamModel model)
		{
			BindingList<TeamModel> teams = TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
			int currentId = 1;

			if (teams.Count > 0)
			{
				currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
			}
			model.Id = currentId;
			teams.Add(model);

			teams.SaveToTeamsFile(TeamsFile);
			return model;
		}

		public BindingList<PersonModel> GetPerson_All()
		{
			return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
		}
	}
}
