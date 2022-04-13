using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adi.Models
{
    public class Passenger
    {
        public int CurrentFloor { get; private set; }
        public int WantedFloor { get; private set; }
        public Ways Way { get; private set; }

        public Passenger(int currentFloor, int maxFloor)
        {
            CurrentFloor = currentFloor;
            GenerateWantedFloor(maxFloor);
            DefineTheWay();
        }

        public void GenerateWantedFloor(int MaxFloor)
        {
            Random random = new Random();
            this.WantedFloor = random.Next(0, MaxFloor);
        }
        public void DefineTheWay()
        {
            if (CurrentFloor < WantedFloor)
                this.Way = Ways.Up;
            if (CurrentFloor > WantedFloor)
                this.Way = Ways.Down;
        }
    }
}
public enum Ways
{
    Up,
    Down
}
