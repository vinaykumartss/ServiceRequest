using App.EventManagement.Application.Features.Query.GetAllRquest;
using App.EventManagement.Application.Repositories;
using App.EventManagement.Domain.Entities;
using AutoMapper;

namespace App.EventManagement.Application.Features.Query.GetUser;

public sealed class GetAllMapper : Profile
{
    public GetAllMapper()
    {
        CreateMap<GetAllResponse, ServiceRequest>();
        CreateMap<IServiceRequestRepository, GetAllResponse>();
    }
}