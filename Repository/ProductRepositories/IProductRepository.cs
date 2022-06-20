using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.BaseRepositories;
using Data.Entities;

namespace Repository.ProductRepositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Product GetByInitialCode(string InitialCode);
        Product GetByBarCode(string BarCode);
        Product GetByBoxCode(string BoxCode);
        Product GetByName(string Name);
        Product GetByEnglishName(string EnglishName);
        Product GetBySelfCost(double SelfCost);
        Product GetByPrice(double Price);
    }
}
