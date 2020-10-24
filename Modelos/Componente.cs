using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{
   public class Componente
    {

        [Key]
        public int ComponenteId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        public string Descricao { get; set; }

        [Required]
        [ForeignKey("ModuloId")]
        public int ModuloId { get; set; }
        public virtual Modulo Modulo { get; set; }
    }
}
