using MediatR;

namespace App.EventManagement.Application.Features.Comand.DeleteRequest
{
    public class DeleteRequest : IRequest<DeleteResponse>
    {
       
        public Guid Id { get; set; }
    }
}