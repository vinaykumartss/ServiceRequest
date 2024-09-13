using App.EventManagement.Application.Repositories;
using App.EventManagement.Domain.Entities;
using AutoMapper;

namespace App.EventManagement.Application.Features.Comand.CreateRequest;

public sealed class UpdateRequestMapper : Profile
{
    public UpdateRequestMapper()
    {
        CreateMap<CreateRequest, ServiceRequest>();
        CreateMap<ServiceRequest, CreateRequest>();
    }
}