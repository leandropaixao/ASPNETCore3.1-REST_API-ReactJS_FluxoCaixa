using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finaCOM.Api.Models
{
    public class Lancamento
    {
        [Key]
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal? ValorPago { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }

        [ForeignKey("Conta")]
        public Guid IdConta { get; set; }
    }
}