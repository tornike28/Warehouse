using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Repository.BaseRepositories;

namespace Repository.AccountentTreeRepositories
{
    public interface IAccountentTreeRepository : IBaseRepository<AccountentTree>
    {
        AccountentTree GetByCode(string Code);
        AccountentTree GetByFullCode(string FullCode);
        AccountentTree GetByName(string Name);
    }
}
