using System;
using System.Collections.Generic;

namespace StacksAndQueuesPractice
{
    // class that represent bus that will pick up passengers.
    public class Bus
    {
        // list of passenger currently on the bus.
        private Stack<Passenger> _passenger = new Stack<Passenger>();
        // max number of people bus can hold.
        private const int Capacity = 5;
        // this returns the remaining seat left.
        public int Space { get => Capacity - _passenger.Count; }

        // returns true and false based on the remaining space and Adds passenger if there is space.
        public bool Load(Passenger passenger)
        {
            if (Space < 1)
                return false;
            // in stack we use Push to add item and pop to remove item from Stack.
            _passenger.Push(passenger);
            Console.WriteLine($"{passenger} goes to the bus");
            return true;
        }

        public void ArrivedAtTerminus()
        {
            Console.WriteLine($"\r\nBus arriving at terminus");
            // loop to get each passenger get off.
            while (_passenger.Count > 0)
            {
                // removes the next item from the Stack. It will choose the item that is most recently added.
                Passenger passenger = _passenger.Pop();
                Console.WriteLine($"{passenger} got off the bus");
            }
            Console.WriteLine($"There are {_passenger.Count} people still on the bus");
        }
    }
}