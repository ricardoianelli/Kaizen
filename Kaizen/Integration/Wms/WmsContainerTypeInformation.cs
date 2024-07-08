using Kaizen.Common;
using Kaizen.Domain.Containers;

namespace Kaizen.Integration.Wms;

public class WmsContainerTypeInformation
{
    public string Name;
    public int ContainerTypeId;
    public List<Position> Positions;

    public WmsContainerTypeInformation(string name, int containerTypeId, List<Position> positions)
    {
        Name = name;
        ContainerTypeId = containerTypeId;
        Positions = positions;
    }

    public ContainerTypeInformation ToContainerTypeInformation()
    {
        return new ContainerTypeInformation(Name, (ContainerType) ContainerTypeId, Positions);
    }
}