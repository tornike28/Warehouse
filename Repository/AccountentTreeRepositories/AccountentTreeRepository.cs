using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using Repository.BaseRepositories;
using Data.Access;

namespace Repository.AccountentTreeRepositories
{
    public class AccountentTreeRepository : BaseRepository<AccountentTree>, IAccountentTreeRepository
    {
        public AccountentTreeRepository(DataContext context) : base(context) { }

        public AccountentTree GetByCode(string Code)
        {
            return _Context.Set<AccountentTree>().SingleOrDefault(x => x.Code == Code);
        }

        public AccountentTree GetByFullCode(string FullCode)
        {
            return _Context.Set<AccountentTree>().SingleOrDefault(x => x.FullCode == FullCode);
        }

        public AccountentTree GetByName(string Name)
        {
            return _Context.Set<AccountentTree>().SingleOrDefault(x => x.Name == Name);
        }
    }
}
