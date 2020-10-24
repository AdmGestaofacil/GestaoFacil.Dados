using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{
    public class Situacao
    {
        [Key]
        public int SituacaoId { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeSituacao { get; set; }
    }
}
