using AutoMapper;
using BL.DTOs.ServiceDTO;
using BL.DTOs.Worker;
using BL.Services.Abstractions;
using DAL.Models;
using DAL.Repositories;

namespace BL.Services.Concretes;

public class ServiceService : IServiceService
{
    private readonly IRepository<Service> _repo;
    private readonly IMapper _mapper;

    public ServiceService(IRepository<Service> repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    public async Task CreateAsync(CreateServiceDTO createServiceDTO)
    {
        Service service = _mapper.Map<Service>(createServiceDTO);
        await _repo.CreateAsync(service);
    }

    public async Task DeleteAsync(int id)
    {
        Service service = await _repo.GetByIdAync(id);
        service.Id = id;
        _repo.Delete(service);
    }

    public async Task<IEnumerable<GetServiceDTO>> GetAllAsync()
    {
        IEnumerable<Service> services = await _repo.GetAllAsync();
        IEnumerable<GetServiceDTO> getServices = _mapper.Map<IEnumerable<GetServiceDTO>>(services);
        return getServices;
    }

    public async Task<GetServiceDTO> GetByIdAync(int id)
    {
        Service service = await _repo.GetByIdAync(id);
        GetServiceDTO getService = _mapper.Map<GetServiceDTO>(service);
        return getService;
    }

    public async Task UpdateAsync(CreateServiceDTO createServiceDTO, int id)
    {
        if (id == 0)
        {
            throw new Exception("Something went wrong");
        }
        Service service = _mapper.Map<Service>(createServiceDTO);
        service.Id = id;
        _repo.Update(service);
        await _repo.SaveChangesAsync();

    }
}
