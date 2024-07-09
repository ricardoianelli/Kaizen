using Kaizen.CrossCutting;
using Kaizen.Modules.Safety.Api;

namespace Kaizen.Modules.ConveyorBelts.Api;

public interface IConveyorBelt : IHealthCheckable, IEStopListener
{
    Task<OperationResult> GetNextContainer();
    Task EjectContainer();
}