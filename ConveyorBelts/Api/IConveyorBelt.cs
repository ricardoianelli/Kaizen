using Kaizen.CrossCutting;
using Safety.Api;

namespace ConveyorBelts.Api;

public interface IConveyorBelt : IHealthCheckable, IEStopListener
{
    Task<OperationResult> GetNextContainer();
    Task EjectContainer();
}