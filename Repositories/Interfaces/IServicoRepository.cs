using GestaoFacil.Dados.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Repositories.Interfaces
{
    public interface IServicoRepository
    {

        void Add(Servico servico);
        IEnumerable<Servico> GetAll();
        Servico Find(int id);
        int Remove(int id);
        void Update(Servico servico);
    }
}
