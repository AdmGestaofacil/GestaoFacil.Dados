using GestaoFacil.Dados.Modelos;
using GestaoFacil.Dados.Modelos.DTO;
using GestaoFacil.Dados.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoFacil.Dados.Repositories
{
    public class ValeRepository : Interfaces.IValeRepository
    {
        private readonly Context _contexto;

        public ValeRepository(Context contexto)
        {
            _contexto = contexto;
        }
        public void Add(Vale vale)
        {
            _contexto.Vales.Add(vale);
            _contexto.SaveChanges();
        }

        public Vale Find(int id)
        {
            var obj = _contexto.Vales.AsNoTracking().FirstOrDefault(v => v.ValeId == id);
            return obj;
        }

        public IEnumerable<Vale> GetAll()
        {

            //var teste = GetVales();
            return _contexto.Vales.ToList();
        }

        public int Remove(int id)
        {
            var vale = _contexto.Vales.FirstOrDefault(s => s.ValeId == id);
            if (vale == null)
                return 0;

            _contexto.Vales.Remove(vale);
            _contexto.SaveChanges();

            return 1;
        }
        public void Update(Vale vale)
        {
            _contexto.Vales.Update(vale);
            _contexto.SaveChanges();
        }


        public List<ValeDTO> GetVales()
        {
            return _contexto.Vales
              .Include(a => a.Funcionario)
              .Select(b =>
             new ValeDTO()
             {
                 FuncionarioId = b.FuncionarioId,
                 ValeId = b.ValeId,
                 Descricao = b.Descricao,
                 Valor = b.Valor,
                 Funcionario = b.Funcionario.Nome
             }).ToList();
        }

        public Vale GetValeDto()
        {
            var valedtos = _contexto.Vales
              .Include(a => a.Funcionario)
              .Select(b =>
             new Vale()
             {
                 FuncionarioId = b.FuncionarioId,
                 ValeId = b.ValeId,
                 Descricao = b.Descricao,
                 Valor = b.Valor
                 //Funcionario = b.Funcionario.Nome
             }).FirstOrDefault();

            return valedtos;
        }
    }
}
