using FluentValidation;
using Navtor.Advisory.Models.Models;
using Navtor.Advisory.Models.Models.RouteOptimization;

namespace Navtor.Advisory.Models.Validators
{
    public class AdviceValidator : AbstractValidator<Advice>
    {
        public AdviceValidator(IValidator<RouteOptimizationAdvice> routeOptimizationValidator)
        {
            RuleFor(m => m as RouteOptimizationAdvice).SetValidator(routeOptimizationValidator)
                .When(m => m is RouteOptimizationAdvice);
        }
    }
}
