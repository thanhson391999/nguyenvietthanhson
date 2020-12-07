using FluentValidation;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.Validator
{
    public class ConditionValidator : AbstractValidator<ConditionVM>
    {
        public ConditionValidator()
        {
            RuleFor(x => x.Type).NotEmpty().WithMessage("Type is empty");
        }
    }
}
