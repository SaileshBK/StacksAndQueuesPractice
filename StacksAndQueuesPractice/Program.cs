using System;

namespace StacksAndQueuesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiating new BusStop and Bus.
            BusStop busStop = new BusStop();
            Bus bus = new Bus();

            // loop that has 6 people arrive at bus stop
            for (int i = 0; i < 6; i++)
                busStop.PassengerArrive(PassengerGenerator.CreatePassenger());
            // pick up passenger it can
            busStop.BusArrive(bus);
            // dropping up passenger from the bus.
            bus.ArrivedAtTerminus();
            
        }
    }
}
