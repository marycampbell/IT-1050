using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator(2, 400);
            Elevator elevator2 = new Elevator(3, 600);
            bool elevator1IsOverMaxCapacity;
            bool elevator2IsOverMaxCapacity;

            Passenger p1 = new Passenger("A1", 180);
            Passenger p2 = new Passenger("A2", 220);
            Passenger p3 = new Passenger("A1", 200);
            Passenger p4 = new Passenger("A2", 200);
            Passenger p5 = new Passenger("A3", 201);

            elevator1.AddOccupant(p1, 0);
            elevator1.AddOccupant(p2, 1);
            elevator2.AddOccupant(p3, 0);
            elevator2.AddOccupant(p4, 1);
            elevator2.AddOccupant(p5, 2);
            
            elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();
            elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();           

        }
    }
}
