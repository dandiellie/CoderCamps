using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ASPNetMovieDB.Models
{
    public static class GenericRepositoryExtensions
    {
        /// <summary>
        /// This class promotes the Include() method from the entity framework so it
        /// can be used at a higher layer.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TProperty"></typeparam>
        /// <param name="queryable"></param>
        /// <param name="relatedEntity"></param>
        /// <returns></returns>
        public static IQueryable<T> Include<T, TProperty>(this IQueryable<T> queryable, Expression<Func<T, TProperty>> relatedEntity) where T : class
        {
            return System.Data.Entity.QueryableExtensions.Include<T, TProperty>(queryable, relatedEntity);
        }
    }
}