using GestaoFacil.Dados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoFacil.Dados.Repositories
{
    public class CartaoRepository : Interfaces.ICartaoRepository
    {
        private readonly Context _contexto;
        public CartaoRepository(Context contexto)
        {
            //Injecção 
            _contexto = contexto;
        }

        public void Add(Cartao cartao)
        {
            _contexto.Cartao.Add(cartao);
            _contexto.SaveChanges();
        }
        public Cartao Find(int id)
        {
            var obj = _contexto.Cartao.AsNoTracking().FirstOrDefault(c =>  c.CartaoId  == id);
            return obj;
        }

        public IEnumerable<Cartao> GetAll()
        {
            return _contexto.Cartao.ToList();
        }
        //
        public void Remove(int id)
        {
            var cartao = Find(id);
            _contexto.Cartao.Remove(cartao);
            _contexto.SaveChanges();

        }

        public void Update(Cartao cartao)
        {
            _contexto.Cartao.Update(cartao);
            _contexto.SaveChanges();
        }
    }
}
