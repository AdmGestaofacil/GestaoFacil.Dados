using GestaoFacil.Dados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoFacil.Dados.Repositories
{
    public class SituacaoRepository : Interfaces.ISituacaoRepository
    {

        private readonly Context _contexto;
        public SituacaoRepository(Context contexto)
        {
            _contexto = contexto;
        }

        public void Add(Situacao situacao)
        {
            _contexto.Situacao.Add(situacao);
            _contexto.SaveChanges();
        }

        public Situacao Find(int id)
        {
            var obj = _contexto.Situacao.AsNoTracking().FirstOrDefault(s => s.SituacaoId == id);
            return obj;
        }

        public IEnumerable<Situacao> GetAll()
        {
            return _contexto.Situacao.ToList();
        }
   
        public void Remove(int id)
        {
            var situacao = Find(id);
            _contexto.Situacao.Remove(situacao);
            _contexto.SaveChanges();
        }

        public void Update(Situacao situacao)
        {
            _contexto.Situacao.Update(situacao);
            _contexto.SaveChanges();
        }
    }
}
