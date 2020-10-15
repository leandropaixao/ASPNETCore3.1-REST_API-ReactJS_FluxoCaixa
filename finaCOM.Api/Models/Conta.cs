using System;
using System.ComponentModel.DataAnnotations;

namespace finaCOM.Api.Models{

    public class Conta
    {
        [Key]
        public Guid Id { get; }
        public Conta()
        {
            Id = Guid.NewGuid();
        }
        public string Nome { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoAtual { get; set; }
    }
}