using FluentValidation;

namespace App.EventManagement.Application.Features.Comand.DeleteRequest;

public sealed class DeleteRequestValidator : AbstractValidator<DeleteRequest>
{
    public DeleteRequestValidator()
    { 
    }
}