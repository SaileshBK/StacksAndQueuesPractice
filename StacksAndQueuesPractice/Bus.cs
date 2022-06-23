using System;
using System.Collections.Generic;

namespace StacksAndQueuesPractice
{
    // class that represent bus that will pick up passengers.
    public class Bus
    {
        // list of passenger currently on the bus.
        private List<Passenger> _passenger = new List<Passenger>();
        // max number of people bus can hold.
        private const int Capacity = 5;
        // this returns the remaining seat left.
        public int Space { get => Capacity - _passenger.Count; }

        // returns true and false based on the remaining space and Adds passenger if there is space.
        public bool Load(Passenger passenger)
        {
            if (Space < 1)
                return false;

            _passenger.Add(passenger);
            Console.WriteLine($"{passenger} goes to the bus");
            return true;
        }
    }
}