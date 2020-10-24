using GestaoFacil.Dados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoFacil.Dados.Repositories
{
    public class EmpresaRepository : Interfaces.IEmpresaRepository
    {

        private readonly Context _contexto;

        public EmpresaRepository(Context contexto)
        {
            _contexto = contexto;
        }
        public void Add(Empresa empresa)
        {
            _contexto.Empresas.Add(empresa);
            _contexto.SaveChanges();
        }

        public Empresa Find(int id)
        {
            var obj = _contexto.Empresas.AsNoTracking().FirstOrDefault(e => e.EmpresaId == id);
            return obj;
        }

        public IEnumerable<Empresa> GetAll()
        {
            return _contexto.Empresas.ToList();
        }

        public void Remove(int id)
        {
            var empresa = Find(id);
            _contexto.Empresas.Remove(empresa);
            _contexto.SaveChanges();
        }

        public void Update(Empresa empresa)
        {
            _contexto.Empresas.Update(empresa);
            _contexto.SaveChanges();
        }
    }
}
