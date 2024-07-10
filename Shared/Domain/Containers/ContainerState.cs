using Shared.CrossCutting;

namespace Shared.Domain.Containers;

public class ContainerState
{
    public Dictionary<Position, WellState> WellStates;

    public ContainerState(Dictionary<Position, WellState> wellStates)
    {
        WellStates = new Dictionary<Position, WellState>(wellStates);
    }
}