using FluentValidation;

namespace RealEstateAgency.Application.Agents.Command.UpdateAgent
{
    public class UpdateAgentCommandValidator : AbstractValidator<UpdateAgentCommand>
    {
        public UpdateAgentCommandValidator()
        {
            RuleFor(updateAgentCommand => updateAgentCommand.Id).NotEqual(Guid.Empty);
            RuleFor(updateAgentCommand => updateAgentCommand.Name).MaximumLength(250);
            RuleFor(updateAgentCommand => updateAgentCommand.Surname).MaximumLength(250);
            RuleFor(updateAgentCommand => updateAgentCommand.Patronymic).MaximumLength(250);
        }
    }
}
