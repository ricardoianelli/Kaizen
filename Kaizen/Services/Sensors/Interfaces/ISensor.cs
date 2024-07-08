using Kaizen.Common;

namespace Kaizen.Services.Sensors.Interfaces;

public interface ISensor : IHealthCheckable
{
    EventHandler OnSensorTriggered();
    bool IsTriggered();
}