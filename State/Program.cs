using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State Pattern is a behavioral pattern that allows an object to control its beheavor based on its internal state.");

            TrafficLightsContext trafficLights = new TrafficLightsContext(new TrafficLightsRedState());

            trafficLights.RequestAutomatic();
            trafficLights.RequestAutomatic();
            trafficLights.RequestAutomatic();

            Console.WriteLine();

            trafficLights.RequestManual(new TrafficLightsRedState());
            trafficLights.RequestManual(new TrafficLightsYellowState());
            trafficLights.RequestManual(new TrafficLightsGreenState());
        }
    }
}
