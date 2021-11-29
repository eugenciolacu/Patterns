using System;

namespace TrafficLights
{
    public class TrafficLightsYellowState : TrafficLightState
    {
        public override void HandleAutomatic(TrafficLightsContext context)
        {
            Console.WriteLine("Yellow");
            System.Threading.Thread.Sleep(1000);
            context.State = new TrafficLightsGreenState();
        }

        public override void HandleManual()
        {
            Console.WriteLine("Yellow");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
