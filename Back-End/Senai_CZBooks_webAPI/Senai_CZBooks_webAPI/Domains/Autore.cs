using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZBooks_webAPI.Domains
{
    public partial class Autore
    {
        public Autore()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdAutores { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
