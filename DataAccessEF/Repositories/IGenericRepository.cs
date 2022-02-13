using EntitiesEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.Repositories
{
    public interface IGenericRepository<T> where T : IBaseEntity
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task Delete(Guid id);
        Task<T> Get(Guid id);
        Task<List<T>> GetAll();
    }
}
