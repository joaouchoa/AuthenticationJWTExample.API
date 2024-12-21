using AuthJWTExample.Application.DTOs.Request;
using AuthJWTExample.Domain.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWTExample.Application.Validators.Auth
{
    public class GenerateTokenValidator : AbstractValidator<LoginRequest>
    {
        public GenerateTokenValidator()
        {
            RuleFor(d => d.UserName)
                .NotEmpty().WithMessage(ValidationMessages.NOT_EMPTY_ERROR_MESSAGE);

            RuleFor(d => d.Password)
                .NotEmpty().WithMessage(ValidationMessages.NOT_EMPTY_ERROR_MESSAGE);
        }
    }
}
