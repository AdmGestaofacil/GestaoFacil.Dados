using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{
    [Table("Cartao")]
    public class Cartao
    {
        [Key]
        public int CartaoId { get; set; }

        [Required]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Taxa { get; set; }
        public bool permititParcelamentoNoCartao { get; set; }
    }
}
