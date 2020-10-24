using GestaoFacil.Dados.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        void Add(Produto produto);
        IEnumerable<Produto> GetAll();
        Produto Find(int id);
        void Remove(int id);
        void Update(Produto produto);
    }
}
