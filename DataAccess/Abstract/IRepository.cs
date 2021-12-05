﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    interface IRepository<T>
    {
        List<T> GetAll();
        T Get(Guid id);
        string Add(T entity);
        string Update(T entity, string oldName);
        string Delete(Guid id);

    }
}
