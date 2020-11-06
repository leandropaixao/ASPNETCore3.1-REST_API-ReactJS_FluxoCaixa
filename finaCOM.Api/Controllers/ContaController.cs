using System;
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
                return NotFound($"O registro {id} não foi encontrado.");
            }

            return Ok(conta);
        }

        [HttpPost("v1/conta")]
        public async Task<IActionResult> Create([FromBody]Conta obj)
        {
            await _repository.Create(obj);
            return Ok($"Registro criado com sucesso.");
        }

        [HttpPut("v1/conta/{id}")]
        public async Task<IActionResult> Update(long id, [FromBody]Conta obj)
        {   
            await _repository.Update(obj);
            return Ok($"Registro {id} alterado com sucesso.");
        }  

        [HttpDelete("v1/conta/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var conta = await _repository.GetById(id);
            if (conta == null)
            {
                return NotFound($"O registro {id} não foi encontrado.");
            }
            await _repository.Delete(id);

            return Ok($"Registro {id} excluído com sucesso.");
        }
    }
}