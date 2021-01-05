using GestaoFacil.Dados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoFacil.Dados.Repositories
{
    public class ValeRepository : Interfaces.IValeRepository
    {
        private readonly Context _contexto;

        public ValeRepository(Context contexto)
        {
            _contexto = contexto;
        }
        public void Add(Vale vale)
        {
            _contexto.Vales.Add(vale);
            _contexto.SaveChanges();
        }

        public Vale Find(int id)
        {
            var obj = _contexto.Vales.AsNoTracking().FirstOrDefault(v => v.ValeId == id);
            return obj;
        }

        public IEnumerable<Vale> GetAll()
        {
            return _contexto.Vales.ToList();
        }

        public int Remove(int id)
        {
            var vale = _contexto.Vales.FirstOrDefault(s => s.ValeId == id);
            if (vale == null)
                return 0;

            _contexto.Vales.Remove(vale);
            _contexto.SaveChanges();

            return 1;
        }
        public void Update(Vale vale)
        {
            _contexto.Vales.Update(vale);
            _contexto.SaveChanges();
        }
    }
}
