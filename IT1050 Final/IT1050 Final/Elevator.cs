using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_Final
{
    class Elevator

    {
        private double MaxWeight = 0;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            this.Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }

        public void AddOccupant (Passenger passenger, int index)
        {
            this.Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double tempWeight = 0;
            for (int i = 0; i < Occupants.Length; ++i)
            {
                tempWeight = tempWeight + this.Occupants[i].GetWeight();
            }

            return tempWeight;
        }

        public bool IsOverMaxCapacity()
        {
            if (this.GetCurrentWeight() > this.MaxWeight)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    



    }
}
