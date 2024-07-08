using Kaizen.Integration.Common;

namespace Kaizen.Integration.Imaging;

public interface IContainerImaging
{
    Task<ContainerState> GetContainerState();
    Task<HealthCheckState> GetHealth();
}