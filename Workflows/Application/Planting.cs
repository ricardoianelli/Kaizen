using Kaizen.Domain.Containers;
using Kaizen.Domain.Sets;
using Robot.Api;

namespace Workflows.Application;

public class Planting
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