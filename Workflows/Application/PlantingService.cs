using Kaizen.Domain.Containers;
using Kaizen.Domain.Sets;
using Robot.Api;

namespace Workflows.Service;

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