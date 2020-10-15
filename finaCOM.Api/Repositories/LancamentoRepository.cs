using System;
using System.Collections.Generic;
using finaCOM.Api.Models;

namespace finaCOM.Api.Repositories
{
    public class LancamentoRepository : IRepository<Lancamento>
    {
        public void Create(Lancamento obj)
        {
             // Implementar o acesso ao BD e criar nova conta
        }

        public void Delete(Guid id)
        {
            //implementar o delete
        }

        public IEnumerable<Lancamento> GetAll()
        {
            return new List<Lancamento> {
                    new Lancamento{
                        Descricao = "Conta de agua",
                        DataVencimento = new DateTime(2020, 10, 12),
                        ValorOriginal = 100.00M,
                        DataPagamento = new DateTime(2020, 10, 12),
                        ValorPago = 100.00M
                    },
                    new Lancamento{
                        Descricao = "Conta de agua",
                        DataVencimento = new DateTime(2020, 10, 12),
                        ValorOriginal = 100.00M,
                    }
                };
        }

        public Lancamento GetById(Guid id)
        {
            return 
                new Lancamento{
                    Descricao = "Conta de agua",
                    DataVencimento = new DateTime(2020, 10, 12),
                    ValorOriginal = 100.00M,
                    DataPagamento = new DateTime(2020, 10, 12),
                    ValorPago = 100.00M
                };
        }

        public void Update(Lancamento obj)
        {
            //implementar a atualização das informações
        }
    }
}