using FluentValidation;
using System.Text.RegularExpressions;

namespace SchoolManagementSystem.Validators
{
    public class ClassValidator : AbstractValidator<Data.Classroom>
    {
        public ClassValidator()
        {
            RuleFor(n => n.ClassName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} can't be empty")
                .Length(2, 15).WithMessage("{PropertyName} must be valid name")
                ;

            RuleFor(f => f.ClassFee)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("{PropertyName} must be in decimal form:")
                .Must(beAValidFee).WithMessage("{PropertyName} must be a valid fee")
                ;
        }


        protected bool beAValidFee(decimal fee)
        {
            Regex feepattern = new Regex(@"^-?(0|[1-9]\d{0,1})([,\.]\d{1,2})?$");
            return !feepattern.IsMatch(fee.ToString());
        }
    }
}
