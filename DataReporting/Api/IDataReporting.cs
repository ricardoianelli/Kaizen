using Shared.CrossCutting;
using Shared.Domain.Containers;
using Shared.Domain.Materials;
using Shared.Domain.Sets;

namespace DataReporting.Api;

public interface IDataReporting : IHealthCheckable
{
    Task<List<string>> GetSetList();
    Task<SetInformation> GetSetInformation(string setId);
    
    Task<ContainerTypeInformation> GetContainerInformation(string containerTypeId);
    
    Task<OperationResult> UpdateMaterialState(Material material);
    Task<OperationResult> UpdateContainerState(Container container);
    
}