using GestaoFacil.Dados.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Repositories.Interfaces
{
     public  interface ITipoPagamentoRepository
    {
        void Add(TipoPagamento tipoPagamento);
        IEnumerable<TipoPagamento> GetAll();
        TipoPagamento Find(int id);
        void Remove(int id);
        void Update(TipoPagamento tipoPagamento);
    }
}
