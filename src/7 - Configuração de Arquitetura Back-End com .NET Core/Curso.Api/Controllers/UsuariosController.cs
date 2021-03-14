using Curso.Api.Filters;
using Curso.Api.ViewModels;
using Curso.Api.ViewModels.UsuariosViewModels;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class UsuariosController : MainController
    {
        /// <sumary>
        /// Este serviço permite autenticar um usuário cadastrado e ativo.
        /// </sumary>
        /// <param name="loginViewModelInput"> ViewModel do Login </param>
        /// <returns> Retorna um status OK, dados do usuário e o token em caso de sucesso</returns>

        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos obrigatórios", Type = typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Erro interno", Type = typeof(ErroGenericoViewModel))]
        [HttpPost("logar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            

            return Ok(loginViewModelInput);
        }

        [HttpPost("registrar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Registrar(RegistroViewModelInput registroViewModelInput)
        {
            return Created("", registroViewModelInput);
        }
    }
}
