using System;
using FluentValidation;
using Vehicle_Appraisal_WebApi.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
