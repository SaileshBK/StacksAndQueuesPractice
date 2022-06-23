using System;

namespace StacksAndQueuesPractice
{
    // creates the passenger instances 
    public static class PassengerGenerator
    {
        // this static inc counts how many passenger created so far.
        private static int _count = 0;

        public static Passenger CreatePassenger()
        {
            string destination = "Moorhead";
            // counting each passenger and assigning number.
            return new Passenger($"Person {++_count}", destination);
        }
    }
}