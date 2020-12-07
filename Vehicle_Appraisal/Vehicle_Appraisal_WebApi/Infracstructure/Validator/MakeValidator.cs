using FluentValidation;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.Validator
{
    public class MakeValidator : AbstractValidator<MakeVM>
    {
        public MakeValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is empty");
        }
    }
}
