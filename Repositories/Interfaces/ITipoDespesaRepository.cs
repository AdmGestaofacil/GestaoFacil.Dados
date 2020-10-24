using GestaoFacil.Dados.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Repositories.Interfaces
{
    public interface ITipoDespesaRepository
    {
        void Add(TipoDespesa tipoDespesa);
        IEnumerable<TipoDespesa> GetAll();
        TipoDespesa Find(int id);
        void Remove(int id);
        void Update(TipoDespesa tipoDespesa);


    }
}
