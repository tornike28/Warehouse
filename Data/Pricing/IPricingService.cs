using Data.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Pricing
{
    public interface IPricingService
    {
        Task<int> ApplyPricing(ProductType productType, List<int> numbers);
    }
}
