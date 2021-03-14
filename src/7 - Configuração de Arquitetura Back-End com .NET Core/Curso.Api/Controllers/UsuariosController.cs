using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.Api.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosController : MainController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
