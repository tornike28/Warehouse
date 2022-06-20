using Data.Pricing;
using Data.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.PricingService
{
    public class PricingService : IPricingService
    {
        public PricingService()
        {

        }
        public async Task<int> ApplyPricing(ProductType productType, List<int> numbers)
        {
            return productType switch
            {
                ProductType.Safety => 7 * Cofficient(numbers),
                ProductType.Maintainability => 9 * Cofficient(numbers),
                ProductType.Efficiency => 11 * Cofficient(numbers),
                ProductType.Reusability => 15 * Cofficient(numbers),
                _ => 0,
            };
        }

        public int Cofficient(List<int> numbers)
        {
            return numbers.Sum() / numbers.LastOrDefault();
        }
    }
}
