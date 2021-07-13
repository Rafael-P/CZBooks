using Senai_CZBooks_webAPI.Contexts;
using Senai_CZBooks_webAPI.Domains;
using Senai_CZBooks_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooks_webAPI.Repositories
{
    public class LivrosRepository : ILivroRepository
    {
        CZBooksContext ctx = new CZBooksContext();

        public void Atualizar(int id, Livro livroAtualizado)
        {
            Livro livroBuscado = ctx.Livros.Find(id);

            if (livroAtualizado.Titulo != null)
            {
                livroBuscado.Titulo = livroAtualizado.Titulo;
            }

            if (livroAtualizado.Sinopse != null)
            {
                livroBuscado.Sinopse = livroAtualizado.Sinopse;
            }

            if (livroAtualizado.Preco != 0)
            {
                livroBuscado.Preco = livroAtualizado.Preco;
            }

            if (livroAtualizado.IdCategoria != null)
            {
                livroBuscado.IdCategoria = livroAtualizado.IdCategoria;
            }

            if (livroAtualizado.IdAutor != null)
            {
                livroBuscado.IdAutor = livroAtualizado.IdAutor;
            }

            if (livroAtualizado.DataDaPublicacao != null)
            {
                livroBuscado.DataDaPublicacao = livroAtualizado.DataDaPublicacao;
            }

            ctx.Livros.Update(livroBuscado);

            ctx.SaveChanges();
        }

        public Livro BuscarPorId(int id)
        {
            return ctx.Livros.FirstOrDefault(l => l.IdLivro == id);
        }

        public void Cadastrar(Livro novoLivro)
        {
            ctx.Livros.Add(novoLivro);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Livros.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Livro> Listar()
        {
            return ctx.Livros.ToList();
        }
    }
}
