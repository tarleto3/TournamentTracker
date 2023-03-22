using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
	public static class TextConnectorProcessor
	{
		public static string FullFilePath(this string fileName)
		{
			string test = $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
			return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
		}

		public static List<string> LoadFile(this string file)
		{
			if (!File.Exists(file))
			{
				return new List<string>();
			}

			return File.ReadLines(file).ToList();
		}

		public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
		{
			List<PrizeModel> output = new List<PrizeModel>();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				PrizeModel p = new PrizeModel
				{
					Id = int.Parse(cols[0]),
					PlaceNumber = int.Parse(cols[1]),
					PlaceName = cols[2],
					PrizeAmount = decimal.Parse(cols[3]),
					PrizePercentage = double.Parse(cols[4])
				};
				output.Add(p);
			}
			return output;
		}
		public static BindingList<PersonModel> ConvertToPersonModels(this List<string> lines)
		{
			List<PersonModel> output = new List<PersonModel>();
			BindingList<PersonModel> bind;

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				PersonModel p = new PersonModel
				{
					Id = int.Parse(cols[0]),
					FirstName = cols[1],
					LastName = cols[2],
					EmailAddress = cols[3],
					CellphoneNumber = cols[4]
				};
				output.Add(p);
			}
			bind = new BindingList<PersonModel>(output);
			return bind;
		}
		public static BindingList<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
		{
			List<TeamModel> output = new List<TeamModel>();
			BindingList<TeamModel> bind;
			BindingList<PersonModel> persons = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');
				

				TeamModel t = new TeamModel
				{
					Id = int.Parse(cols[0]),
					TeamName = cols[1],					
				};
				string[] personIds = cols[2].Split("|");
				foreach (string personId in personIds)
				{
					t.TeamMembers.Add(persons.Where(x => x.Id == int.Parse(personId)).First());
				}
				output.Add(t);
			}
			bind = new BindingList<TeamModel>(output);
			return bind;
		}
		public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
		{
			List<string> lines = new List<string>();

			foreach (PrizeModel p in models)
			{
				lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
			}

			File.WriteAllLines(fileName.FullFilePath(), lines);
		}

		public static void SaveToPeopleFile(this BindingList<PersonModel> models, string fileName)
		{
			List<string> lines = new List<string>();

			foreach (PersonModel p in models)
			{
				lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
			}

			File.WriteAllLines(fileName.FullFilePath(), lines);
		}
		public static void SaveToTeamsFile(this BindingList<TeamModel> models, string fileName)
		{
			List<string> lines = new List<string>();

			foreach (TeamModel t in models)
			{
				lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
			}

			File.WriteAllLines(fileName.FullFilePath(), lines);
		}

		private static string ConvertPeopleListToString(BindingList<PersonModel> people)
		{
			string output = "";

			if(people.Count == 0)
			{
				return output;
			}

			foreach (PersonModel p in people)
			{
				output += $"{p.Id}|";
			}

			output = output.Substring(0, output.Length - 1);

			return output;
		}
	}
}
