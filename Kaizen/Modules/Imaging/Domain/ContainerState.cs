using Kaizen.CrossCutting;
using Kaizen.Modules.Workflows.Domain.Containers;

namespace Kaizen.Modules.Imaging.Domain;

public class ContainerState
{
    public Dictionary<Position, WellState> WellStates;

    public ContainerState(Dictionary<Position, WellState> wellStates)
    {
        WellStates = new Dictionary<Position, WellState>(wellStates);
    }
}