using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using finaCOM.Api.Data;
using finaCOM.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace finaCOM.Api.Repositories
{
    public class LancamentoRepository : IRepository<Lancamento>
    {
        private readonly Context _context;

        public LancamentoRepository(Context context)
        {
            _context = context;
        }
        public async Task Create(Lancamento obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var lancamento = await _context.Lancamentos.FirstOrDefaultAsync(l => l.Id == id);
            _context.Remove(lancamento);
            await _context.SaveChangesAsync();   
        }

        public async Task<List<Lancamento>> GetAll()
        {
            return await _context.Lancamentos.ToListAsync();
        }

        public async Task<Lancamento> GetById(long id)
        {
            var lancamento = await _context.Lancamentos.FindAsync(id);
            return lancamento;
        }

        public async Task Update(Lancamento obj)
        {
            _context.Update(obj);
            await _context.SaveChangesAsync();
        }
    }
}