using Curso.Api.Business.Entities;

namespace Curso.Api.Business.Repositories
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);
        Usuario ObterUsuario(string login);
        void Commit();
    }
}
