using System;
using System.Collections.Generic;
using finaCOM.Api.Data;
using finaCOM.Api.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace finaCOM.Api.Repositories
{
    public class ContaRepository : IRepository<Conta>
    {
        private readonly Context _context;

        public ContaRepository(Context context)
        {
            _context = context;
        }

        public async Task Create(Conta obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        
        public async Task Delete(long id)
        {
            var conta = await _context.Contas.FindAsync(id);
            _context.Remove(conta);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Conta>> GetAll()
        {
            return await _context.Contas.ToListAsync();
        }

        public async Task<Conta> GetById(long id)
        {
            var conta = await _context.Contas.FindAsync(id);
            return conta;
        }

        public async Task Update(Conta obj)
        {
            _context.Update(obj);
            await _context.SaveChangesAsync();
        }
    }
}