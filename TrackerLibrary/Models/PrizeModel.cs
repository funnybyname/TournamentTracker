using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents the prize in a tournament.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
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

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmoutValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmoutValue);
            PrizeAmount = prizeAmoutValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
