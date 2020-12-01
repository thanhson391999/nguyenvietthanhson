using System;
using System.Collections.Generic;
using FluentValidation;
using Vehicle_Appraisal_WebApi.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Appraisal_WebApi.Infracstructure.Validator
{
    public class ModelValidator : AbstractValidator<ModelVM>
    {
        public ModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is empty");
            RuleFor(x => x.Year).NotEmpty().WithMessage("Year is empty")
                .Length(4).WithMessage("Year must be 4 number")
                .Must((list, context) =>
                {
                    if (Int32.TryParse(list.Year, out int number))
                    {
                        return true;
                    }
                    return false;
                }).WithMessage("Year must be a number");
        }
    }
}
