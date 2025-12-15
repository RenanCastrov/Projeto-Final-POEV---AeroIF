using FluentValidation;
using AeroIF.Domain.Entities;

namespace AeroIF.Service.Validators
{
    public class FlightValidator : AbstractValidator<Flight>
    {
        public FlightValidator() 
        {
            RuleFor(f => f.Status)
                .NotEmpty().WithMessage("Status is required.")
                .MaximumLength(20).WithMessage("Status cannot exceed 20 characters.");
            RuleFor(f => f.DepartTime)
                .NotEmpty().WithMessage("Departure Time is required.");
        }
    }
}
