using Kaizen.Modules.Robot.Api;
using Kaizen.Modules.Workflows.Domain.Containers;
using Kaizen.Modules.Workflows.Domain.Sets;

namespace Kaizen.Modules.Workflows.Service;

public class PlantingService
{
    public SetInformation CurrentSet { get; private set; }
    
    public Container? InputContainer;
    public Container? OutputContainer;
    
    private IRobot _robot;

    public PlantingService(IRobot robot)
    {
        _robot = robot;
    }
}