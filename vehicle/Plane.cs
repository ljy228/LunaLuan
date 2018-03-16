using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
   public class Plane:Vehicle
    {
        public int wingspan { get; set; }
        public int load_capacity { get; set; }
        public int net_weight { get; set; }



        public void Fly()
        {

            Vehicle.Print("Plane is flying!");
        }

        public string GetInfo()
        {

            string info = @"Registration " + this.licence + ", " + this.engine_power +
                " kW engine power, " + this.wingspan + "m wingspan, " + this.load_capacity +
                "t load capacity and " + this.net_weight + "t net weight, flying class of "+ this.type;

            return info;
        }
    }
}
