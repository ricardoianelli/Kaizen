using Kaizen.CrossCutting;
using Kaizen.Modules.Robot.Api;

namespace Kaizen.Modules.Robot.Service;

public class UR20 : IRobot
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