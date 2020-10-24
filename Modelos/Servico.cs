using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{
    [Table("Servico")]
    public  class Servico
    {
        [Key]
        public int ServicoId { get; set; }

        [Required]
        [StringLength(250)]
        public string Descricao { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal preco { get; set; }

        public bool IsDescontinuado { get; set; }

        public int DuracaoEmMinutos { get; set; }

        public float? Comissao { get; set; }

        public DateTime? DataCadastro { get; set; }
        public DateTime? DtAtualizacao { get; set; }


    }
}
