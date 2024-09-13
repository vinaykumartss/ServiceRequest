using App.EventManagement.Domain.Entities;
using MediatR;
using System.Numerics;

namespace App.EventManagement.Application.Features.Query.GetById
{
    public class GetByIdRquest : IRequest<ServiceRequest>
    {
        public Guid Id { get; set; }
    }
}