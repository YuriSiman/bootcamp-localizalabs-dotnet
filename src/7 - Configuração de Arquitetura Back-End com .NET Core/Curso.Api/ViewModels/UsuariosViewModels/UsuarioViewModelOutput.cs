using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Curso.Api.ViewModels.UsuariosViewModels
{
    public class UsuarioViewModelOutput
    {

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Email { get; set; }
    }
}
