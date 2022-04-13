using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adi.Models
{
    public class Lift
    {
        public int MaxFloor { get;private set; }
        public int MaxWantedFloor { get;private set; }
        public int CurrentFloor { get;private set; }
        public Ways Way { get;private set; }
        public List<Passenger>? Passengers { get; private set; } = new List<Passenger>();

        public Lift(int maxFloor)
        {
            MaxFloor = maxFloor;
        }
        public void Move()
        {
            if(CurrentFloor == 0)
                Way = Ways.Up;
            if(CurrentFloor == MaxFloor)
                Way = Ways.Down;
            if(Way == Ways.Up)
            {
                CurrentFloor++;
                Console.WriteLine("Current floor is : " + CurrentFloor + "The way is " + Way.ToString());
            }
            if(Way == Ways.Down)
            {
                CurrentFloor--;
                Console.WriteLine("Current floor is : " + CurrentFloor + "The way is " + Way.ToString());
            }
        }
        public void Take(Passenger passenger)
        {
            if(passenger == null)
                throw new ArgumentNullException(nameof(passenger));
            if(this.Passengers.Count() < 5)
            {
                if (passenger.Way == Way)
                {
                    this.Passengers.Add(passenger);
                    Console.WriteLine("This passenger is moving to " + passenger.WantedFloor);
                    Console.WriteLine("The count of passenger " + Passengers.Count());
                }
            }
        }
        public Passenger Left()
        {
            if(this.Passengers == null)
                throw new ArgumentNullException(nameof(this.Passengers));
            for(int i = 0; i < this.Passengers.Count(); i++)
            {
                if(Passengers[i].WantedFloor == CurrentFloor)
                {
                    var leavingPass = this.Passengers[i];
                    this.Passengers.Remove(Passengers[i]);
                    Console.WriteLine("This is the left passenger: " + leavingPass);
                    return leavingPass;
                }
            }
            return null;
        }

    }
}
