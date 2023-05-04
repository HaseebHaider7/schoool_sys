using FluentValidation;
using System.Text.RegularExpressions;

namespace SchoolManagementSystem.Validators
{
    public class FeeValidator : AbstractValidator<Data.FeeStructure>
    {

        public FeeValidator()
        {
            RuleFor(f => f.paid)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("{PropertyName} can't be empty")
               .Must(beAValidFee).WithMessage("{PropertyName} must be decimal number:")
               ;

        }

        protected bool beAValidFee(decimal fee)
        {
            Regex feepattern = new Regex(@"^-?(0|[1-9]\d{0,0})([,\.]\d{1,2})?$");
            return !feepattern.IsMatch(fee.ToString());
        }
    }
}
