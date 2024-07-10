using Robot.Api;
using Shared.Domain.Containers;
using Shared.Domain.Sets;

namespace Workflows.Application;

internal class Planting
{
    public SetInformation CurrentSet { get; private set; }
    
    public Container? InputContainer;
    public Container? OutputContainer;
    
    private IRobot _robot;

    public Planting(IRobot robot)
    {
        _robot = robot;
    }
}