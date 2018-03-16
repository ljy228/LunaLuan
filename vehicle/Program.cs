using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            //(car 1) with licence plate NF123456, 147 kW engine power, maximal speed of 200 km/h, green colour and type of personal vehicle
            Car car1 = new Car();
            car1.licence = "NF123456";
            car1.engine_power = 147;
            car1.maximal_speed = 200;
            car1.colour = "green";
            car1.type = "personal";
           

            //car(car 2) with licence plate NF654321, 150 kW engine power, maximal speed of 195 km / h, blue colour and type of personal vehicle
            Car car2 = new Car();
            car2.licence = "NF654321";
            car2.engine_power = 150;
            car2.maximal_speed = 195;
            car2.colour = "blue";
            car2.type = "personal";

            //a plane with registration LN1234, 1000 kW engine power, 30m wingspan, 2t load capacity and 10t net weight, flying class of jet plane
            Plane plan1 = new Plane();
            plan1.licence = "LN1234";
            plan1.engine_power = 1000;
            plan1.wingspan = 30;
            plan1.load_capacity = 2;
            plan1.net_weight = 10;
            plan1.type = "jet plane";

            //a boat with registration ABC123, 100 kW engine power, maximal speed of 30 knot per hour and 500 kg gross tonnage
            Boat boat1 = new Boat();
            boat1.licence = "ABC123";
            boat1.engine_power = 100;
            boat1.maximal_speed = 30;
            boat1.gross_tonnage = 500;

            Vehicle.Print("=================================================================");
            car1.Drive();
            Vehicle.Print("=================================================================");
            Vehicle.Print("This is the information of the car1:");
            Vehicle.Print(car1.GetInfo());
            Vehicle.Print("=================================================================");
            Vehicle.Print("This is the information of the car2:");
            Vehicle.Print(car2.GetInfo());
            Vehicle.Print("=================================================================");
            Vehicle.Print(car1.Equals(car2) ? "two cars are same Vehicle!" : "two cars are different Vehicle!");
            Vehicle.Print("=================================================================");
            plan1.Fly();
            Vehicle.Print("=================================================================");
            Vehicle.Print("This is the information of the plane:");
            Vehicle.Print(plan1.GetInfo());
            Vehicle.Print("=================================================================");
            Vehicle.Print("This is the information of the boat:");
            Vehicle.Print(boat1.GetInfo());
            Vehicle.Print("=================================================================");

            Console.Write("Please press any key to close this window!");
            Console.ReadKey();



        }
    }
}
