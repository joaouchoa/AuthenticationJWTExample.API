using AuthJWTExample.Application.DTOs.Request;
using AuthJWTExample.Domain.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWTExample.Application.Validators.Users
{
    public class AddUserValidator : AbstractValidator<AddUserRequest>
    {
        public AddUserValidator()
        {
            RuleFor(d => d.UserName)
                .NotEmpty().WithMessage(ValidationMessages.NOT_EMPTY_ERROR_MESSAGE);

            RuleFor(d => d.Password)
                .NotEmpty().WithMessage(ValidationMessages.NOT_EMPTY_ERROR_MESSAGE)
                .MinimumLength(User.MIN_LENGHT).WithMessage(ValidationMessages.MINIMUM_LENGTH_ERROR_MESSAGE.Replace("{MinLength}", User.MIN_LENGHT.ToString()))
                .Matches(@"[A-Z]").WithMessage(ValidationMessages.UPPERCASE_ERROR_MESSAGE)
                .Matches(@"[a-z]").WithMessage(ValidationMessages.LOWERCASE_ERROR_MESSAGE)
                .Matches(@"[0-9]").WithMessage(ValidationMessages.DIGIT_ERROR_MESSAGE)
                .Matches(@"[\W_]").WithMessage(ValidationMessages.SPECIAL_CHARACTER_ERROR_MESSAGE);

            RuleFor(d => d.Role)
                .NotEmpty().WithMessage(ValidationMessages.NOT_EMPTY_ERROR_MESSAGE);
        }
    }
}
