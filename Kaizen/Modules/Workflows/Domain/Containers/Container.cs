using Kaizen.CrossCutting;
using Kaizen.Modules.Workflows.Domain.Containers.Exceptions;
using Kaizen.Modules.Workflows.Domain.Materials;

namespace Kaizen.Modules.Workflows.Domain.Containers;

public class Container
{
    public string Id { get; private set; }
    public ContainerType ContainerType { get; private set; }
    public readonly Dictionary<Position, Material?> Materials = new Dictionary<Position, Material?>();
    
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

    public void AddMaterial(Material material, Position position)
    {
        if (Materials.TryGetValue(position, out var oldMaterial))
        {
            if (oldMaterial != null)
            {
                throw new ContainerNotEmptyException(this, oldMaterial); 
            }
        }
        
        material.SetContainer(this, position);
        Materials[position] = material;
    }

    public void RemoveMaterial(Position position)
    {
        if (!Materials.TryGetValue(position, out var material)) return;
        
        material?.SetContainer(null);
        Materials[position] = null;
    }

    public void Validate()
    {
        
    }
}