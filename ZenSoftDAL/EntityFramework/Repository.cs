using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using ZenSoftModel.Entities;

namespace ZenSoftDAL.EntityFramework
{
    public class Repository<T> : RepositoryBase where T : class, IEntity
    {
        public DbSet<T> _objectSet;

        public Repository()
        {
            _objectSet = context.Set<T>();
        }

        public List<T> List()
        {
            return _objectSet.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return _objectSet.Where(where).ToList();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _objectSet.FirstOrDefault(where);
        }

        public int Insert(T obj)
        {
            _objectSet.Add(obj);
            return Save();
        }

        public int InsertRange(ICollection<T> obj)
        {
            _objectSet.AddRange(obj);
            return Save();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            Save();
        }

        public int Delete(T obj)
        {
            obj.AktifMi = false;
            return Save();
        }

        public int Save()
        {
            return context.SaveChanges();
        }

        public int HardDelete(T obj)
        {
            _objectSet.Remove(obj);
            return Save();
        }

        public int HardDeleteList(ICollection<T> obj)
        {
            _objectSet.RemoveRange(obj);
            return Save();
        }
    }
}
