using Kaizen.CrossCutting;

namespace Sensors.Api;

public interface ISensor : IHealthCheckable
{
    EventHandler OnSensorTriggered();
    bool IsTriggered();
}