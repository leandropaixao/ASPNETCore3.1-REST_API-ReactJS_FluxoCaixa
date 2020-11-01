using System;
using System.Threading.Tasks;
using finaCOM.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace finaCOM.Api.Controllers
{
    public interface IController<T> where T: class
    {
        Task<IActionResult> GetAll();
        Task<IActionResult> GetById(long id);
        Task<IActionResult> Create([FromBody]T obj);
        Task<IActionResult> Update(long id, [FromBody]T obj);  
        Task<IActionResult> Delete(long id);
    }
}