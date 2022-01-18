using FluentValidation;

namespace RealEstateAgency.Application.Clients.Commands.CreateClient
{
    public class CreateClientCommandValidator : AbstractValidator<CreateClientCommand>
    {
        public CreateClientCommandValidator()
        {
            RuleFor(createClientCommand =>
                createClientCommand.Name).NotEmpty().MaximumLength(250);
            RuleFor(createClientCommand =>
                createClientCommand.Surname).NotEmpty().MaximumLength(250);
            RuleFor(createClientCommand =>
                createClientCommand.Patronymic).NotEmpty().MaximumLength(250);
            RuleFor(createClientCommand =>
                createClientCommand.Email).NotEmpty().MaximumLength(250);
            RuleFor(createClientCommand =>
                createClientCommand.Phone).NotEmpty().MaximumLength(20);
        }
    }
}
