using CursoMVC.Business.Interfaces;
using CursoMVC.Business.Models;
using CursoMVC.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace CursoMVC.Data.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(MvcDbContext context) : base(context) { }

        public async Task<Categoria> ObterCategoriaProdutos(Guid id)
        {
            return await _dbContext.Categorias.AsNoTracking().Include(c => c.Produtos).FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
