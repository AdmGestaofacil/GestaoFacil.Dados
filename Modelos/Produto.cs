using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        [StringLength(250)]
        public string Descricao { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecoVenda { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Custo { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal MargemRevenda { get; set; }



    }
}
