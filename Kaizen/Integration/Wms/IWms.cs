using Kaizen.Domain.Containers;
using Kaizen.Domain.Materials;
using Kaizen.Integration.Common;

namespace Kaizen.Integration.Wms;

public interface IWms : IHealthCheckable
{
    Task<List<string>> GetSetList();
    Task<WmsSetInformation> GetSetInformation(string setId);
    
    Task<WmsContainerTypeInformation> GetContainerInformation(string containerTypeId);
    
    Task<OperationResult> UpdateMaterialState(Material material);
    Task<OperationResult> UpdateContainerState(Container container);
    
}