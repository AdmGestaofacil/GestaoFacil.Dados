using GestaoFacil.Dados.Modelos;
using GestaoFacil.Dados.Modelos.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Repositories.Interfaces
{
    public interface IValeRepository
    {
        void Add(Vale vale);
        IEnumerable<Vale> GetAll();
        List<ValeDTO> GetVales();
        Vale GetValeDto();
        Vale Find(int id);
        int Remove(int id);
        void Update(Vale vale);

        
    }
}
