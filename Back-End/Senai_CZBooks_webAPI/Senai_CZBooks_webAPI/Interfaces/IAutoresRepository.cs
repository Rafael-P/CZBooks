using Senai_CZBooks_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooks_webAPI.Interfaces
{
    /// <summary>
    /// Interface responsavel pelo AutoresRepository
    /// </summary>
    interface IAutoresRepository
    {
        /// <summary>
        /// Lista todos os autores
        /// </summary>
        /// <returns>Uma lista de autores</returns>
        List<Autore> Listar();

        /// <summary>
        /// Busca um Autor pelo id
        /// </summary>
        /// <param name="id">id do autor</param>
        /// <returns>Um autor buscado</returns>
        Autore BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo autor
        /// </summary>
        /// <param name="novoAutor">Objeto novoAutor que sera cadastrado</param>
        void Cadastrar(Autore novoAutor);

        /// <summary>
        /// Atualiza um Autor existente
        /// </summary>
        /// <param name="id">id do Autor</param>
        /// <param name="autorAtualizado">Objeto autorAtualizado com as novas informações</param>
        void Atualizar(int id, Autore autorAtualizado);

        /// <summary>
        /// Deleta um autor existente
        /// </summary>
        /// <param name="id">id do autor</param>
        void Deletar(int id);

    }
}
