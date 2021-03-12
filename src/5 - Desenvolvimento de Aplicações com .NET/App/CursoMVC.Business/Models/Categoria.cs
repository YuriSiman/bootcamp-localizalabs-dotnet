using System.Collections.Generic;

namespace CursoMVC.Business.Models
{
    public class Categoria : Entity
    {
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
