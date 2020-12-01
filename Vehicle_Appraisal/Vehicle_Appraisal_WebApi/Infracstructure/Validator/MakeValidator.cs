using System;
using FluentValidation;
using Vehicle_Appraisal_WebApi.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
