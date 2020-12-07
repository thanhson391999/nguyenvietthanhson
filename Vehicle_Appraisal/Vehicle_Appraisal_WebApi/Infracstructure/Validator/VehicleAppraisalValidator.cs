using FluentValidation;
using System;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.Validator
{
    public class VehicleAppraisalValidator : AbstractValidator<VehicleAppraisalVM>
    {
        public VehicleAppraisalValidator()
        {
            RuleFor(x => x.AppraisalValue).NotEmpty().WithMessage("AppraisalValue is empty")
                .Must((list, context) =>
                {
                    if (Int32.TryParse(list.AppraisalValue, out int number))
                    {
                        return true;
                    }
                    return false;
                }).WithMessage("AppraisalValue must be a number");
        }
    }
}
