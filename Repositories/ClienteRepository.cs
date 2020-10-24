using GestaoFacil.Dados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoFacil.Dados.Repositories
{
    public class ClienteRepository : Interfaces.IClienteRepository
    {

        private readonly Context _contexto;

        public ClienteRepository(Context contexto)
        {
            _contexto = contexto;
        }
        public void Add(Cliente cliente)
        {
            _contexto.Clientes.Add(cliente);
            _contexto.SaveChanges();
        }
        public Cliente Find(int id)
        {
            var obj = _contexto.Clientes.AsNoTracking().FirstOrDefault(c => c.ClienteId == id);
            return obj;
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _contexto.Clientes.ToList();
        }

        public void Remove(int id)
        {
            var cliente = Find(id);
            _contexto.Clientes.Remove(cliente);
            _contexto.SaveChanges();
        }

        public void Update(Cliente cliente)
        {
            _contexto.Clientes.Update(cliente);
            _contexto.SaveChanges();
        }
    }
}
