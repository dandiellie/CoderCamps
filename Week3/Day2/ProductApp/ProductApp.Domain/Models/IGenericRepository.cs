using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Domain.Models
{
    interface IGenericRepository : IDisposable
    {
        void Add<T>(T entityToCreate) where T : class;
        void Delete<T>(params object[] keyValues) where T : class;
        T Find<T>(params object[] keyValues) where T : class;
        IQueryable Query(string entityTypeName);
        IQueryable<T> Query<T>() where T : class;
        void SaveChanges();
        IEnumerable<T> SqlQuery<T>(string sql, params object[] parameters);
    }
}
