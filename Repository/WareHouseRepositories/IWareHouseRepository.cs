using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.BaseRepositories;
using Data.Entities;

namespace Repository.WareHouseRepositories
{
    public interface IWareHouseRepository : IBaseRepository<WareHouse>
    {
        WareHouse GetByNumber(int Number);
        WareHouse GetByReport(string Report);
        WareHouse GetByName(string Name);
        WareHouse GetByAddress(string Address);
    }
}
