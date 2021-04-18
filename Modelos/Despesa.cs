using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{
    [Table("Despesa")]
    public class Despesa
    {
        //testeedi

        [Key]
        public int DespesaId { get; set; }

        [Required]
        [StringLength(500)]
        public string Descricao { get; set; }

        [StringLength(44)]
        public string Documento { get; set; }

        [StringLength(500)]
        public string Observacao { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required]
        [ForeignKey("TipoDespesaId")]
        public int TipoDespesaId { get; set; }
       //public virtual Tipo_Despesa Tipo_Despesa { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataVencimento { get; set; }
        public bool DespesaIsPaga { get; set; }

        [ForeignKey("FuncionarioId")]
        public int? FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }// caso se despesa de salario  , EXISTE UAM REGRA PRA MOSTRA ESSA OPÇÃO QUANDO A DESPESA É PARA COLABORADOR

        [ForeignKey("FornecedorId")]
        public int? FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        //situacaoDESPESA
        // verficar como esta é a situação da despesas
        // acredito que seja um enum de EM todos, Aberto ou Quitada.


    }
}
