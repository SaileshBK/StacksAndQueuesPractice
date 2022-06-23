using System;
using System.Collections.Generic;

namespace StacksAndQueuesPractice
{
    public class BusStop
    {
        private Queue<Passenger> _passengerWaiting = new Queue<Passenger>();

        // this handles passenger joining the queue.
        public void PassengerArrive(Passenger passenger)
        {
            // this Enqueue method adds the passenger.
            _passengerWaiting.Enqueue(passenger);
            Console.WriteLine($"{passenger} is queing at the bus stop.");
            
        }

        // this handles Bus picking up people from the queue.
        public void BusArrive(Bus bus)
        {
            Console.WriteLine("\r\nBus arriving at the bus stop to load passengers.");
            // this loop continues while there is at least 1 person on queue and at least 1 space on the bus.
            while (bus.Space > 0 && _passengerWaiting.Count > 0)
            {
                // here passenger gets removed from the queue.
                Passenger passenger = _passengerWaiting.Dequeue();
                // the dequeued passenger now loads the bus.
                bus.Load(passenger);
            }
            
        }
    }
}