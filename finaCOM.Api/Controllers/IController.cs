using System;
using finaCOM.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace finaCOM.Api.Controllers
{
    public interface IController<T> where T: class
    {
        IActionResult GetAll();
        IActionResult GetById(Guid id);
        IActionResult Create([FromBody]T obj);
        IActionResult Update(Guid id, [FromBody]T obj);  
        IActionResult Delete(Guid id);
    }
}