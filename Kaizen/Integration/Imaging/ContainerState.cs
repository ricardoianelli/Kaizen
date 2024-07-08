using Kaizen.Common;
using Kaizen.Domain.Containers;

namespace Kaizen.Integration.Imaging;

public class ContainerState
{
    public Dictionary<Position, WellState> WellStates;

    public ContainerState(Dictionary<Position, WellState> wellStates)
    {
        WellStates = new Dictionary<Position, WellState>(wellStates);
    }
}