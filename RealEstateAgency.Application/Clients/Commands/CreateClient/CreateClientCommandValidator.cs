using FluentValidation;

namespace RealEstateAgency.Application.Clients.Commands.CreateClient
{
    public class CreateClientCommandValidator : AbstractValidator<CreateClientCommand>
    {
        public CreateClientCommandValidator()
        {
            RuleFor(createClientCommand =>
                createClientCommand.Name).MaximumLength(250);
            RuleFor(createClientCommand =>
                createClientCommand.Surname).MaximumLength(250);
            RuleFor(createClientCommand =>
                createClientCommand.Patronymic).MaximumLength(250);
            RuleFor(createClientCommand =>
                createClientCommand.Email).MaximumLength(250);
            RuleFor(createClientCommand =>
                createClientCommand.Phone).MaximumLength(20);
        }
    }
}
