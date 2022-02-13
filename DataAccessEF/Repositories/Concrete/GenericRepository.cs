using EntitiesEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public GenericRepository()
        {

        }

        public async Task Add(T entity)
        {
            
        }

        public async Task Delete(T entity)
        {
            
        }

        public async Task Delete(Guid id)
        {

        }
        
        public async Task<T> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task Update(T entity)
        {
        }
    }
}
