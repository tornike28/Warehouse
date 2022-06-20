using Data.Pricing;
using Data.Product;
using Data.Product.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.AccountentTrees
{
    public class ProductService : IProductService
    {
        private readonly IPricingService _priceService;

        public ProductService(IPricingService pricingService)
        {
            _priceService = pricingService;
        }


        public async Task<int> Calculate(ProductType type, int? number = null)
        {
            List<int> GroupA = new() { 1, 2, 3, 4, 5, 0 };
            List<int> GroupB = new() { 6, 7, 8, 9, 10, 0 };
            int price = 0;

            if (GroupA.Contains(number.Value))
            {
                price = await _priceService.ApplyPricing(type, GroupA);

            }

            if (GroupB.Contains(number.Value))
            {
                price = await _priceService.ApplyPricing(type, GroupB);
            }

            return price;
        }
    }

}
