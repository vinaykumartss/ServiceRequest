using App.EventManagement.Application.Features.Query.GetAllRquest;
using App.EventManagement.Application.Repositories;
using AutoMapper;

namespace App.EventManagement.Application.Features.Query.GetById;

public sealed class GetByIdMapper : Profile
{
    public GetByIdMapper()
    {
        CreateMap<GetAllResponse, IServiceRequestRepository>();
        CreateMap<IServiceRequestRepository, GetAllResponse>();
    }
}