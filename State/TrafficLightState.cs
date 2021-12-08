namespace State
{
    public abstract class TrafficLightState
    {
        public abstract void HandleAutomatic(TrafficLightsContext context);

        public abstract void HandleManual();
    }
}
