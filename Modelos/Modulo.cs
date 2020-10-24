using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{

    [Table("Modulo")]
    public class Modulo
    {
        [Key]
        public int ModuloId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }

    }
}
