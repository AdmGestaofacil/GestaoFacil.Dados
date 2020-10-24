using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GestaoFacil.Dados.Modelos
{
    [Table("TipoPagamento")]
    public class TipoPagamento
    {
        [Key]
        public int TipoPagamentoId { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }
        public int Tipo { get; set; }  //NOT NULL DEFAULT '0' COMMENT '0 = CARTAO DE DEBITO\r\n1 =CARTAO DE CREDITO', COLOCAR DINHEIRO - criar um enum de tipopgto

        public DateTime DataCadastro { get; set; }

    }


}
