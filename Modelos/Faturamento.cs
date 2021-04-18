using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{

    [Table("Faturamento")]
    public class Faturamento
    {
        [Key]
        public int FaturamentoId { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataMovimentacao { get; set; }

        public bool Status { get; set; }
        public bool Cancelado { get; set; }

        public int Origem { get; set; }//'0 - Padrao  (sistema back-end) 1 - Faturamento gerado via App.',

        [ForeignKey("TipoPgtoId")]
        public int TipoPgtoId { get; set; }
        public virtual TipoPagamento TipoPagamento { get; set; }

        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        [ForeignKey("ClienteID")]
        public int? ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }

        //edi
    }
}
