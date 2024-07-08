using Kaizen.Common;

namespace Kaizen.Services.Robot.Interfaces;

public interface IRobot : IHealthCheckable
{
    Task<OperationResult> PickUp(Position position);
    Task<OperationResult> DropOff(Position position);
}