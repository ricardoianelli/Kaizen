using Safety.Api;
using Shared.CrossCutting;

namespace Robot.Api;

public interface IRobot : IHealthCheckable, IEStopListener
{
    Task<OperationResult> PickUp(Position position);
    Task<OperationResult> DropOff(Position position);
}