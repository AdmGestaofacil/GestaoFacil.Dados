using GestaoFacil.Dados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoFacil.Dados.Repositories
{
    public class TipoDespesaRepository : Interfaces.ITipoDespesaRepository
    {

        private readonly Context _contexto;
        public TipoDespesaRepository(Context contexto)
        {
            _contexto = contexto;
        }

        public void Add(TipoDespesa tipoDespesa)
        {
            _contexto.TipoDespesas.Add(tipoDespesa);
            _contexto.SaveChanges();
        }
        public TipoDespesa Find(int id)
        {
            var obj = _contexto.TipoDespesas.AsNoTracking().FirstOrDefault(td => td.TipoDespesaId == id);
            return obj;
        }

        public IEnumerable<TipoDespesa> GetAll()
        {
            return _contexto.TipoDespesas.ToList();
        }

        public void Remove(int id)
        {
            var tipodespesa = Find(id);
            _contexto.TipoDespesas.Remove(tipodespesa);
            _contexto.SaveChanges();
        }

        public void Update(TipoDespesa tipoDespesa)
        {
            _contexto.TipoDespesas.Update(tipoDespesa);
            _contexto.SaveChanges();
        }
    }
}
