﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents an entire tournament
    /// </summary>
	public class TournamentModel
	{
        /// <summary>
        /// The name of the specific tournament. 
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// The entry fee to participate in the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// The list of teams that are entered into the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// The list of prizes available for winners of the tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// The list of the different matchups for the tournament. 
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
