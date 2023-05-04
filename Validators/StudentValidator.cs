using FluentValidation;
using System;
using System.Linq;

namespace SchoolManagementSystem.Validators
{
    class StudentValidator : AbstractValidator<Data.Student>
    {
        public StudentValidator()
        {
            RuleFor(pic => pic.StudentImage)
                .NotEmpty().WithMessage("{PropertyName} can not be empty .");

            RuleFor(roll => roll.StdRollNo)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} can not be empty")
                .GreaterThanOrEqualTo(1).WithMessage("{PropertyName} must be valid number")

                ;

            RuleFor(s => s.StudentName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} can not be empty.")
                .Length(2, 50).WithMessage("Please provide a valid {PropertyName} :")
                .Must(BeAValidName).WithMessage("{PropertyName} conatain invalid characters.")
                ;



            RuleFor(f => f.FatherName)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} can not be empty.")
               .Length(2, 50).WithMessage("Please provide a valid {PropertyName} :")
               .Must(BeAValidName).WithMessage("{PropertyName} conatain invalid characters.")
               ;

            RuleFor(m => m.FatherMobileNo)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} can not be empty.")
               .Length(10, 15).WithMessage("Please provide a valid {PropertyName} :")
               .Must(BeAValidMobileNumber).WithMessage("{PropertyName} contain invalid character.")
               ;
            RuleFor(g => g.gender)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} can not be empty")
                .Must(BeAValidName).WithMessage("{PropertyName} conatain invalid characters.")
                .Must(BeAValidGender).WithMessage("{PropertyName} must be valid.");


            RuleFor(d => d.StudentDateOfBirth)
             .Must(BeAValidDateOfBirth).WithMessage("{PropertyName} Must Be A valid date.")
             ;

            RuleFor(age => age.age)
               .NotEmpty().WithMessage("{PropertyName} can not be empty")
               .Must(BeValidAge).WithMessage("{PropertyName} must be valid age");


            RuleFor(w => w.DateOfBirthInWord)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} can not be empty.")
               .Length(10, 150).WithMessage("Please provide a valid {PropertyName} :")
               .Must(BeAValid).WithMessage("{PropertyName} contain invalid character.")
               ;

            RuleFor(r => r.StudentResidence)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} can not be empty.")
               .Length(2, 50).WithMessage("Please provide a valid {PropertyName} :")
               .Must(BeAValidName).WithMessage("{PropertyName} conatain invalid characters.")
               ;


            RuleFor(q => q.Qaum)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} can not be empty.")
               .Length(2, 50).WithMessage("Please provide a valid {PropertyName} :")
               .Must(BeAValidName).WithMessage("{PropertyName} conatain invalid characters.")
               ;

            RuleFor(d => d.AdmissionDate)
               .Must(BeAValidDate).WithMessage("{PropertyName} Must Be A valid date.")
               ;


        }

        protected bool BeAValidRollNo(string rollno)
        {
            return rollno.All(Char.IsNumber);
        }

        protected bool BeAValidGender(string gender)
        {
            if (gender == "Male")
            {
                return true;
            }
            else if (gender == "Female")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected bool BeAValidName(string name)
        {
            name = name.Replace(" ", "");
            name = name.Replace(" ", "");
            return name.All(Char.IsLetter);
        }

        protected bool BeAValid(string name)
        {
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
            DateTime admissiondate = date.Date;
            int admissionYear = admissiondate.Year;

            if (admissiondate <= currentDate && admissionYear > (currentYear - 15))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected bool BeAValidNumber(string age)
        {
            age = age.Replace(" ", "");
            return age.All(Char.IsNumber);

        }
        protected bool BeValidAge(int age)
        {
            if (age >= 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected bool BeAValidDateOfBirth(DateTime date)
        {
            DateTime currentDate = DateTime.Now.Date;
            int currentYear = currentDate.Year;
            DateTime DateOfBirth = date.Date;
            int BirthYear = DateOfBirth.Year;

            if (DateOfBirth < currentDate && BirthYear > (currentYear - 25) && BirthYear < (currentYear - 3))
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
