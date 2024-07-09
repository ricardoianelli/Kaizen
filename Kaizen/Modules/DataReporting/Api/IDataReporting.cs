using Kaizen.CrossCutting;
using Kaizen.Modules.DataReporting.Domain.Dto;
using Kaizen.Modules.Workflows.Domain.Containers;
using Kaizen.Modules.Workflows.Domain.Materials;

namespace Kaizen.Modules.DataReporting.Api;

public interface IDataReporting : IHealthCheckable
{
    Task<List<string>> GetSetList();
    Task<SetInformationDto> GetSetInformation(string setId);
    
    Task<ContainerTypeInformationDto> GetContainerInformation(string containerTypeId);
    
    Task<OperationResult> UpdateMaterialState(Material material);
    Task<OperationResult> UpdateContainerState(Container container);
    
}