using GestaoFacil.Dados.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Repositories.Interfaces
{
    public interface IFornecedorRepository
    {
        void Add(Fornecedor fornecedor);
        IEnumerable<Fornecedor> GetAll();
        Fornecedor Find(int id);
        void Remove(int id);
        void Update(Fornecedor fornecedor);

    }

}
