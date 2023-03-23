﻿using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
	public class SQLConnector : IDataConnection
	{
		/// <summary>
		/// Creates a person in the database
		/// </summary>
		/// <param name="model">The Person model to be saved into the database.</param>
		/// <returns></returns>

		private string db = "Tournaments";
		public PersonModel CreatePerson(PersonModel model)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				var p = new DynamicParameters();
				p.Add("@FirstName", model.FirstName);
				p.Add("@LastName", model.LastName);
				p.Add("@EmailAddress", model.EmailAddress);
				p.Add("@CellPhoneNumber", model.CellphoneNumber);
				p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				connection.Execute("[dbo].[spPeople_Insert]", p, commandType: CommandType.StoredProcedure);

				model.Id = p.Get<int>("@Id");

				return model;
			}
		}

		/// <summary>
		/// Saves a prize to the database. 
		/// </summary>
		/// <param name="model">The prize information</param>
		/// <returns>The prize information, includingg the unique identifier.</returns>
		public PrizeModel CreatePrize(PrizeModel model)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				var p = new DynamicParameters();
				p.Add("@PlaceNumber", model.PlaceNumber);
				p.Add("@PlaceName", model.PlaceName);
				p.Add("@PrizeAmount", model.PrizeAmount);
				p.Add("@PrizePercentage", model.PrizePercentage);
				p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

				connection.Execute("[dbo].[spPrizes_Insert]", p, commandType: CommandType.StoredProcedure);

				model.Id = p.Get<int>("@Id");				
			}
			return model;
		}

		public TeamModel CreateTeam(TeamModel model)
		{
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				var p = new DynamicParameters();
				p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
				p.Add("@TeamName", model.TeamName);

				connection.Execute("[dbo].[spTeams_Insert]", p, commandType: CommandType.StoredProcedure);

				model.Id = p.Get<int>("@Id");

				foreach (PersonModel tm in model.TeamMembers)
				{
					p = new DynamicParameters();
					p.Add("@TeamId", model.Id);
					p.Add("@PersonId", tm.Id);

					connection.Execute("[dbo].[spTeamMembers_Insert]", p, commandType: CommandType.StoredProcedure);

				}
				return model;
			}
		}

		public TournamentModel CreateTournament(TournamentModel model)
		{
			//TODO - Create Tournament in databse

			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				SaveTournament(model, connection);
				SaveTournamentPrizes(model, connection);
				SaveTournamentTeams(model, connection);
			}
			return model;
		}

		private void SaveTournamentTeams(TournamentModel model, IDbConnection connection)
		{
			foreach (TeamModel team in model.EnteredTeams)
			{
				var p = new DynamicParameters();
				p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
				p.Add("@TournamentId", model.Id);
				p.Add("@TeamId", team.Id);

				connection.Execute("[dbo].[spTournamentPrizes_Insert]", p, commandType: CommandType.StoredProcedure);
			}
		}

		private void SaveTournamentPrizes(TournamentModel model, IDbConnection connection)
		{
			foreach (PrizeModel prize in model.Prizes)
			{
				var p = new DynamicParameters();
				p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
				p.Add("@TournamentId", model.Id);
				p.Add("@PrizeId", prize.Id);

				connection.Execute("[dbo].[spTournamentPrizes_Insert]", p, commandType: CommandType.StoredProcedure);
			}
		}

		private void SaveTournament(TournamentModel model, IDbConnection connection)
		{
			var p = new DynamicParameters();
			p.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
			p.Add("@TournamentName", model.TournamentName);
			p.Add("EntryFee", model.EntryFee);

			connection.Execute("[dbo].[spTournaments_Insert]", p, commandType: CommandType.StoredProcedure);

			model.Id = p.Get<int>("@id");
		}

		public BindingList<PersonModel> GetPerson_All()
		{
			List<PersonModel> people = new List<PersonModel>();
			BindingList<PersonModel> bindingPeople;
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				people = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
			}
			bindingPeople = new BindingList<PersonModel>(people);
			return bindingPeople;
		}

		public BindingList<TeamModel> GetTeam_All()
		{
			List<TeamModel> output = new List<TeamModel>();
			BindingList<TeamModel> bindingPeople;
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				output = connection.Query<TeamModel>("dbo.spTeams_GetAll").ToList();

				foreach (TeamModel team in output)
				{
					var p = new DynamicParameters();
					p.Add("@TeamId", team.Id);

					List<PersonModel> temp = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
					team.TeamMembers = new BindingList<PersonModel>(temp);
				}
			}
			bindingPeople = new BindingList<TeamModel>(output);
			return bindingPeople;
		}
	}
}
