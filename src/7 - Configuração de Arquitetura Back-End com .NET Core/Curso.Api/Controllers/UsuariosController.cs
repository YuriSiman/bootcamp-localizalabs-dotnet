using Curso.Api.Business.Entities;
using Curso.Api.Filters;
using Curso.Api.Infraestrutura.Data;
using Curso.Api.ViewModels;
using Curso.Api.ViewModels.UsuariosViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var usuarioViewModelOutput = new UsuarioViewModelOutput()
            {
                Codigo = 1,
                Login = "yurisiman",
                Email = "contato@yurisiman.com.br"
            };

            var secret = Encoding.ASCII.GetBytes("Akdlisa&*#7458/>!ska%sdkakbk)ksbdk<dasd7");
            var symmetricSecurityKey = new SymmetricSecurityKey(secret);
            var securityTokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]{
                    new Claim(ClaimTypes.NameIdentifier, usuarioViewModelOutput.Codigo.ToString()),
                    new Claim(ClaimTypes.Name, usuarioViewModelOutput.Login.ToString()),
                    new Claim(ClaimTypes.Email, usuarioViewModelOutput.Email.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature)
            };
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var tokenGenerated = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
            var token = jwtSecurityTokenHandler.WriteToken(tokenGenerated);

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
        [HttpPost("logar")]
        [HttpPost("registrar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Registrar(RegistroViewModelInput registroViewModelInput)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CursoDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CursoAPI;Trusted_Connection=True;MultipleActiveResultSets=true");
            CursoDbContext contexto = new CursoDbContext(optionsBuilder.Options);

            var migracoesPendentes = contexto.Database.GetPendingMigrations();
            if(migracoesPendentes.Count() > 0)
            {
                contexto.Database.Migrate();
            }

            var usuario = new Usuario();
            usuario.Login = registroViewModelInput.Login;
            usuario.Senha = registroViewModelInput.Senha;
            usuario.Email = registroViewModelInput.Email;
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();

            return Created("", registroViewModelInput);
        }
    }
}
