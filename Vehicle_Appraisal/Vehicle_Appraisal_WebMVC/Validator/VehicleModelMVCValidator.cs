using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Vehicle_Appraisal_WebMVC.Models;

namespace Vehicle_Appraisal_WebMVC.Validator
{
    public class VehicleModelMVCValidator : AbstractValidator<VehicleModelMVC>
    {
        public VehicleModelMVCValidator()
        {
            RuleFor(x => x.Engine).NotEmpty().WithMessage("Engine is empty");
            RuleFor(x => x.Odometer).NotEmpty().WithMessage("Odometer is empty")
                .Must((list, context) =>
                {
                    if (Int32.TryParse(list.Odometer, out int number))
                    {
                        return true;
                    }
                    return false;
                }).WithMessage("Odometer must be a number");
            RuleFor(x => x.VIN).NotEmpty().WithMessage("VIN is empty");
            RuleFor(x => x.CustomerVM.FirstName).NotEmpty().WithMessage("Customer is empty");
            RuleFor(x => x.CustomerVM.LastName).NotEmpty().WithMessage("Customer is empty");
            RuleFor(x => x.MakeVM.Name).NotEmpty().WithMessage("Make is empty");
            RuleFor(x => x.ModelVM.Name).NotEmpty().WithMessage("Model is empty");
            RuleFor(x => x.AppUserVM.FullName).NotEmpty().WithMessage("User is empty");
        }
    }
}
