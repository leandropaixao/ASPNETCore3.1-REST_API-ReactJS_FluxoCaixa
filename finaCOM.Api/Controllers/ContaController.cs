using System;
using System.Collections.Generic;
using finaCOM.Api.Models;
using finaCOM.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace finaCOM.Api.Controllers
{
    [ApiController]
    public class ContaController: Controller, IController<Conta>
    {
        private readonly IRepository<Conta> _repository;

        public ContaController(IRepository<Conta> repository)
        {
            _repository = repository;
        }

        [HttpGet("v1/conta")]
        public IActionResult GetAll()
        {
            return Ok(_repository.GetAll());            
        }

        [HttpGet("v1/conta/{id}")]
        public IActionResult GetById(Guid id)
        {
            var conta = _repository.GetById(id);
            if (conta == null)
            {
                return NotFound();
            }

            return Ok(conta);
        }

        [HttpPost("v1/conta")]
        public IActionResult Create([FromBody]Conta obj)
        {
            _repository.Create(obj);
            return Ok();
        }

        [HttpPut("v1/conta/{id}")]
        public IActionResult Update(Guid id, [FromBody]Conta obj)
        {
            var conta = _repository.GetById(id);
            if (conta == null)
            {
                return NotFound();
            }
            _repository.Update(obj);

            return Ok("Put OK");
        }  

        [HttpDelete("v1/conta/{id}")]
        public IActionResult Delete(Guid id)
        {
            var conta = _repository.GetById(id);
            if (conta == null)
            {
                return NotFound();
            }
            _repository.Delete(id);

            return Ok("Delte OK");
        }
    }
}