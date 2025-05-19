using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO_List.Domain.Modelo;

namespace TODO_List.Domain.Repositorio
{
    public interface IRepositorioUsuario
    {
        public void AdicionarUsuario(Usuario usuario);
        public List<Usuario> ObterUsuarios();
        public Usuario ObterUsuarioPorNome(string nome);
        public void RemoverUsuario(Usuario usuario);
    }
}