using FluentValidation; 

namespace RealEstateAgency.Application.Clients.Commands.UpdateClient
{
    public class UpdateClientCommandValidator : AbstractValidator<UpdateClientCommand>
    {
        public UpdateClientCommandValidator()
        {
            RuleFor(updateClientCommand =>
                updateClientCommand.Id).NotEqual(Guid.Empty);
            RuleFor(updateClientCommand =>
                updateClientCommand.Name).MaximumLength(250);
            RuleFor(updateClientCommand =>
                updateClientCommand.Surname).MaximumLength(250);
            RuleFor(updateClientCommand =>
                updateClientCommand.Patronymic).MaximumLength(250);
            RuleFor(updateClientCommand =>
                updateClientCommand.Email).MaximumLength(250);
            RuleFor(updateClientCommand =>
                updateClientCommand.Phone).MaximumLength(20);
        }
    }
}
