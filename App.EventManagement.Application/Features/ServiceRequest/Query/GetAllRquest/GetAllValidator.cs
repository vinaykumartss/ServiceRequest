using App.EventManagement.Application.Common.AppMessage;
using FluentValidation;

namespace App.EventManagement.Application.Features.Query.GetAllRquest;

public sealed class GetAllValidator : AbstractValidator<GetAllRquest>
{
    public GetAllValidator()
    {
        //RuleFor(x => x.PageNumber).NotEmpty().WithMessage(AppValidationMessage.UserIdEmptyMessage);
    }
}