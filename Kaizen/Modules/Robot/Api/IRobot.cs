using Kaizen.CrossCutting;
using Kaizen.Modules.Safety.Api;

namespace Kaizen.Modules.Robot.Api;

public interface IRobot : IHealthCheckable, IEStopListener
{
    Task<OperationResult> PickUp(Position position);
    Task<OperationResult> DropOff(Position position);
}