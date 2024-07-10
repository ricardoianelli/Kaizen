using Shared.CrossCutting;
using Shared.Domain.Containers;

namespace Shared.Domain.Materials;

public class Material
{
    public string Id { get; private set; }
    public MaterialType MaterialType { get; private set; }
    public Container? Container { get; private set; }
    public Position Position { get; private set; }

    public Material(string id, MaterialType materialType, Container container)
    {
        Id = id;
        MaterialType = materialType;
        Container = container;
    }
    
    public void SetContainer(Container? newContainer)
    {
        Container = newContainer;
    }

    public void SetContainer(Container? newContainer, Position position)
    {
        SetContainer(newContainer);
        SetPosition(position);
    }

    public void SetPosition(Position position)
    {
        Position = position;
    }
}