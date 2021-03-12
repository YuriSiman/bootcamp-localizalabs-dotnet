using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CursoAPI.Api.ViewModels
{
    public class CategoriaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Descricao { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
