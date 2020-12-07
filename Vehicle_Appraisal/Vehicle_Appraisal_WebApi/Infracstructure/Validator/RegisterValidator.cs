using FluentValidation;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.ValidatorDTO
{
    public class RegisterValidator : AbstractValidator<RegisterVM>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is empty");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is empty").EmailAddress().WithMessage("Incorrect email format");
            RuleFor(x => x.FullName).NotEmpty().WithMessage("FullName is empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is empty").MinimumLength(4).WithMessage("Password at least 4 characters");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("ConfirmPassword is empty");
            RuleFor(x => x).Custom((list, context) =>
            {
                if (list.Password != list.ConfirmPassword)
                {
                    context.AddFailure("ConfirmPassword doesn't match");
                }
            });
        }
    }
}
