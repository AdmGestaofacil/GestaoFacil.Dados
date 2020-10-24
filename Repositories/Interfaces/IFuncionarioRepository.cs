using GestaoFacil.Dados.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Repositories.Interfaces
{
    public interface IFuncionarioRepository
    { 

        void Add(Funcionario funcionario);
        IEnumerable<Funcionario> GetAll();
        Funcionario Find(int id);
        void Remove(int id);
        void Update(Funcionario funcionario);
    }
}
