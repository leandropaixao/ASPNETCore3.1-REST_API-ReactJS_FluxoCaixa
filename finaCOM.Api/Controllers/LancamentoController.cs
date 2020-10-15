using System;
using finaCOM.Api.Models;
using finaCOM.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace finaCOM.Api.Controllers
{
    public class LancamentoController : Controller, IController<Lancamento>
    {
        private readonly IRepository<Lancamento> _repository;

        public LancamentoController(IRepository<Lancamento> repository)
        {
            _repository = repository;
        }

        public IActionResult Create([FromBody] Lancamento obj)
        {
            throw new NotImplementedException();
        }

        public IActionResult Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("v1/lancamento")]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("v1/lancamento/{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_repository.GetById(id));
        }

        public IActionResult Update(Guid id, [FromBody] Lancamento obj)
        {
            throw new NotImplementedException();
        }
    }
}