using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the prize in a tournament.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place to which this price belongs.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the name of the place to which this price belongs.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Contains the prize amount.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Contains the price percentage for calculation of the price amount.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
