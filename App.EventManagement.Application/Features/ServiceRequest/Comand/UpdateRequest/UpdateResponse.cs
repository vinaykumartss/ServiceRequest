namespace App.EventManagement.Application.Features.Comand.UpdateRequest;

public sealed record UpdateResponse
{
    public Guid Id { get; set; }
    public bool IsSuccess { get; set; }
}



