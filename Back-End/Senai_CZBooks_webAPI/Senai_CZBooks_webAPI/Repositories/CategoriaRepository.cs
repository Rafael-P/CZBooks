using Senai_CZBooks_webAPI.Contexts;
using Senai_CZBooks_webAPI.Domains;
using Senai_CZBooks_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooks_webAPI.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        CZBooksContext ctx = new CZBooksContext();

        public void Atualizar(int id, Categoria categoriaAtualizada)
        {
            Categoria categoriaBuscada = ctx.Categorias.Find(id);

            if (categoriaAtualizada.Categoria1 != null)
            {
                categoriaBuscada.Categoria1 = categoriaAtualizada.Categoria1;
            }

            ctx.Categorias.Update(categoriaBuscada);

            ctx.SaveChanges();
        }

        public Categoria BuscarPorId(int id)
        {
            return ctx.Categorias.FirstOrDefault(c => c.IdCategoria == id);
        }

        public void Cadastrar(Categoria novaCategoria)
        {
            ctx.Categorias.Add(novaCategoria);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Categorias.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Categoria> Listar()
        {
            return ctx.Categorias.ToList();
        }


    }
}
