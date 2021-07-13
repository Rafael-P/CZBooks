using Senai_CZBooks_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooks_webAPI.Interfaces
{
    interface ITiposUsuariosRepository
    {

        List<TiposUsuario> Listar();

        TiposUsuario BuscarPorId(int id);

        void Cadastrar(TiposUsuario novoTipo);

        void Atualizar(int id, TiposUsuario tipoAtualizado);

        void Deletar(int id);

    }
}
