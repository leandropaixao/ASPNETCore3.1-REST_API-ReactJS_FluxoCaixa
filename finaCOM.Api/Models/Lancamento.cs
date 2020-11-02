using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finaCOM.Api.Models
{
    public class Lancamento
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public decimal ValorOriginal { get; set; }
        public decimal? ValorPago { get; set; }
        [Required]
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }

        [Required]
        [ForeignKey("Conta")]
        public long IdConta { get; set; }
    }
}