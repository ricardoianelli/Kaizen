using Kaizen.Common;
using Kaizen.Services.Robot.Interfaces;

namespace Kaizen.Services.Robot;

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
}