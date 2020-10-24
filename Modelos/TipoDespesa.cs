using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{
    [Table("TipoDespesa")]
    public  class TipoDespesa
    {
        [Key]
        public int TipoDespesaId { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }

    }
}
