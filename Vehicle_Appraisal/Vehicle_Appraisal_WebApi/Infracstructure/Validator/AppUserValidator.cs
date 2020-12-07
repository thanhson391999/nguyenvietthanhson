using FluentValidation;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.Validator
{
    public class AppUserValidator : AbstractValidator<AppUserVM>
    {
        public AppUserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is empty");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is empty").EmailAddress().WithMessage("Incorrect email format");
            RuleFor(x => x.FullName).NotEmpty().WithMessage("FullName is empty");

        }
    }
}
