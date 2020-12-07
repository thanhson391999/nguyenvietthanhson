using FluentValidation;
using System;
using Vehicle_Appraisal_WebApi.ViewModels;

namespace Vehicle_Appraisal_WebApi.Infracstructure.Validator
{
    public class CustomerValidator : AbstractValidator<CustomerVM>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("FirstName is empty");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("LastName is empty");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone is empty")
                .Length(10).WithMessage("Phone must be 10 number")
                .Must((list, context) =>
                {
                    if (Int32.TryParse(list.Phone, out int number))
                    {
                        return true;
                    }
                    return false;
                }).WithMessage("Phone must be a number");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is empty").EmailAddress().WithMessage("Incorrect email format");
            RuleFor(x => x.Address1).NotEmpty().WithMessage("Address1 is empty");
            RuleFor(x => x.City).NotEmpty().WithMessage("City is empty");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Country is empty");
        }
    }
}
