using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZBooks_webAPI.Domains
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public int? IdTipoUsuario { get; set; }

        public virtual TiposUsuario IdTipoUsuarioNavigation { get; set; }
    }
}
