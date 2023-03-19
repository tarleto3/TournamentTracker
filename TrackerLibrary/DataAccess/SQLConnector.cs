using System;
using System.Collections.Generic;
using System.Data;
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
            using (IDbConnection conn = new System.Data.SqlClient.SQLConnection(GlobalConfig.CnnString("Tournaments")))
            {

            }
        }
    }
}
