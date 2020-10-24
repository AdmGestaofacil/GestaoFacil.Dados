using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{
    [Table("Empresa")]
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }

        [StringLength(100)]
        public string RazaoSocial { get; set; }
        [StringLength(100)]
        public string NomeFantasia { get; set; }

        [StringLength(18)]
        public string CpfCnpj { get; set; }

    }
}
