using System;
using System.Collections.Generic;
using System.Text;

namespace VisitMyCities.DataModel.DataAccessLayer
{
    public interface IRepository
    {
        void Delete<T>(T resa) where T : class;
        IEnumerable<T> GetAll<T>() where T : class;
        T GetById<T>(int id) where T : class;
        void Insert<T>(T resa) where T : class;
        void Update<T>(T resa) where T : class;
    }
}
