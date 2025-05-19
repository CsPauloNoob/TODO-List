using TODO_List.Domain.Factory;
using TODO_List.Domain.Modelo;
using TODO_List.Domain.Repositorio;
using TODO_List.Infra;

namespace TODO_List.Application.AppServices;

public class UsuarioService
{
    private readonly IRepositorioUsuario _repositorioUsuario;

    public UsuarioService()
    {
        _repositorioUsuario = new RepositorioUsuario();
    }


    public List<Nota> ObterNotas(string nomeUsuario)
    {
        var usuario = _repositorioUsuario.ObterUsuarioPorNome(nomeUsuario);
        return usuario.RecuperarNotas();
    }

    public Nota ObterNotaPorId(int id, string nomeUsuario)
    {
        var usuario = _repositorioUsuario.ObterUsuarioPorNome(nomeUsuario);
        return usuario.RecuperarNota(id);
    }

    public void ExcluirNota(string nomeUsuario, int id)
    {
        var usuario = _repositorioUsuario.ObterUsuarioPorNome(nomeUsuario);
        //usuario.RemoverNota();
    }

    public void AdicionarNota(string nomeUsuario, string texto, string titulo)
    {
        var usuario = _repositorioUsuario.ObterUsuarioPorNome(nomeUsuario);
        var notas = usuario.RecuperarNotas();

        usuario.AdicionarNota(NotaFactory.CriarNota(titulo, texto, notas));
    }

    public bool Login(string nome)
    {
        var usuario = _repositorioUsuario.ObterUsuarioPorNome(nome);

        if (usuario == null)
        {
            return false;
        }

        else return true;
    }

    public string Registrar(string nome)
    {
        var usuario = _repositorioUsuario.ObterUsuarioPorNome(nome);
        if (usuario != null)
        {
            return string.Empty;
        }
        else
        {
            _repositorioUsuario.AdicionarUsuario(new Usuario(nome));
            return nome;
        }
    }
}