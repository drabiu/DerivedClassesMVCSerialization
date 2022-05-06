using System.Linq;
using FluentValidation;
using Navtor.Advisory.Models.Models;

namespace Navtor.Advisory.Models.Validators
{
    public class RequestValidator : AbstractValidator<Request>
    {
        public RequestValidator()
        {
            RuleFor(m => m.Data).NotEmpty();
        }
    }
}
