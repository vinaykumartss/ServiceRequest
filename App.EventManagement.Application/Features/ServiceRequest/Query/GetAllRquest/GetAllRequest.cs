using App.EventManagement.Domain.Entities;
using MediatR;
using System.Numerics;

namespace App.EventManagement.Application.Features.Query.GetAllRquest
{
    public class GetAllRquest : IRequest<List<ServiceRequest>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}