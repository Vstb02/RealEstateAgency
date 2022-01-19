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
                    updateClientCommand.Name).NotEmpty().MaximumLength(250);
            RuleFor(updateClientCommand =>
                updateClientCommand.Surname).NotEmpty().MaximumLength(250);
            RuleFor(updateClientCommand =>
                updateClientCommand.Patronymic).NotEmpty().MaximumLength(250);
            RuleFor(updateClientCommand =>
                updateClientCommand.Email).NotEmpty().MaximumLength(250);
            RuleFor(updateClientCommand =>
                updateClientCommand.Phone).NotEmpty().MaximumLength(20);
        }
    }
}
