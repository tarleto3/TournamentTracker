﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";

		public PersonModel CreatePerson(PersonModel model)
		{
            List<PersonModel> persons = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;

            if(persons.Count > 0)
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
            List<PrizeModel> prizes =  PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();


            int currentId = 1;

            if(prizes.Count > 0)
            {
				currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
			}

            model.Id = currentId;

            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

		public List<PersonModel> GetPerson_All()
		{
			throw new NotImplementedException();
		}
	}
}
