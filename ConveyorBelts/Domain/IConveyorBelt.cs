using Shared.CrossCutting;

namespace ConveyorBelts.Domain;

internal interface IConveyorBelt : IHealthCheckable
{
    Task<OperationResult> GetNextContainer();
    Task<OperationResult> EjectContainer();
}