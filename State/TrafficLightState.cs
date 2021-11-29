using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    public abstract class TrafficLightState
    {
        public abstract void HandleAutomatic(TrafficLightsContext context);

        public abstract void HandleManual();
    }
}
