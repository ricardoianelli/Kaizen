using Kaizen.Domain.Materials;

namespace Kaizen.Domain.Containers.Exceptions;

public class ContainerNotEmptyException : Exception
{
    public readonly string ContainerId;
    public readonly string MaterialId;
    
    public new string Message;

    public ContainerNotEmptyException(Container container, Material material)
    {
        ContainerId = container.Id;
        MaterialId = material.Id;
        Message = $"Tried to add material {MaterialId} to container {ContainerId} which already contains material {container.Material?.Id}";
    }
}