using Shared.CrossCutting;
using Shared.Domain.Containers;

namespace Imaging.Api;

public interface IContainerImaging : IHealthCheckable
{
    Task<ContainerState> GetContainerState();
}