using System;
using System.ComponentModel.DataAnnotations;

namespace finaCOM.Api.Models{

    public class Conta
    {

        [Key]
        public long Id { get; set; }
        public string Nome { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoAtual { get; set; }

    }
}