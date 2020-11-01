using System;
using System.Threading.Tasks;
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

        [HttpPost("v1/lancamento")]
        public async Task<IActionResult> Create([FromBody] Lancamento obj)
        {
            await _repository.Create(obj);
            return Ok();
        }

        [HttpDelete("v1/lancamento/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var lancamento = await _repository.GetById(id);
            if (lancamento == null)
            {
                return NotFound();
            }
            await _repository.Delete(id);

            return Ok();
        }

        [HttpGet("v1/lancamento")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repository.GetAll());
        }

        [HttpGet("v1/lancamento/{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var lancamento = await _repository.GetById(id);

            if (lancamento == null)
            {
                return NotFound();
            }

            return Ok(lancamento);
        }

        [HttpPut("v1/lancamento/{id}")]
        public async Task<IActionResult> Update(long id, [FromBody] Lancamento obj)
        {
            var lancamento = await _repository.GetById(id);

            if (lancamento == null)
            {
                return NotFound();
            }

            await _repository.Update(obj);
            return Ok();
        }
    }
}