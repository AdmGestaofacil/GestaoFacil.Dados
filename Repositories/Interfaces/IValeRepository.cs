using GestaoFacil.Dados.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Repositories.Interfaces
{
    public interface IValeRepository
    {
        void Add(Vale vale);
        IEnumerable<Vale> GetAll();
        Vale Find(int id);
        int Remove(int id);
        void Update(Vale vale);
    }
}
