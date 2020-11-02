using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repository.GetAll());            
        }

        [HttpGet("v1/conta/{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var conta = await _repository.GetById(id);
            if (conta == null)
            {
                return NotFound();
            }

            return Ok(conta);
        }

        [HttpPost("v1/conta")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromBody]Conta obj)
        {
            if (!ModelState.IsValid)
            {
                return NotFound("Não foi possível salvar o registro");
            }
            await _repository.Create(obj);
            return Ok();
        }

        [HttpPut("v1/conta/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(long id, [FromBody]Conta obj)
        {
            var conta = _repository.GetById(id);
            if (conta == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return NotFound("Erroa o atualizar os dados.");
            }
            await _repository.Update(obj);

            return Ok();
        }  

        [HttpDelete("v1/conta/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var conta = await _repository.GetById(id);
            if (conta == null)
            {
                return NotFound();
            }
            await _repository.Delete(id);

            return Ok();
        }
    }
}