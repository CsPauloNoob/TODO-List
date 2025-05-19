using TODO_List.Domain.Modelo;
using TODO_List.Domain.Repositorio;

namespace TODO_List.Infra
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly List<Usuario> _usuarios = [];

        public void AdicionarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public List<Usuario> ObterUsuarios()
        {
            return _usuarios;
        }

        public Usuario ObterUsuarioPorNome(string nome)
        {
            return _usuarios.FirstOrDefault(u => u.Nome == nome);
        }

        public void RemoverUsuario(Usuario usuario)
        {
            _usuarios.Remove(usuario);
        }
    }
}