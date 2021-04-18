using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{

    [Table("Vale")]
    public class Vale
    {
        [Key]
        public int ValeId { get; set; }

        [Required]
        [StringLength(500)]
        public string Descricao { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        [Required]
        public DateTime DataCadastro { get; set; }

        [Required]
        [ForeignKey("FuncionarioId")]
        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }

    }
}
