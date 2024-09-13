namespace App.EventManagement.Application.Features.Comand.DeleteRequest;

public sealed record DeleteResponse
{
    public Guid Id { get; set; }
    public bool IsSuccess { get; set; }
}
