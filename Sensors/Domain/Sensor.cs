using Shared.CrossCutting;

namespace Sensors.Domain;

internal class Sensor : ISensor
{
    public readonly int Id;
    public readonly Location Location;

    public SensorState PreviousState = SensorState.Unknown;
    public SensorState CurrentState = SensorState.Unknown;

    public Sensor(int id, Location location)
    {
        Id = id;
        Location = location;
    }

    public int GetId() => Id;

    public SensorState GetState()
    {
        return CurrentState;
    }
    
    public SensorState GetPreviousState()
    {
        return PreviousState;
    }

    public bool HasStateChanged()
    {
        return PreviousState != CurrentState;
    }

    public bool IsTriggered()
    {
        return CurrentState == SensorState.On;
    }
    
    public async Task<HealthCheckState> GetHealth()
    {
        return HealthCheckState.Healthy;
    }
    
    public void UpdateState()
    {
        PreviousState = CurrentState;

        //Fake behavior added for tests.
        var random = new Random();
        if (random.Next(0, 10) == 3)
        {
            CurrentState = CurrentState == SensorState.On ? SensorState.Off : SensorState.On;
        }    
    }
}