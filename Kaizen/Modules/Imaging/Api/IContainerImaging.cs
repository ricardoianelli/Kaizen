using Kaizen.CrossCutting;
using Kaizen.Modules.Imaging.Domain;

namespace Kaizen.Modules.Imaging.Api;

public interface IContainerImaging : IHealthCheckable
{
    Task<ContainerState> GetContainerState();
}