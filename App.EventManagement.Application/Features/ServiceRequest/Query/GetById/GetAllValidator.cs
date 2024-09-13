using App.EventManagement.Application.Common.AppMessage;
using FluentValidation;

namespace App.EventManagement.Application.Features.Query.GetById;

public sealed class GetByIdValidator : AbstractValidator<GetByIdRquest>
{
    public GetByIdValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage(AppValidationMessage.UserIdEmptyMessage);
    }
}