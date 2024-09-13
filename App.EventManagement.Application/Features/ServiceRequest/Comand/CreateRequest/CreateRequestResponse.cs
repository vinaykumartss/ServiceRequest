namespace App.EventManagement.Application.Features.Comand.CreateRequest;

public sealed record CreateResponse
{
    public Guid Id { get; set; }
    public bool IsSuccess { get; set; }

    
}



