using System;
using System.Collections.Generic;
using System.Text;

namespace VisitMyCities.DataModel.DataAccessLayer
{
    public class Repository : IRepository
    {
        VisitMyCitiesContext _dbctx;
        public Repository(VisitMyCitiesContext dbctx)
        {
            _dbctx = dbctx;
        }
        public void Delete<T>(T resa) where T : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll<T>() where T : class
        {
            return _dbctx.Set<T>();
        }

        public T GetById<T>(int id) where T : class
        {
            return _dbctx.Find<T>(id);
        }

        public void Insert<T>(T entity) where T : class
        {
            _dbctx.Set<T>().Add(entity);
            _dbctx.SaveChanges();
        }

        public void Update<T>(T entity) where T : class
        {
            _dbctx.Set<T>().Update(entity);
            _dbctx.SaveChanges();
        }
    }
}
