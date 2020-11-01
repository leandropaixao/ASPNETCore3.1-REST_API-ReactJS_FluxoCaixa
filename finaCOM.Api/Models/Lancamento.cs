using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finaCOM.Api.Models
{
    public class Lancamento
    {
        [Key]
        public long Id { get; set; }
        public string Descricao { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal? ValorPago { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }

        [ForeignKey("Conta")]
        public long IdConta { get; set; }
    }
}