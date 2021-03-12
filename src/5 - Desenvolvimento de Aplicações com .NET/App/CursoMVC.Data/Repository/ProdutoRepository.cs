using CursoMVC.Business.Interfaces;
using CursoMVC.Business.Models;
using CursoMVC.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MvcDbContext context) : base(context) { }

        public async Task<Produto> ObterProdutoCategoria(Guid id)
        {
            return await _dbContext.Produtos.AsNoTracking().Include(p => p.Categoria).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosCategorias()
        {
            return await _dbContext.Produtos.AsNoTracking().Include(p => p.Categoria).OrderBy(p => p.Descricao).ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterProdutosPorCategoria(Guid categoriaId)
        {
            return await Buscar(p => p.CategoriaId == categoriaId);
        }
    }
}
