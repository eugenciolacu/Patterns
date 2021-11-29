using System;

namespace TrafficLights
{
    public class TrafficLightsGreenState : TrafficLightState
    {
        public override void HandleAutomatic(TrafficLightsContext context)
        {
            Console.WriteLine("Green");
            System.Threading.Thread.Sleep(1000);
            context.State = new TrafficLightsRedState();
        }

        public override void HandleManual()
        {
            Console.WriteLine("Green");
            System.Threading.Thread.Sleep(1000);
        }
    }
}
