using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthJWTExample.Application.Validators
{
    public static class ValidationMessages
    {
        public const string NOT_EMPTY_ERROR_MESSAGE = "{PropertyName} cannot be empty.";
        public const string MINIMUM_LENGTH_ERROR_MESSAGE = "{PropertyName} must be at least {MinLength} characters long.";
        public const string UPPERCASE_ERROR_MESSAGE = "{PropertyName} must contain at least one uppercase letter.";
        public const string LOWERCASE_ERROR_MESSAGE = "{PropertyName} must contain at least one lowercase letter.";
        public const string DIGIT_ERROR_MESSAGE = "{PropertyName} must contain at least one digit.";
        public const string SPECIAL_CHARACTER_ERROR_MESSAGE = "{PropertyName} must contain at least one special character.";

        public const string SERVICE_UNAVAILABLE = "Service unavailable.";
        public const string USERNAME_ALREADY_EXISTS = "The UserName already taken.";
    }
}
