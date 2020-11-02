using System;
using System.ComponentModel.DataAnnotations;

namespace finaCOM.Api.Models{

    public class Conta
    {

        [Key]
        public long Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public decimal SaldoInicial { get; set; }
        [Required]
        public decimal SaldoAtual { get; set; }

    }
}