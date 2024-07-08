using Kaizen.Common;
using Kaizen.Integration.Common;

namespace Kaizen.Integration.Robot;

public interface IRobot
{
    Task<OperationResult> PickUp(Position position);
    Task<OperationResult> DropOff(Position position);
    Task<HealthCheckState> GetHealth();
}