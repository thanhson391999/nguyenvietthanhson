using FluentValidation;
using System;
using Vehicle_Appraisal_WebMVC.Models;

namespace Vehicle_Appraisal_WebMVC.Validator
{
    public class VehicleModelMVCValidator : AbstractValidator<VehicleModelMVC>
    {
        public VehicleModelMVCValidator()
        {
            RuleFor(x => x.customerVM.FirstName).NotEmpty().WithMessage("FirstName of customer is empty");
            RuleFor(x => x.customerVM.LastName).NotEmpty().WithMessage("LastName of customer is empty");
            RuleFor(x => x.makeVM.Name).NotEmpty().WithMessage("Name of make is empty");
            RuleFor(x => x.modelVM.Name).NotEmpty().WithMessage("Name of model is empty");
            RuleFor(x => x.vehicleVM.Engine).NotEmpty().WithMessage("Engine is empty");
            RuleFor(x => x.vehicleVM.Odometer).NotEmpty().WithMessage("Odometer is empty")
                .Must((list, context) =>
                {
                    if (Int32.TryParse(list.vehicleVM.Odometer, out int number))
                    {
                        return true;
                    }
                    return false;
                }).WithMessage("Odometer must be a number");
            RuleFor(x => x.vehicleVM.VIN).NotEmpty().WithMessage("VIN is empty");
            RuleFor(x => x.appUserVM.FullName).NotEmpty().WithMessage("FullName of users is empty");
        }
    }
}
