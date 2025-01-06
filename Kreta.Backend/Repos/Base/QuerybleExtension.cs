using System.Linq.Expressions;

namespace Kreta.Backend.Repos.Base
{
    public static class QuerybleExtension
    {
        public static IQueryable<TEntity> FindByCondition<TEntity>(this IQueryable<TEntity> query, Expression<Func<TEntity, bool>> expression) => query.Where(expression);
    }
}
