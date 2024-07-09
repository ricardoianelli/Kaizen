using Kaizen.CrossCutting;

namespace Kaizen.Modules.Sensors.Api;

public interface ISensor : IHealthCheckable
{
    EventHandler OnSensorTriggered();
    bool IsTriggered();
}