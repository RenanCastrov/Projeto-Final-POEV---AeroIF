using FluentValidation;
using AeroIF.Domain.Entities;

namespace AeroIF.Service.Validators
{
    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator() 
        {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("City name is required.")
                .MaximumLength(100).WithMessage("City name must not exceed 100 characters.");
            RuleFor(c => c.State)
                .NotEmpty().WithMessage("State is required.")
                .MaximumLength(2).WithMessage("State must not exceed 2 characters.");
            RuleFor(c => c.Country)
                .NotEmpty().WithMessage("Country is required.")
                .MaximumLength(56).WithMessage("Country must not exceed 56 characters.");
        }
    }
}
