using Curso.Api.Business.Entities;
using Curso.Api.Business.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Curso.Api.Infraestrutura.Data.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private readonly CursoDbContext _contexto;

        public CursoRepository(CursoDbContext contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Cursos cursos)
        {
            _contexto.Cursos.Add(cursos);
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }

        public IList<Cursos> ObterPorUsuario(int codigoUsuario)
        {
            return _contexto.Cursos.Include(c => c.Usuario).Where(c => c.CodigoUsuario == codigoUsuario).ToList();
        }
    }
}
