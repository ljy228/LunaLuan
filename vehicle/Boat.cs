using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    public class Boat : Vehicle
    {
        public int maximal_speed { get; set; }
        public int gross_tonnage { get; set; }

        public string GetInfo()
        {

            string info = @"registration  " + this.licence + ", " + this.engine_power +
                " kW engine power, maximal speed of " + this.maximal_speed + " knot per hour and " + this.gross_tonnage +
                " kg gross tonnage";

            return info;
        }
    }
}
