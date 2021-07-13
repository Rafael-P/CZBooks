using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZBooks_webAPI.Domains
{
    public partial class Livro
    {
        public int IdLivro { get; set; }
        public string Titulo { get; set; }
        public string Sinopse { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdAutor { get; set; }
        public string DataDaPublicacao { get; set; }
        public decimal Preco { get; set; }

        public virtual Autore IdAutorNavigation { get; set; }
        public virtual Categoria IdCategoriaNavigation { get; set; }
    }
}
