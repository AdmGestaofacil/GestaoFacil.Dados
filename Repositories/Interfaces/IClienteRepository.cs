using GestaoFacil.Dados.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Repositories.Interfaces
{
    public interface IClienteRepository
    {

        void Add(Cliente cliente);
        IEnumerable<Cliente> GetAll();
        Cliente Find(int id);
        void Remove(int id);
        void Update(Cliente cliente);
    }
}
