using MediatR;

namespace App.EventManagement.Application.Features.Comand.UpdateRequest
{
    public class UpdateRequest : IRequest<UpdateResponse>
    {
        public Guid id { get; set; }
        public string? BuildingCode { get; set; }
  
    }
}