using FluentValidation;
using Navtor.Advisory.Models.Models.RouteOptimization;

namespace Navtor.Advisory.Models.Validators
{
    public class TotalConsumptionValueValidator : AbstractValidator<TotalConsumptionValue>
    {
        public TotalConsumptionValueValidator()
        {
            RuleFor(m => m.Units).NotEmpty();
            RuleFor(m => m.Consumption).NotEmpty();
        }
    }
}
