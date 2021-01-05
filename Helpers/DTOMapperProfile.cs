using AutoMapper;
using GestaoFacil.Dados.Modelos;
using GestaoFacil.Dados.Modelos.DTO;

namespace GestaoFacil.Dados.Helpers
{
    public class DTOMapperProfile : Profile
    {
        public DTOMapperProfile()
        {

            /*
             d
               AutoMapper = Objetivo de converte de um objeto pra outro.
             */
            //Convertendo  "palavra" para o objeto "palavraDTO"
            CreateMap<Funcionario, FuncionarioDTO>();
        }
    }
}
