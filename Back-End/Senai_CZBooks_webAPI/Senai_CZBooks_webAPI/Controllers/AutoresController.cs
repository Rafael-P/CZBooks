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
    //ex: http://localhost:5000/api/autores
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {

        private IAutoresRepository _autoresRepository { get; set; }

        public AutoresController()
        {
            _autoresRepository = new AutoresRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_autoresRepository.Listar());
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
                return Ok(_autoresRepository.BuscarPorId(id));
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Autore novoAutor)
        {
            try
            {
                _autoresRepository.Cadastrar(novoAutor);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Autore autorAtualizado)
        {
            try
            {
                _autoresRepository.Atualizar(id, autorAtualizado);

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
                _autoresRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


    }
}
