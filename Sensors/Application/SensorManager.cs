using Logging.Api;
using Messaging.Api;
using Sensors.Domain;
using Topics = Sensors.Api.Topics;

namespace Sensors.Application;

internal static class SensorManager
{
    private const int SensorCheckingDelayInMs = 1000;
    
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
            try
            {
                var tasks = new List<Task>();

                foreach (var sensor in Sensors)
                {
                    sensor.UpdateState();

                    if (sensor.GetId() != 3 || !sensor.HasStateChanged()) continue;
                    tasks.Add(MessageNotifier.Publish(Topics.ImagingSensorStateChanged, sensor.GetState()));
                }

                await Task.WhenAll(tasks);
                await Task.Delay(SensorCheckingDelayInMs);
            }
            catch (Exception e)
            {
                Logger.Log(e.Message);
            }
        }
    }
}