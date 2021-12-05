using DataAccess.Abstract;
using DataAccess.Database;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Concrete
{
    public class AuthorityDal : IRepository<Authority>
    {
        SqlService sqlService;
        public AuthorityDal()
        {
            sqlService = SqlDatabase.GetInstance();
        }
        public string Add(Authority entity)
        {
            throw new NotImplementedException();
        }

        public string Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Authority Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Authority> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(Authority entity)
        {
            throw new NotImplementedException();
        }
    }
}
