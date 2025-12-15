using FluentValidation;
using AeroIF.Domain.Entities;

namespace AeroIF.Service.Validators
{
    public class AirportValidator : AbstractValidator<Airport>
    {
        public AirportValidator() 
        {
            RuleFor(a => a.Name)
                .NotEmpty().WithMessage("Airport name is required.")
                .MaximumLength(100).WithMessage("Airport name must not exceed 100 characters.");
            RuleFor(a => a.Code)
                .NotEmpty().WithMessage("Airport code is required.")
                .MaximumLength(10).WithMessage("Airport code must not exceed 10 characters.");
        }
    }
}
