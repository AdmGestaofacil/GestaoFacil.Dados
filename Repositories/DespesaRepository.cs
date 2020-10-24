using GestaoFacil.Dados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoFacil.Dados.Repositories
{
    public class DespesaRepository : Interfaces.IDespesaRepository
    {
        private readonly Context _contexto;

        public DespesaRepository(Context contexto)
        {
            _contexto = contexto;
        }
        public void Add(Despesa despesa)
        {
            _contexto.Despesas.Add(despesa);
            _contexto.SaveChanges();
        }

        public Despesa Find(int id)
        {
            var obj = _contexto.Despesas.AsNoTracking().FirstOrDefault(d => d.FuncionarioId == id);
            return obj;
        }

        public IEnumerable<Despesa> GetAll()
        {
            return _contexto.Despesas.ToList();
        }

        public void Remove(int id)
        {
            var despesa = Find(id);
            _contexto.Despesas.Remove(despesa);
            _contexto.SaveChanges();
        }

        public void Update(Despesa despesa)
        {
            _contexto.Despesas.Update(despesa);
            _contexto.SaveChanges();
        }
    }
}
