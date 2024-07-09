using Kaizen.CrossCutting;
using Robot.Api;

namespace Robot.Application;

public class Ur20 : IRobot
{
    public Task<HealthCheckState> GetHealth()
    {
        throw new NotImplementedException();
    }

    public Task<OperationResult> PickUp(Position position)
    {
        throw new NotImplementedException();
    }

    public Task<OperationResult> DropOff(Position position)
    {
        throw new NotImplementedException();
    }

    public void OnEStopPressed()
    {
        throw new NotImplementedException();
    }

    public void OnEStopReleased()
    {
        throw new NotImplementedException();
    }
}