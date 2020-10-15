using System;
using System.Collections.Generic;
using finaCOM.Api.Models;

namespace finaCOM.Api.Repositories
{
    public class ContaRepository : IRepository<Conta>
    {
        public void Create(Conta obj)
        {
            // Implementar o acesso ao BD e criar nova conta
        }

        public void Delete(Guid id)
        {
            //implementar o delete
        }

        public IEnumerable<Conta> GetAll()
        {
            return new List<Conta> {
                    new Conta{
                        Nome = "Caixa",
                        SaldoAtual = 0.00M,
                        SaldoInicial = 0.00M    
                    },
                    new Conta{
                        Nome = "Itau",
                        SaldoAtual = 100.00M,
                        SaldoInicial = 100.00M
                    }
                };
        }

        public Conta GetById(Guid id)
        {
            return 
                new Conta{
                    Nome = "Caixa",
                    SaldoAtual = 0.00M,
                    SaldoInicial = 0.00M    
                };
        }

        public void Update(Conta obj)
        {
            //implementar a atualização das informações
        }
    }
}