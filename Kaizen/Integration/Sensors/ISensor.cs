namespace Kaizen.Integration.Sensors;

public interface ISensor
{
    EventHandler OnSensorTriggered();
    bool IsTriggered();
}