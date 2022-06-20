using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Access;
using Data.Base;
using Microsoft.EntityFrameworkCore;

namespace Repository.BaseRepositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly DataContext _Context;
        private DbSet<T> _Entities;
        public BaseRepository(DataContext Context)
        {
            _Context = Context;
            _Entities = _Context.Set<T>();
        }

        public void Delete(int toDelete)
        {
            _Entities.Remove(_Entities.SingleOrDefault(x => x.Id == toDelete));
            _Context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
             return _Entities;
        }

        public T GetById(int toGet)
        {
            if (toGet <= 0)
                throw new ArgumentOutOfRangeException();
            else
                return _Entities.SingleOrDefault(x => x.Id == toGet);
        }

        public void Insert(T toInsert)
        {
            if (toInsert == null)
                throw new ArgumentNullException();
            else
                _Entities.Add(toInsert);
            _Context.SaveChanges();
        }

        public void Update(T toUpdate, int IdToUpdate)
        {
            T tmp = _Entities.SingleOrDefault(x => x.Id == IdToUpdate);
            _Context.Entry(tmp).CurrentValues.SetValues(toUpdate);
            _Context.SaveChanges();
        }
    }
}
