using Kaizen.CrossCutting;

namespace Kaizen.Modules.Workflows.Domain.Containers;

public class ContainerTypeInformation
{
    public string Name;
    public ContainerType ContainerType;
    public List<Position> Positions;

    public ContainerTypeInformation(string name, ContainerType containerType, List<Position> positions)
    {
        Name = name;
        ContainerType = containerType;
        Positions = positions;
    }
}