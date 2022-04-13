using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adi.Models
{
    public class Floor
    {
        private int MaxFloor { get; set; }
        public int NumberOfFloor { get; private set; }
        public List<Passenger> PassengerList { get; private set; } = new List<Passenger>();

        public Floor(int numberOfFloor, int maxFloor)
        {
            NumberOfFloor = numberOfFloor;
            MaxFloor = maxFloor;
            FillThePassengers();
        }
        private void FillThePassengers()
        {
            Random random = new Random();
            for (int i = 0; i < random.Next(0, 10); i++)
            {
                var newPassenger = new Passenger(NumberOfFloor, MaxFloor);
                newPassenger.DefineTheWay();
                this.PassengerList.Add(newPassenger);
            }
        }
        public void LeftedPassenger(Passenger ps)
        {
            this.PassengerList.Add(ps);
        }
    }
}
