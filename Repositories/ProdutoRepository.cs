using GestaoFacil.Dados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoFacil.Dados.Repositories
{
    public class ProdutoRepository : Interfaces.IProdutoRepository
    {

        private readonly Context _contexto;

        public ProdutoRepository(Context contexto)
        {
            //injeção de depencencia do contexto
            _contexto = contexto;
        }
        public void Add(Produto produto)
        {
            _contexto.Produtos.Add(produto);
            _contexto.SaveChanges();
        }

        public Produto Find(int id)
        {
            var obj = _contexto.Produtos.AsNoTracking().FirstOrDefault(p => p.ProdutoId == id);
            return obj;
        }

        public IEnumerable<Produto> GetAll()
        {
            return _contexto.Produtos.ToList();
        }

        public void Remove(int id)
        {
            var produto = Find(id);
            _contexto.Produtos.Remove(produto);
            _contexto.SaveChanges();
        }

        public void Update(Produto produto)
        {
            _contexto.Produtos.Update(produto);
            _contexto.SaveChanges();
        }
    }
}
