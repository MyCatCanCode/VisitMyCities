using System;
using System.Collections.Generic;
using System.Text;

namespace VisitMyCities.DataModel.DataAccessLayer
{
    public class Repository : IRepository
    {
        public void Delete<T>(T resa) where T : class
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(int id) where T : class
        {
            throw new NotImplementedException();
        }

        public void Insert<T>(T resa) where T : class
        {
            throw new NotImplementedException();
        }

        public void InsertAsync<T>(T resa) where T : class
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T resa) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
