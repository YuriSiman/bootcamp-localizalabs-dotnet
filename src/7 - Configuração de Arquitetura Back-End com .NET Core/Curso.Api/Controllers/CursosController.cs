using Curso.Api.Business.Entities;
using Curso.Api.Business.Repositories;
using Curso.Api.ViewModels.CursosViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Curso.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [Authorize]
    public class CursosController : MainController
    {
        private readonly ICursoRepository _cursoRepository;

        public CursosController(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }

        /// <sumary>
        /// Este serviço permite cadastrar curso para o usuário autenticado.
        /// </sumary>
        /// <returns> Retorna um status 201 e dados do curso do usuário</returns>

        [SwaggerResponse(statusCode: 201, description: "Sucesso ao cadastrar um curso", Type = typeof(CursoViewModelInput))]
        [SwaggerResponse(statusCode: 401, description: "Não autorizado")]
        [HttpPost("")]
        public async Task<IActionResult> Post(CursoViewModelInput cursoViewModelInput)
        {
            Cursos curso = new Cursos();
            curso.Nome = cursoViewModelInput.Nome;
            curso.Descricao = cursoViewModelInput.Descricao;
            var codigoUsuario = int.Parse(User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value);
            curso.CodigoUsuario = codigoUsuario;
            _cursoRepository.Adicionar(curso);
            _cursoRepository.Commit();
            return Created("", cursoViewModelInput);
        }

        /// <sumary>
        /// Este serviço permite obter todos os cursos ativos do usuário.
        /// </sumary>
        /// <returns> Retorna um status OK e dados do curso do usuário</returns>

        [SwaggerResponse(statusCode: 200, description: "Sucesso ao obter os cursos", Type = typeof(CursoViewModelInput))]
        [SwaggerResponse(statusCode: 401, description: "Não autorizado")]
        [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            var codigoUsuario = int.Parse(User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value);

            var cursos = _cursoRepository.ObterPorUsuario(codigoUsuario)
                .Select(c => new CursoViewModelOutput()
                {
                    Nome = c.Nome,
                    Descricao = c.Descricao,
                    Login = c.Usuario.Login
                });

            return Ok(cursos);
        }

    }
}
