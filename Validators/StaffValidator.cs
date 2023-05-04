using FluentValidation;
using System;
using System.Linq;

namespace SchoolManagementSystem.Validators
{
    public class StaffValidator : AbstractValidator<Data.Staff>
    {
        public StaffValidator()
        {
            RuleFor(p => p.FullName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} can not be empty")
                .Length(2, 50).WithMessage("Please provide a valid {PropertyName} :")
                .Must(BeAValidName).WithMessage("{PropertyName} conatain invalid characters")
                ;
            RuleFor(m => m.Cnic)
              .Cascade(CascadeMode.Stop)
              .NotEmpty().WithMessage("{PropertyName} can not be empty")
              .Length(13, 15).WithMessage("Please provide a valid {PropertyName} :")
              .Must(BeAValidCnicNumber).WithMessage("{PropertyName} contain invalid character")
              ;

            RuleFor(m => m.MobileNo)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} can not be empty")
                .Length(10, 15).WithMessage("Please provide a valid {PropertyName} :")
                .Must(BeAValidMobileNumber).WithMessage("{PropertyName} contain invalid character")
                ;

            RuleFor(des => des.StaffDesignation)
                 .Cascade(CascadeMode.Stop)
                 .NotEmpty().WithMessage("Pleases Select {PropertyName}:")
                 .Must(BeAValidName).WithMessage("{PropertyName} contain invalid character");

            RuleFor(d => d.JoiningDate)
                .Must(BeAValidDate).WithMessage("{PropertyName} Must Be A valid date")
                ;


        }

        protected bool BeAValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace(" ", "");
            return name.All(Char.IsLetter);
        }


        protected bool BeAValidMobileNumber(string mobileno)
        {
            mobileno = mobileno.Replace(" ", "");
            mobileno = mobileno.Replace("-", "");
            mobileno = mobileno.Replace("+", "");
            mobileno = mobileno.Replace("00", "");
            return mobileno.All(Char.IsNumber);
        }

        protected bool BeAValidCnicNumber(string cnicn)
        {
            cnicn = cnicn.Replace(" ", "");
            cnicn = cnicn.Replace("-", "");
            return cnicn.All(Char.IsNumber);
        }

        protected bool BeAValidDate(DateTime date)
        {
            DateTime currentDate = DateTime.Now.Date;
            int currentYear = currentDate.Year;
            DateTime DoJ = date.Date;
            int dojYear = DoJ.Year;

            if (DoJ <= currentDate && dojYear > (currentYear - 50))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
