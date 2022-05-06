using FluentValidation;
using Navtor.Advisory.Models.Models.RouteOptimization;
using Navtor.Advisory.Models.Models.RouteOptimization.Voyage;

namespace Navtor.Advisory.Models.Validators
{
    public class VoyageSummaryValidator : AbstractValidator<VoyageSummary>
    {
        public VoyageSummaryValidator(IValidator<TotalConsumptionValue> totalConsumptionValueValidator)
        {
            RuleFor(m => m.FuelOilConsumptionInsideEca).SetValidator(totalConsumptionValueValidator)
                .When(m => m.FuelOilConsumptionInsideEca != null);

            RuleFor(m => m.FuelOilConsumptionOutsideEca).SetValidator(totalConsumptionValueValidator)
                .When(m => m.FuelOilConsumptionOutsideEca != null);
        }
    }
}
