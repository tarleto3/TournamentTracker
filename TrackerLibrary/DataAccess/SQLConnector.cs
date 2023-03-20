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
        // TODO - Make the CreatePrize method acutually save to the databse. 
        /// <summary>
        /// Saves a prize to the database. 
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information, includingg the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
			using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Tournaments")))
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
    }
}
