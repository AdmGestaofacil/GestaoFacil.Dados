using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoFacil.Dados.Modelos
{

    [Table("Perfil")]
    public class Perfil
    {
        [Key]
        public int PerfilId { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        public int TipoPerfil { get; set; }

        /*CRIAR SCRIPT PARA CADASTRAR
                * POR PADRAO TEMOS QUE TER 3 PEFIL 
                NOME 	 		TIPO_PEFIL	
                MASTER   		0
                ADMINISTRADOR  	1
                COLABORADOR   	2

            OBS: DEIXAR QUE A GENTE CADASTRO O PERFIL POR ENQUANTO...NOSSA RESPONSABILIDADE
         */
    }
}