using Curso.Api.Business.Entities;
using Curso.Api.Business.Repositories;
using Curso.Api.Configurations;
using Curso.Api.Filters;
using Curso.Api.Infraestrutura.Data;
using Curso.Api.ViewModels;
using Curso.Api.ViewModels.UsuariosViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class UsuariosController : MainController
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IAuthenticationService _authenticationService;

        public UsuariosController(IUsuarioRepository usuarioRepository, IAuthenticationService authenticationService)
        {
            _usuarioRepository = usuarioRepository;
            _authenticationService = authenticationService;
        }

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
            Usuario usuario = _usuarioRepository.ObterUsuario(loginViewModelInput.Login);

            if (usuario == null) return BadRequest("houve um erro ao tentar acessar.");

            var usuarioViewModelOutput = new UsuarioViewModelOutput()
            {
                Codigo = usuario.Codigo,
                Login = loginViewModelInput.Login,
                Email = usuario.Email
            };

            var token = _authenticationService.GerarToken(usuarioViewModelOutput);

            return Ok(new
            {
                Token = token,
                Usuario = usuarioViewModelOutput
            });
        }

        /// <sumary>
        /// Este serviço permite cadastrar um usuário cadastrado não existente.
        /// </sumary>
        /// <param name="registroViewModelInput"> ViewModel do registro de Login </param>
        /// <returns> Retorna um status OK, dados do usuário e o token em caso de sucesso</returns>
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos obrigatórios", Type = typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Erro interno", Type = typeof(ErroGenericoViewModel))]
        [HttpPost("registrar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Registrar(RegistroViewModelInput registroViewModelInput)
        {

            var usuario = new Usuario();
            usuario.Login = registroViewModelInput.Login;
            usuario.Senha = registroViewModelInput.Senha;
            usuario.Email = registroViewModelInput.Email;

            _usuarioRepository.Adicionar(usuario);
            _usuarioRepository.Commit();


            return Created("", registroViewModelInput);
        }
    }
}
