using GestaoFacil.Dados.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Repositories.Interfaces
{
    public interface IEmpresaRepository
    {
        void Add(Empresa empresa);
        IEnumerable<Empresa> GetAll();
        Empresa Find(int id);
        void Remove(int id);
        void Update(Empresa empresa);
    }
}
