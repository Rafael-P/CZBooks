using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZBooks_webAPI.Domains
{
    public partial class Instituico
    {
        public int IdInstituicao { get; set; }
        public string NomeInstituicao { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}
