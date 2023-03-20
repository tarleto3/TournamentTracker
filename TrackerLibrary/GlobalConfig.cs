using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using static TrackerLibrary.Enums;

namespace TrackerLibrary
{
    public static class GlobalConfig
	{
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType connectionType)
        {
            if(connectionType == DatabaseType.Sql)
            {
                
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }

            else if(connectionType == DatabaseType.TextFile)
            {
                
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
