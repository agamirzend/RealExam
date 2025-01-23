using AutoMapper;
using BL.DTOs.Worker;
using BL.Services.Abstractions;
using DAL.Models;
using DAL.Repositories;

namespace BL.Services.Concretes;

public class WorkerService : IWorkerService
{
    private readonly IRepository<Worker> _repo;
    private readonly IMapper _mapper;

    public WorkerService(IRepository<Worker> repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public async Task CreateAsync(CreateWorkerDTO createWorkerDTO)
    {
        Worker worker = _mapper.Map<Worker>(createWorkerDTO);
        await _repo.CreateAsync(worker);
    }

    public async Task DeleteAsync(int id)
    {
        Worker worker = await _repo.GetByIdAync(id);
        worker.Id = id;
        _repo.Delete(worker);
    }

    public async Task<IEnumerable<GetWorkerDTO>> GetAllAsync()
    {
        IEnumerable<Worker> workers = await _repo.GetAllAsync();
        IEnumerable<GetWorkerDTO> getWorkers = _mapper.Map<IEnumerable<GetWorkerDTO>>(workers);  
        return getWorkers;
    }

    public async Task<GetWorkerDTO> GetByIdAync(int id)
    {
        Worker worker = await _repo.GetByIdAync(id);
        GetWorkerDTO getWorker = _mapper.Map<GetWorkerDTO>(worker);
        return getWorker;
    }

    public async Task UpdateAsync(CreateWorkerDTO createWorkerDTO, int id)
    {
        if(id == 0)
        {
            throw new Exception("Something went wrong");
        }
        Worker worker = _mapper.Map<Worker>(createWorkerDTO);
        worker.Id = id;
        _repo.Update(worker);
        await _repo.SaveChangesAsync();
        
    }
}
