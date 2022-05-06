using FluentValidation;
using Navtor.Advisory.Models.Models;
using Navtor.Advisory.Models.Models.RouteOptimization;

namespace Navtor.Advisory.Models.Validators
{
    public class RouteDataValidator : AbstractValidator<RouteData>
    {
        public RouteDataValidator()
        {
            RuleFor(m => m.Format).NotEmpty().Must(m => m != null && m.Contains("rtz"));
            RuleFor(m => m.Data).NotEmpty();
        }
    }
}
