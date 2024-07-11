using Logging.Api;
using Messaging.Api;
using Sensors.Domain;

namespace Sensors.Application;

internal static class SensorManager
{
    private const int SensorCheckingDelayInMs = 1000;
    private const string SensorStateChangedTopic = "SensorStateChanged";
    
    private static readonly List<ISensor> Sensors = [];
    
    
    static SensorManager()
    {
        Sensors.Add(new Sensor(1, Location.InputConveyorEntrance));
        Sensors.Add(new Sensor(2, Location.InputConveyorPackageScanner));
        Sensors.Add(new Sensor(3, Location.InputConveyorImagingArea));
    }
    
    public static void Initialize()
    {
        _ = CheckSensors();
    }

    private static async Task CheckSensors()
    {
        while (true)
        {
            Logger.Log("Checking sensors...");
            
            var tasks = new List<Task>();

            foreach (var sensor in Sensors)
            {
                sensor.UpdateState();

                if (!sensor.HasStateChanged()) return;
                tasks.Add(MessageBroker.Publish(SensorStateChangedTopic, sensor.GetState()));
            }

            await Task.WhenAll(tasks);
            await Task.Delay(SensorCheckingDelayInMs);
        }
    }
}