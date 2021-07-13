using Senai_CZBooks_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooks_webAPI.Interfaces
{
    interface ICategoriaRepository
    {

        List<Categoria> Listar();

        Categoria BuscarPorId(int id);

        void Cadastrar(Categoria novaCategoria);

        void Atualizar(int id, Categoria categoriaAtualizada);

        void Deletar(int id);

    }
}
