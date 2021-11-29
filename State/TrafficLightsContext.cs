namespace TrafficLights
{
    public class TrafficLightsContext
    {
        public TrafficLightState State { get; set; }

        public TrafficLightsContext(TrafficLightState state)
        {
            State = state;
        }

        public void RequestAutomatic()
        {
            State.HandleAutomatic(this);
        }

        public void RequestManual(TrafficLightState state)
        {
            State = state;
            State.HandleManual();
        }
    }
}
