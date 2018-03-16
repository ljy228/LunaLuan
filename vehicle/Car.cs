using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    public class Car : Vehicle
    {
        public int maximal_speed { get; set; }
        public string colour { get; set; }


        public void Drive()
        {
            //drive

            Vehicle.Print("Car has been started!");

        }

         public string  GetInfo() 
        {

            string info = @"licence plate " + this.licence + ", " + this.engine_power +
                " kW engine power, maximal speed of " + this.maximal_speed + " km/h, " + this.colour + 
                " colour and type of " + this.type + " vehicle";

            return info;
        }

        public bool IsEqual(Car car2)
        {
            if (car2.licence != this.licence)
            {
                return false;
            }
            if (car2.maximal_speed != this.maximal_speed)
            {
                return false;
            }
            if (car2.engine_power != this.engine_power)
            {
                return false;
            }
            if (car2.colour != this.colour)
            {
                return false;
            }
            if (car2.type != this.type)
            {
                return false;
            }
            return true;

        }

    }
}
