using Kaizen.Common;

namespace Kaizen.Services.ConveyorBelts.Interfaces;

public interface IConveyorBelt : IHealthCheckable
{
    Task<OperationResult> GetNextContainer();
    Task EjectContainer();
}