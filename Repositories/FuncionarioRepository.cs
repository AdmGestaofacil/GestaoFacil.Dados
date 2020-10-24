using GestaoFacil.Dados.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoFacil.Dados.Repositories
{
    public class FuncionarioRepository : Interfaces.IFuncionarioRepository
    {

        private readonly Context _contexto;

        public FuncionarioRepository(Context contexto)
        {
            //injeção de depencencia do contexto
            _contexto = contexto;
        }

        public void Add(Funcionario funcionario)
        {
            _contexto.Funcionarios.Add(funcionario);
            _contexto.SaveChanges();
        }

        public Funcionario Find(int id)
        {
            var obj = _contexto.Funcionarios.AsNoTracking().FirstOrDefault(f => f.FuncionarioId == id);
            return obj;
        }

        public IEnumerable<Funcionario> GetAll()
        {
            return _contexto.Funcionarios.ToList();
        }

        public void Remove(int id)
        {
   
            var funcionario = Find(id);
                _contexto.Funcionarios.Remove(funcionario);
                _contexto.SaveChanges();
        }

        public void Update(Funcionario funcionario)
        {
            _contexto.Funcionarios.Update(funcionario);
            _contexto.SaveChanges();
        }

    }
}
