using Senai_CZBooks_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooks_webAPI.Interfaces
{
    interface ILivroRepository
    {

        List<Livro> Listar();

        Livro BuscarPorId(int id);

        void Cadastrar(Livro novoLivro);

        void Atualizar(int id, Livro livroAtualizado);

        void Deletar(int id);

    }
}
