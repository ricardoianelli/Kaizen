using Shared.CrossCutting;

namespace Robot.Api;

public interface IRobot : IHealthCheckable
{
    Task<OperationResult> PickUp(Position position);
    Task<OperationResult> DropOff(Position position);
}