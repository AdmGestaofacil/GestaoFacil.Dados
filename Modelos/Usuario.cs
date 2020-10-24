using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{

    [Table("Usuario")]
    public class Usuario
    {

        [Key]
        public int UsuarioId { get; set; }

        [Required]
        [StringLength(100)]
        public string Login { get; set; }

        [Required]
        [StringLength(100)]
        public string Senha { get; set; }
        public DateTime? DataCadastro { get; set; }

        [Required]
        [StringLength(100)]
        public string ConfirmaSenha { get; set; }
        public bool IsGrupo { get; set; } //'0=USUARIO NÃO  É GRUPO\r\1=USUARIO É UM GRUPO'  , por padrao deve gravar false.
        public bool Situacao { get; set; }  // true = ativo - false desativado
        public bool Visualisar { get; set; }  // true = mostra na tela , false nao mostra na tela nem traz do banco

        [Required]
        [ForeignKey("FuncionarioId")]
        public int FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }

        [Required]
        [ForeignKey("PerfilId")]
        public int PerfilId { get; set; }
        public virtual Perfil Perfil { get; set; }
    }
}
