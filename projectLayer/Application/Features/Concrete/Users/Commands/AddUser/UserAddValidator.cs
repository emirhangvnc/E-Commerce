using eCommerceLayer.Application.Features.Concrete.Users.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Users.Commands.AddUser
{
    public class UserAddValidator : AbstractValidator<UserAddDTO>
    {
        public UserAddValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().MaximumLength(30);
            RuleFor(c => c.LastName).NotEmpty().MaximumLength(30);
            RuleFor(c => c.Email).NotEmpty().EmailAddress().MaximumLength(60);
            RuleFor(p => p.Password).NotEmpty().WithMessage("Your password cannot be empty")
                    .MinimumLength(6).WithMessage("Your password length must be at least 6.")
                    .MaximumLength(60).WithMessage("Your password must not be longer than 60")
                    .Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.")
                    .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.")
                    .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");
        }
    }
}