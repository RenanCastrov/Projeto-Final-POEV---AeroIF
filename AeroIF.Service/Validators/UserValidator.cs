using FluentValidation;
using AeroIF.Domain.Entities;

namespace AeroIF.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(50).WithMessage("Name cannot exceed 50 characters.");
            RuleFor(u => u.Login)
                .NotEmpty().WithMessage("Login is required.")
                .MaximumLength(50).WithMessage("Login cannot exceed 50 characters.");
            RuleFor(u => u.IsActive)
                .NotNull().WithMessage("IsActive is required.");
            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MaximumLength(100).WithMessage("Password cannot exceed 100 characters.");
            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("Email is required.")
                .MaximumLength(100).WithMessage("Email cannot exceed 100 characters.")
                .EmailAddress().WithMessage("Email must be a valid email address.");
        }
    }
}
