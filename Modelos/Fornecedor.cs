using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Key]
        public int FornecedorId { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
