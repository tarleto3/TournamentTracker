using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one prize in the tournament.
    /// </summary>
	public class PrizeModel
	{
        /// <summary>
        /// The number value for what place a team finished.
        /// ex: 1, 2, 3...
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The name of the place a team finished.
        /// ex: First, Second, Third...
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// The amount of money associated with this prize.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// The percentage of the overall prize pool this prize represents. 
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}