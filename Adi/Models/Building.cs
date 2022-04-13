using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adi.Models
{
    public class Building
    {
        private Lift Lift { get; set; }
        private List<Floor> Floor { get; set; } = new List<Floor>();
        private int MaxFloor { get; set; }

        public Building(Lift lift, int maxFloor)
        {
            Lift = lift;
            MaxFloor = maxFloor;
            StartTheProgram();
        }

        private void StartTheProgram()
        {
            for (int i = 0; i < MaxFloor; i++)
            {
                Floor.Add(new Floor(i, MaxFloor));
            }
        }
        public void Move()
        {
            Lift.Move();
            for(int i = 0; i < Floor.Count(); i++)
            {
                for(int j = 0; j < Floor[i].PassengerList.Count(); j++)
                {
                    Lift.Take(Floor[i].PassengerList[j]);
                    var x = Lift.Left();
                    if (x != null)
                        Floor[i].LeftedPassenger(x);
                }
            }
        }
        private void AddTheLeftedPassenger()
        {
            for(int i = 0; i < MaxFloor; i++)
            {
            }
        }
    }
}
