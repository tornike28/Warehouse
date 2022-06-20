using Data.Product;
using Data.Product.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Warehouse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationController : ControllerBase
    {
        private readonly IProductService _service;
        public CalculationController(IProductService service)
        {
            _service = service;
        }


        [HttpGet("ProductPriceCalculation")]
        public async Task<ActionResult<int>> ProductPriceCalculation(ProductType type, int? date)
        {
            return await _service.Calculate(type);
        }
    }
}
