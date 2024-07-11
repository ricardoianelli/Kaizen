using Sensors.Api;
using Shared.CrossCutting;

namespace Sensors.Domain;

internal interface ISensor : IHealthCheckable
{
    int GetId();
    SensorState GetPreviousState();
    SensorState GetState();
    bool IsTriggered();
    bool HasStateChanged();
    void UpdateState();
}