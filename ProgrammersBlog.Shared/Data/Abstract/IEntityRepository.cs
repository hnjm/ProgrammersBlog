using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        Task<T> GetAsync(Expression<Func<T,bool>>predicate,params Expression<Func<T,object>>[] includeProperties);//var kullanıcı=repository.GetAsync(k=>kId==15)
        Task<IList<T>> GetAllAsyn(Expression<Func<T, bool>> predicate=null, params Expression<Func<T, object>>[] includeProperties);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task Delete(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

    }
}
