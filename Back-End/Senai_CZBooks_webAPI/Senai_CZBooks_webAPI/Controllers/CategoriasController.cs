using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai_CZBooks_webAPI.Domains;
using Senai_CZBooks_webAPI.Interfaces;
using Senai_CZBooks_webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooks_webAPI.Controllers
{
    [Produces("application/json")]
    //http://localhost:5000/api/categorias
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {

        private ICategoriaRepository _categoriaRepository { get; set; }

        public CategoriasController()
        {
            _categoriaRepository = new CategoriaRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_categoriaRepository.Listar());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_categoriaRepository.BuscarPorId(id));
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Categoria novaCategoria)
        {
            try
            {
                _categoriaRepository.Cadastrar(novaCategoria);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Categoria categoriaAtualizada)
        {
            try
            {
                _categoriaRepository.Atualizar(id, categoriaAtualizada);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _categoriaRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

    }
}
