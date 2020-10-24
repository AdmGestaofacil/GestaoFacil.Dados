using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Modelos.DTO
{
    public abstract class BaseDTO
    {
        public List<LinkDTO> Links { get; set; }
    }
}
