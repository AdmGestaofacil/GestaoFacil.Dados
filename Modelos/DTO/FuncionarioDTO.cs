using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos.DTO
{
    public class FuncionarioDTO :BaseDTO
    {
        [Key]
        public int FuncionarioId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(14)]
        public string cpf { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataNascimento { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salario { get; set; }

        [StringLength(11)]
        public string Celular { get; set; }

        [StringLength(11)]
        public string TelResidencial { get; set; }
        public DateTime? DtNascimento { get; set; }
        [StringLength(30)]
        public string Email { get; set; }
        public int Ativo { get; set; }

    }
}
