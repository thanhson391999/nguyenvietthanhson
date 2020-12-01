using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.Validator
{
    public class PasswordValidator : AbstractValidator<PasswordVM>
    {
        public PasswordValidator()
        {
            RuleFor(x => x.NewPassword).NotEmpty().WithMessage("NewPassword is empty").MinimumLength(4).WithMessage("Password at least 4 characters");
            RuleFor(x => x.ConfirmNewPassword).NotEmpty().WithMessage("ConfirmNewPassword is empty");
            RuleFor(x => x).Custom((list, context) =>
            {
                if (list.NewPassword != list.ConfirmNewPassword)
                {
                    context.AddFailure("ConfirmNewPassword doesn't match");
                }
            });
        }
    }
}
