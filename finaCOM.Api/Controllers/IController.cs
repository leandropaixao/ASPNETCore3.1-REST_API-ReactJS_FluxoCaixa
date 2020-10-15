using System;
using finaCOM.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace finaCOM.Api.Controllers
{
    public interface IController<T> where T: class
    {
        public IActionResult GetAll();
        public IActionResult GetById(Guid id);
        public IActionResult Create([FromBody]T obj);
        public IActionResult Update(Guid id, [FromBody]T obj);  
        public IActionResult Delete(Guid id);
    }
}