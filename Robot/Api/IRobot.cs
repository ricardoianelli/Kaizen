using Kaizen.CrossCutting;
using Safety.Api;

namespace Robot.Api;

public interface IRobot : IHealthCheckable, IEStopListener
{
    Task<OperationResult> PickUp(Position position);
    Task<OperationResult> DropOff(Position position);
}