using Kaizen.Common;
using Kaizen.Domain.Containers;
using Kaizen.Domain.Materials;
using Kaizen.Services.DataReporting.Dto;

namespace Kaizen.Services.DataReporting.Interfaces;

public interface IDataReporting : IHealthCheckable
{
    Task<List<string>> GetSetList();
    Task<SetInformationDto> GetSetInformation(string setId);
    
    Task<ContainerTypeInformationDto> GetContainerInformation(string containerTypeId);
    
    Task<OperationResult> UpdateMaterialState(Material material);
    Task<OperationResult> UpdateContainerState(Container container);
    
}