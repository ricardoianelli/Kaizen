using Robot.Api;
using Shared.CrossCutting;

namespace Robot.Application;

internal class FanucScara : IRobot
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

    public Task OnEStopPressed()
    {
        throw new NotImplementedException();
    }

    public Task OnEStopReleased()
    {
        throw new NotImplementedException();
    }
}