using GestaoFacil.Dados.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Repositories.Interfaces
{
   public interface IDespesaRepository
    {
        void Add(Despesa despesa);
        IEnumerable<Despesa> GetAll();
        Despesa Find(int id);
        void Remove(int id);
        void Update(Despesa despesa);
    }
}
