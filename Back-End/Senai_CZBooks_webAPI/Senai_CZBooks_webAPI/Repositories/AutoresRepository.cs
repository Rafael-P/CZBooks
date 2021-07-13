using Microsoft.EntityFrameworkCore;
using Senai_CZBooks_webAPI.Contexts;
using Senai_CZBooks_webAPI.Domains;
using Senai_CZBooks_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooks_webAPI.Repositories
{
    public class AutoresRepository : IAutoresRepository
    {
        /// <summary>
        /// Objeto por onde serao chamados os metodos do EF Core
        /// </summary>
        CZBooksContext ctx = new CZBooksContext();

        public void Atualizar(int id, Autore autorAtualizado)
        {
            Autore autorBuscado = ctx.Autores.Find(id);

            if (autorAtualizado.Nome != null)
            {
                autorBuscado.Nome = autorAtualizado.Nome;
            }

            ctx.Autores.Update(autorBuscado);

            ctx.SaveChanges();
        }

        public Autore BuscarPorId(int id)
        {
            return ctx.Autores.FirstOrDefault(a => a.IdAutores == id);
        }

        public void Cadastrar(Autore novoAutor)
        {
            ctx.Autores.Add(novoAutor);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Autores.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Autore> Listar()
        {
            return ctx.Autores.ToList();
        }

    }
}
