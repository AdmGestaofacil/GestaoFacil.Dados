using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoFacil.Dados.Modelos.DTO
{
    public class LinkDTO
    {
        public string Rel { get; set; }
        public string Href { get; set; }
        public string Method { get; set; }

        public LinkDTO(string rel, string href, string method)
        {
            Rel = rel;
            Href = href;
            Method = method;

        }
    }
}
