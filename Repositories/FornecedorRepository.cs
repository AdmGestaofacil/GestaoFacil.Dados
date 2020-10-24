using GestaoFacil.Dados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoFacil.Dados.Repositories
{
    public class FornecedorRepository : Interfaces.IFornecedorRepository
    {
        private readonly Context _contexto;

        public FornecedorRepository(Context contexto)
        {
            _contexto = contexto;
        }
        public void Add(Fornecedor fornecedor)
        {
            _contexto.Fornecedores.Add(fornecedor);
            _contexto.SaveChanges();
        }

        public Fornecedor Find(int id)
        {
            var obj = _contexto.Fornecedores.AsNoTracking().FirstOrDefault(f => f.FornecedorId == id);
            return obj;
        }

        public IEnumerable<Fornecedor> GetAll()
        {
            return _contexto.Fornecedores.ToList();
        }

        public void Remove(int id)
        {

            var fornecedor = Find(id);
            _contexto.Fornecedores.Remove(fornecedor);
            _contexto.SaveChanges();
        }

        public void Update(Fornecedor fornecedor)
        {
            _contexto.Fornecedores.Update(fornecedor);
            _contexto.SaveChanges();
        }
    }
}
