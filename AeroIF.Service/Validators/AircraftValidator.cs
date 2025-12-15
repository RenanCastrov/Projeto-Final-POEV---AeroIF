using FluentValidation;
using AeroIF.Domain.Entities;

namespace AeroIF.Service.Validators
{
    public class AircraftValidator : AbstractValidator<Aircraft>
    {
        public AircraftValidator() 
        {
            RuleFor(a => a.Model)
                .NotEmpty().WithMessage("Aircraft's model is obrigatory!");
            RuleFor(a => a.Company)
                .NotEmpty().WithMessage("Aircraft's company is obrigatory!");
            RuleFor(a => a.Capacity)
                .GreaterThan(0).WithMessage("Aircraft's capacity must be greater than zero!")
                .LessThanOrEqualTo(850).WithMessage("Aircraft's capacity must be less than or equal to 850!");
        }
    }
}
