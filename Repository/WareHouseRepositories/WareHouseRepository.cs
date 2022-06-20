using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.BaseRepositories;
using Data.Entities;
using Data.Access;

namespace Repository.WareHouseRepositories
{
    public class WareHouseRepository : BaseRepository<WareHouse>, IWareHouseRepository
    {
        public WareHouseRepository(DataContext context) : base(context) { }

        public WareHouse GetByAddress(string Address)
        {
            return _Context.Set<WareHouse>().SingleOrDefault(x => x.Address == Address);
        }

        public WareHouse GetByName(string Name)
        {
            return _Context.Set<WareHouse>().SingleOrDefault(x => x.Name == Name);
        }

        public WareHouse GetByNumber(int Number)
        {
            return _Context.Set<WareHouse>().SingleOrDefault(x => x.Number == Number);
        }

        public WareHouse GetByReport(string Report)
        {
            return _Context.Set<WareHouse>().SingleOrDefault(x => x.Report == Report);
        }
    }
}
