using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Product.Repository
{
    public interface IProductService
    {
        Task<int> Calculate(ProductType type, int? date = null);
    }
}
