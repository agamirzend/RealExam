using AutoMapper;
using BL.DTOs.ServiceDTO;
using DAL.Models;

namespace BL.Profiles;

public class ServiceProfile : Profile
{
    public ServiceProfile()
    {
        CreateMap<Service, CreateServiceDTO>().ReverseMap();
        CreateMap<Service, GetServiceDTO>().ReverseMap();
    }
}
