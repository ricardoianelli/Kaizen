using Kaizen.Domain.Containers;

namespace Kaizen.Domain.Materials;

public class Material
{
    public string Id { get; private set; }
    public MaterialType MaterialType { get; private set; }
    public Container? Container { get; private set; }

    public Material(string id, MaterialType materialType, Container container)
    {
        Id = id;
        MaterialType = materialType;
        Container = container;
    }

    public void ChangeContainer(Container? newContainer)
    {
        Container = newContainer;
    }
}