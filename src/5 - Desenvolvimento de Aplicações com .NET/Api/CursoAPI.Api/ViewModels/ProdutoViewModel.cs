using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CursoAPI.Api.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Quantidade { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Categoria")]
        public Guid CategoriaId { get; set; }

        public CategoriaViewModel Categoria { get; set; }

        public IEnumerable<CategoriaViewModel> Categorias { get; set; }
    }
}
