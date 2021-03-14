using Curso.Api.Business.Entities;
using System.Collections.Generic;

namespace Curso.Api.Business.Repositories
{
    public interface ICursoRepository
    {
        void Adicionar(Cursos cursos);
        IList<Cursos> ObterPorUsuario(int codigoUsuario);
        void Commit();
    }
}
