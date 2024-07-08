using Kaizen.Common;
using Kaizen.Domain.Containers;

namespace Kaizen.Services.Imaging;

public class ContainerState
{
    public Dictionary<Position, WellState> WellStates;

    public ContainerState(Dictionary<Position, WellState> wellStates)
    {
        WellStates = new Dictionary<Position, WellState>(wellStates);
    }
}