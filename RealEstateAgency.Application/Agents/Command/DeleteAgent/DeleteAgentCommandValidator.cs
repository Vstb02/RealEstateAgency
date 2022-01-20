using FluentValidation;

namespace RealEstateAgency.Application.Agents.Command.DeleteAgent
{
    public class DeleteAgentCommandValidator : AbstractValidator<DeleteAgentCommand>
    {
        public DeleteAgentCommandValidator()
        {
            RuleFor(deleteAgentCommand => deleteAgentCommand.Id).NotEqual(Guid.Empty);
        }
    }
}
