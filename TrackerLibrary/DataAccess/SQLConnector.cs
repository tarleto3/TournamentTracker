using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
		
		private string db = "Tournaments"
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

				return model;
			}
		}

		public List<PersonModel> GetPerson_All()
		{
			List<PersonModel> people;
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
			{
				people = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
			}
			return people;
		}
	}
}
