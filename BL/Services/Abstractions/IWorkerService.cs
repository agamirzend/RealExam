using BL.DTOs.Worker;

namespace BL.Services.Abstractions;

public interface IWorkerService
{
    Task<IEnumerable<GetWorkerDTO>> GetAllAsync();
    Task<GetWorkerDTO> GetByIdAync(int id);
    Task CreateAsync(CreateWorkerDTO createWorkerDTO);
    Task UpdateAsync(CreateWorkerDTO createWorkerDTO,int id);
    Task DeleteAsync(int id);
}
