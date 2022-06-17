using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents a Team in a tournament.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Contains the list of team members.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Contains the name of the team.
        /// </summary>
        public string TeamName { get; set; }

    }
}
