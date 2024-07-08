using Kaizen.Common;
using Kaizen.Domain.Containers.Exceptions;
using Kaizen.Domain.Materials;

namespace Kaizen.Domain.Containers;

public class Container
{
    public string Id { get; private set; }
    public ContainerType ContainerType { get; private set; }
    public Material? Material { get; private set; }

    private Dictionary<Position, WellState> _wellStates = new Dictionary<Position, WellState>();

    public Container(string id, ContainerType containerType)
    {
        Id = id;
        ContainerType = containerType;
    }

    public Dictionary<Position, WellState> GetWellStates()
    {
        return new Dictionary<Position, WellState>(_wellStates);
    }

    public WellState GetWellState(Position position)
    {
        return _wellStates.GetValueOrDefault(position, WellState.Unknown);
    }
    
    public void SetWellState(Position position, WellState wellState)
    {
        _wellStates[position] = wellState;
    }

    public void SetWellStates(Dictionary<Position, WellState> wellStates)
    {
        _wellStates = new Dictionary<Position, WellState>(wellStates);
    }

    public void AddMaterial(Material material)
    {
        if (Material != null)
        {
            throw new ContainerNotEmptyException(this, material);
        }
        
        material.ChangeContainer(this);
        Material = material;
    }

    public void RemoveMaterial()
    {
        Material?.ChangeContainer(null);
        Material = null;
    }

    public void Validate()
    {
        
    }
}