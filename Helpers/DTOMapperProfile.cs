using AutoMapper;
using GestaoFacil.Dados.Modelos;
using GestaoFacil.Dados.Modelos.DTO;
using System.Collections.Generic;

namespace GestaoFacil.Dados.Helpers
{
    public class DTOMapperProfile : Profile
    {
        public DTOMapperProfile()
        {

            /*
               AutoMapper = Objetivo de converte de um objeto pra outro.
               ou seja copia um objeto para outro objeto.
              Ex:
              palavra => palavraDTO
              palavraDTO  = recebe as propriedades de palavra mais usas proprias propriedades.
              Podemos mapear por priedade caso tenha nomes de propriedades diferentes.

           */

            #region  ModeloToDTO
            CreateMap<Funcionario, FuncionarioDTO>();
            CreateMap<Vale, ValeDTO>();
            //CreateMap<List<Vale>, List<ValeDTO>>();
            //CreateMap<PaginationList<Palavra>, PaginationList<PalavraDTO>>();
            #endregion


            #region  DtoTOModelo
            CreateMap<FuncionarioDTO,Funcionario>();
            #endregion




        }
    }
}
