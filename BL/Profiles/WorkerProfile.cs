using AutoMapper;
using BL.DTOs.Worker;
using DAL.Models;

namespace BL.Profiles;

public class WorkerProfile : Profile
{
    public WorkerProfile()
    {
        CreateMap<Worker, CreateWorkerDTO >().ReverseMap();
        CreateMap<Worker, GetWorkerDTO>().ReverseMap();
    }
}
