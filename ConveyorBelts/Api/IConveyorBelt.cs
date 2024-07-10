using Safety.Api;
using Shared.CrossCutting;

namespace ConveyorBelts.Api;

public interface IConveyorBelt : IHealthCheckable, IEStopListener
{
    Task<OperationResult> GetNextContainer();
    Task EjectContainer();
}