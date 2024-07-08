using Kaizen.Integration.Common;

namespace Kaizen.Integration.ConveyorBelts;

public interface IConveyorBelt : IHealthCheckable
{
    Task<OperationResult> GetNextContainer();
    Task EjectContainer();
}