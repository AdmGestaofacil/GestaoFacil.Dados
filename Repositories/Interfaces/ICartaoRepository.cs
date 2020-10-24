using GestaoFacil.Dados.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Repositories.Interfaces
{
    public interface ICartaoRepository
    {
        void Add(Cartao cartao);
        IEnumerable<Cartao> GetAll();
        Cartao Find(int id);
        void Remove(int id);
        void Update(Cartao cartao);

    }
}
