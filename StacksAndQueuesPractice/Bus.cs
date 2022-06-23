using System;
using System.Collections.Generic;

namespace StacksAndQueuesPractice
{
    // class that represent bus that will pick up passengers.
    public class Bus
    {
        // list of passenger currently on the bus.
        private LinkedList<Passenger> _passenger = new LinkedList<Passenger>();
        // max number of people bus can hold.
        private const int Capacity = 5;
        // this returns the remaining seat left.
        public int Space { get => Capacity - _passenger.Count; }

        // returns true and false based on the remaining space and Adds passenger if there is space.
        public bool Load(Passenger passenger)
        {
            if (Space < 1)
                return false;
            // in LinkedList AddLast is used to add item to the end of the list. However, we can also use AddFirst to add item to the first.
            _passenger.AddLast(passenger);
            Console.WriteLine($"{passenger} goes to the bus");
            return true;
        }

        public void ArrivedAt(string place)
        {
            Console.WriteLine($"\r\nBus arriving at {place}");
            // checking if anyone in the bus.
            if (_passenger.Count == 0)
                return;
            // identifying all the passengers who are getting off here from the linked list. 
            // here getting first item in LinkedList and storing in local variable currentNode.
            LinkedListNode<Passenger> currentNode = _passenger.First;

            do
            {
                // here .Next property looks up and temporarily stores the next node.
                LinkedListNode<Passenger> nextNode = currentNode.Next;
                // LinkedList.Value gives here the passenger instance and we are checking if the passenger destination matches.
                if (currentNode.Value.Destination == place)
                {
                    Console.WriteLine($"{currentNode.Value} is getting off");
                    // removing item from the LinkedList.
                    _passenger.Remove(currentNode);
                }
                // this runs untill the currentNode becomes null.
                currentNode = nextNode;

            } while (currentNode != null);
            Console.WriteLine($"{_passenger.Count} people left on bus");
        }
    }
}