using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents an individual team.
    /// </summary>
	public class TeamModel
    {
        /// <summary>
        /// The name of this team.
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// The list of members in the team. 
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

    }
}
