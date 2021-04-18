using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{
    [Table("Funcionario")]
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(14)]
        public string cpf { get; set; }
        public DateTime? DataCadastro { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salario { get; set; }

        [StringLength(11)]
        public string Celular { get; set; }

        [StringLength(11)]
        public string TelResidencial { get; set; }

        public string Email { get; set; }
        public bool Ativo { get; set; }

        public ICollection<Vale> Vales { get; set; }

        /*Esta faltando os dados de endereço do funcionario avaliar se preciso no momento*/

    }
}
