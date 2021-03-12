using CursoMVC.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CursoMVC.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorCategoria(Guid categoriaId);
        Task<IEnumerable<Produto>> ObterProdutosCategorias();
        Task<Produto> ObterProdutoCategoria(Guid id);
    }
}
