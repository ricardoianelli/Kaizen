using Kaizen.Modules.Workflows.Domain.Materials;

namespace Kaizen.Modules.Workflows.Domain.Containers.Exceptions;

public class ContainerNotEmptyException : Exception
{
    public readonly string ContainerId;
    public readonly string MaterialId;
    
    public new string Message;

    public ContainerNotEmptyException(Container container, Material oldMaterial)
    {
        ContainerId = container.Id;
        MaterialId = oldMaterial.Id;
        Message = $"Tried to add new material to container {ContainerId} which already contains material {MaterialId}";
    }
}