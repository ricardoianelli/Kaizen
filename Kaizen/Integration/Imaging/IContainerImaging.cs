using Kaizen.Integration.Common;

namespace Kaizen.Integration.Imaging;

public interface IContainerImaging : IHealthCheckable
{
    Task<ContainerState> GetContainerState();
}