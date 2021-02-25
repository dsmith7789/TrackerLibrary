using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The "friendly" name for the place (second place, first runner up, etc.)
        /// </summary>
        public String PlaceName { get; set; }

        /// <summary>
        /// The fixed amount this place earns or zero if it is not used.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The number that represents the percentage of the overall take or 
        /// zero if it is not used. The percentage is a fraction of 1 (so 0.5
        /// for 50%).
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel(String placeNumber, String placeName, String prizeAmount, String prizePercentage)
        {
            this.PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            this.PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            this.PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            this.PrizePercentage = prizePercentageValue;
        }

        public PrizeModel()
        {

        }
    }
}
