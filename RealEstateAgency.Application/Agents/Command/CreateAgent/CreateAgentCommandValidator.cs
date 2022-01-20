using FluentValidation;

namespace RealEstateAgency.Application.Agents.Command.CreateAgent
{
    public class CreateAgentCommandValidator : AbstractValidator<CreateAgentCommand>
    {
        public CreateAgentCommandValidator()
        {
            RuleFor(createAgentCommand =>
                createAgentCommand.Name).NotEmpty().MaximumLength(250);
            RuleFor(createAgentCommand =>
                createAgentCommand.Surname).NotEmpty().MaximumLength(250);
            RuleFor(createAgentCommand =>
                createAgentCommand.Patronymic).NotEmpty().MaximumLength(250);
        }
    }
}
