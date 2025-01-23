using BL.DTOs.ServiceDTO;
using BL.DTOs.Worker;

namespace BL.Services.Abstractions;

public interface IServiceService
{
    Task<IEnumerable<GetServiceDTO>> GetAllAsync();
    Task<GetServiceDTO> GetByIdAync(int id);
    Task CreateAsync(CreateServiceDTO createServiceDTO);
    Task UpdateAsync(CreateServiceDTO createServiceDTO, int id);
    Task DeleteAsync(int id);
}
