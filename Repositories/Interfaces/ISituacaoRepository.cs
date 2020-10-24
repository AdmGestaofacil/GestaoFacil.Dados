using GestaoFacil.Dados.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Repositories.Interfaces
{
    public interface ISituacaoRepository
    {
        void Add(Situacao situacao);
        IEnumerable<Situacao> GetAll();
        Situacao Find(int id);
        void Remove(int id);
        void Update(Situacao situacao);
    }
}
