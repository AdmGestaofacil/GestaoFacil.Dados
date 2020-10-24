using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{
    [Table("ItemFaturamento")]
    public  class ItemFaturamento
    {
        [Key]
        public int ItemFaturamentoId { get; set; }
        public DateTime DataCriacao { get; set; }
        public int Quantidade { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Valor { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Total { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Bruto { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? BrutoTotal { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? LiquidoTotal { get; set; }

        [ForeignKey("ServicoId")]
        public int ServicoId { get; set; }
        public virtual Servico Servico { get; set; }

        [ForeignKey("FaturamentoId")]
        public int FaturamentoId { get; set; }
        public virtual Faturamento Faturamento { get; set; }
    }
}
