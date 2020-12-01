using System;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.Validator
{
    public class LoginValidator : AbstractValidator<LoginVM>
    {
        public LoginValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is empty").MinimumLength(4).WithMessage("Password at least 4 characters");
        }
    }
}
