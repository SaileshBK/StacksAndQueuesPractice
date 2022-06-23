using System;

namespace StacksAndQueuesPractice
{
    // creates the passenger instances 
    public static class PassengerGenerator
    {
        // this static inc counts how many passenger created so far.
        private static int _count = 0;
        // using this random instance to determine the destination.
        private static Random _rnd = new Random();

        public static Passenger CreatePassenger()
        {
            // here Random assigns the destinaion to be either Moorhead or Fargo each time creating a passenger.
            string destination = _rnd.Next(2) ==0 ? "Moorhead" : "Fargo";
            // counting each passenger and assigning number.
            return new Passenger($"Person {++_count}", destination);
        }
    }
}