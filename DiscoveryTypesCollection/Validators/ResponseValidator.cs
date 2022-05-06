using System.Linq;
using FluentValidation;
using Navtor.Advisory.Models.Models;

namespace Navtor.Advisory.Models.Validators
{
    public class ResponseValidator : AbstractValidator<Response>
    {
        public ResponseValidator(IValidator<Advice> adviceValidator)
        {
            RuleFor(m => m.RequestId).NotEmpty();
            RuleFor(m => m.ResponseId).NotEmpty();
            RuleFor(m => m.CreatedDateTime).NotEmpty();
            RuleFor(m => m.Advices).NotEmpty();
            RuleForEach(m => m.Advices).SetValidator(adviceValidator);
        }
    }
}
