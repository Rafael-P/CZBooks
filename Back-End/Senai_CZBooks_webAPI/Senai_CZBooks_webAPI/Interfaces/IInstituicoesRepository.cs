using Senai_CZBooks_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooks_webAPI.Interfaces
{
    interface IInstituicoesRepository
    {

        List<Instituico> Listar();

        Instituico BuscarPorId(int id);

        void Cadastrar(Instituico novaCategoria);

        void Atualizar(int id, Instituico categoriaAtualizada);

        void Deletar(int id);

    }
}
