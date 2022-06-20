using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Data.Access;
using Repository.BaseRepositories;

namespace Repository.ProductRepositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context) { }

        public Product GetByBarCode(string BarCode)
        {
            return _Context.Set<Product>().SingleOrDefault(x => x.Barcode == BarCode);
        }

        public Product GetByBoxCode(string BoxCode)
        {
            return _Context.Set<Product>().SingleOrDefault(x => x.BoxCode == BoxCode);
        }

        public Product GetByEnglishName(string EnglishName)
        {
            return _Context.Set<Product>().SingleOrDefault(x => x.EnglishName == EnglishName);
        }

        public Product GetByInitialCode(string InitialCode)
        {
            return _Context.Set<Product>().SingleOrDefault(x => x.InitialCode == InitialCode);
        }

        public Product GetByName(string Name)
        {
            return _Context.Set<Product>().SingleOrDefault(x => x.Name == Name);
        }

        public Product GetByPrice(double Price)
        {
            return _Context.Set<Product>().SingleOrDefault(x => x.Price == Price);
        }

        public Product GetBySelfCost(double SelfCost)
        {
            return _Context.Set<Product>().SingleOrDefault(x => x.SelfCost == SelfCost);
        }
    }
}
