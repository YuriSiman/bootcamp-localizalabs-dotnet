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
        /// <sumary>
        /// Este serviço permite cadastrar curso para o usuário autenticado.
        /// </sumary>
        /// <returns> Retorna um status 201 e dados do curso do usuário</returns>

        [SwaggerResponse(statusCode: 201, description: "Sucesso ao cadastrar um curso", Type = typeof(CursoViewModelInput))]
        [SwaggerResponse(statusCode: 401, description: "Não autorizado")]
        [HttpPost("")]
        public async Task<IActionResult> Post(CursoViewModelInput cursoViewModelInput)
        {
            var codigoUsuario = int.Parse(User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value);
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
            var cursos = new List<CursoViewModelOutput>();
            //var codigoUsuario = int.Parse(User.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value);

            cursos.Add(new CursoViewModelOutput()
            {
                Login = "",
                Descricao = "Teste",
                Nome = "Teste"
            });

            return Ok(cursos);
        }

    }
}
