using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the tournament. 
    /// Contains all the info of the tournament.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// Contains the tournament name.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Contains the entry fee for the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Contains the list of entered teams for the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Contains the list of prizes for the tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Contains the round infos for the matchup.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
