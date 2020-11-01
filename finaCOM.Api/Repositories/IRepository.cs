using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace finaCOM.Api.Repositories
{
    public interface IRepository<T> where T:class 
    {
        Task<List<T>> GetAll();
        Task<T> GetById(long id);
        Task Create(T obj);
        Task Update(T obj);
        Task Delete(long id);    
    }
}