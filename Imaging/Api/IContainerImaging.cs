using Imaging.Domain;
using Kaizen.CrossCutting;

namespace Imaging.Api;

public interface IContainerImaging : IHealthCheckable
{
    Task<ContainerState> GetContainerState();
}