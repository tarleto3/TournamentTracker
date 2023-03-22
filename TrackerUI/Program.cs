using static TrackerLibrary.Enums;

namespace TrackerUI
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();

			//Initialize Database Connections
			TrackerLibrary.GlobalConfig.InitializeConnections(DatabaseType.TextFile);
			//Application.Run(new TournamentDashboard());
			Application.Run(new CreateTeam());
		}
	}
}