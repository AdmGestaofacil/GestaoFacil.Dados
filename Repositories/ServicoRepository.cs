using GestaoFacil.Dados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoFacil.Dados.Repositories
{
    public class ServicoRepository : Interfaces.IServicoRepository
    {
        private readonly Context _contexto;

        public ServicoRepository(Context contexto)
        {
            //injeção de depencencia  do contexto
            _contexto = contexto;
        }

        public void Add(Servico servico)
        {
            _contexto.Servico.Add(servico);
            _contexto.SaveChanges();
        }

        public Servico Find(int id)
        {
            var obj = _contexto.Servico.AsNoTracking().FirstOrDefault(s => s.ServicoId == id);
            return obj;
        }

        public IEnumerable<Servico> GetAll()
        {
            return _contexto.Servico.ToList();
        }

        public int Remove(int id)
        {
            var servico = _contexto.Servico.FirstOrDefault(s => s.ServicoId == id);
            if (servico == null)
                return 0;

            _contexto.Servico.Remove(servico);
            _contexto.SaveChanges();

            return 1;
        }

        public void Update(Servico servico)
        {
            _contexto.Servico.Update(servico);
            _contexto.SaveChanges();
        }
    }
}
