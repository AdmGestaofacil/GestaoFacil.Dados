using GestaoFacil.Dados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoFacil.Dados.Repositories
{
    public class TipoPagamentoRepository : Interfaces.ITipoPagamentoRepository
    {
        private readonly Context _contexto;

        public TipoPagamentoRepository(Context contexto)
        {
            _contexto = contexto;
        }
        public void Add(TipoPagamento tipoPagamento)
        {
            _contexto.TipoPagamentos.Add(tipoPagamento);
            _contexto.SaveChanges();
        }

        public TipoPagamento Find(int id)
        {
            var obj = _contexto.TipoPagamentos.AsNoTracking().FirstOrDefault(tp => tp.TipoPagamentoId == id);
            return obj;
        }

        public IEnumerable<TipoPagamento> GetAll()
        {
            return _contexto.TipoPagamentos.ToList();
        }

        public void Remove(int id)
        {
            var tipoptgo = Find(id);
            _contexto.TipoPagamentos.Remove(tipoptgo);
            _contexto.SaveChanges();
        }

        public void Update(TipoPagamento tipoPagamento)
        {
            _contexto.TipoPagamentos.Update(tipoPagamento);
            _contexto.SaveChanges();
        }
    }
}
