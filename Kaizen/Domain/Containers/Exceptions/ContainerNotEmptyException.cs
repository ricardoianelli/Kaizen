using Kaizen.Domain.Materials;

namespace Kaizen.Domain.Containers.Exceptions;

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