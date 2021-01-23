using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Modelos.DTO
{
    public class ValeDTO
    {
        public int ValeId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public int FuncionarioId { get; set; }
        public string Funcionario { get; set; }
        public string Teste { get; set; }

    }
}
