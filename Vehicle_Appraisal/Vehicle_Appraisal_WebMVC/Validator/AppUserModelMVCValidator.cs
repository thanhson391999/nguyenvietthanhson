using FluentValidation;
using Vehicle_Appraisal_WebMVC.Models;

namespace Vehicle_Appraisal_WebMVC.Validator
{
    public class AppUserModelMVCValidator : AbstractValidator<AppUserModelMVC>
    {
        public AppUserModelMVCValidator()
        {
            RuleFor(x => x.appUserVM.UserName).NotEmpty().WithMessage("UserName is empty");
            RuleFor(x => x.appUserVM.Email).NotEmpty().WithMessage("Email is empty").EmailAddress().WithMessage("Incorrect email format");
            RuleFor(x => x.appUserVM.FullName).NotEmpty().WithMessage("FullName is empty");
        }
    }
}
