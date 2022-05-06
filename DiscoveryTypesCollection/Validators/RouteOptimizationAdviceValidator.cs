using FluentValidation;
using Navtor.Advisory.Models.Models;
using Navtor.Advisory.Models.Models.RouteOptimization;
using Navtor.Advisory.Models.Models.RouteOptimization.Voyage;

namespace Navtor.Advisory.Models.Validators
{
    public class RouteOptimizationAdviceValidator : AbstractValidator<RouteOptimizationAdvice>
    {
        public RouteOptimizationAdviceValidator(IValidator<RouteData> routeDataValidator, IValidator<VoyageSummary> voyageSummaryValidator)
        {
            RuleFor(m => m.VoyageSummary).NotEmpty().SetValidator(voyageSummaryValidator);
            RuleFor(m => m.Route).NotEmpty().SetValidator(routeDataValidator);
        }
    }
}
