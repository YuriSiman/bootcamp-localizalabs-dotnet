using System;

namespace CursoMVC.Business.Models
{
    public class Produto : Entity
    {
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }
        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
