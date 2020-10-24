using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(60)]
        public string Email { get; set; }

        [StringLength(11)]
        public string Cpf { get; set; }
        [StringLength(50)]
        public string Responsavel { get; set; }
        public string Informacoes { get; set; }
        public bool? Sexo { get; set; }
        public bool? AceitoNotificaoes { get; set; }
        public DateTime? DtNascimento { get; set; }
        public DateTime? DataCadastro { get; set; }
    }
}
