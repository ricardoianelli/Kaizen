using Kaizen.Common;

namespace Kaizen.Services.Imaging.Interfaces;

public interface IContainerImaging : IHealthCheckable
{
    Task<ContainerState> GetContainerState();
}