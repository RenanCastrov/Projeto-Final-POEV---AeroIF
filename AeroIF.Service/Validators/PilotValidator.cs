using FluentValidation;
using AeroIF.Domain.Entities;

namespace AeroIF.Service.Validators
{
    public class PilotValidator : AbstractValidator<Pilot>
    {
        public PilotValidator() 
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Pilot's name is obrigatory")
                .MaximumLength(50).WithMessage("Pilot name must not exceed 50 characters");
            RuleFor(p => p.License)
                .NotEmpty().WithMessage("Pilot's license is obrigatory")
                .MaximumLength(50).WithMessage("Pilot license must not exceed 50 characters");
        }
    }
}
