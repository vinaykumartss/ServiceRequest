using App.EventManagement.Application.Repositories;
using App.EventManagement.Domain.Entities;
using AutoMapper;

namespace App.EventManagement.Application.Features.Comand.DeleteRequest;

public sealed class DeleteRequestMapper : Profile
{
    public DeleteRequestMapper()
    {
        CreateMap<DeleteRequest, IServiceRequestRepository>();
        CreateMap<IServiceRequestRepository, DeleteResponse>();
    }
}