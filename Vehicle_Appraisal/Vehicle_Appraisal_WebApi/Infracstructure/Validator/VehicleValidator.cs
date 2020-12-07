using FluentValidation;
using System;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebMVC
{
    public class VehicleValidator : AbstractValidator<VehicleVM>
    {
        public VehicleValidator()
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
        }
    }
}
