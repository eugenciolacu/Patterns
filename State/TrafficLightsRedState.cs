using System;

namespace State
{
    public class TrafficLightsRedState : TrafficLightState
    {
        public override void HandleAutomatic(TrafficLightsContext context)
        {
            Console.WriteLine("RED");
            System.Threading.Thread.Sleep(1000);
            context.State = new TrafficLightsYellowState();
        }

        public override void HandleManual()
        {
            Console.WriteLine("RED");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
