using System;
using System.Collections.Generic;

namespace finaCOM.Api.Repositories
{
    public interface IRepository<T> where T:class 
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Create(T obj);
        void Update(T obj);
        void Delete(Guid id);
        
    }
}