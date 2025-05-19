using TODO_List.Application;
using TODO_List.Application.AppServices;
using TODO_List.ConsoleApp.GUI;
using TODO_List.Domain.Modelo;

namespace TODO_List.ConsoleApp;

public class Controller
{
    private NotaView _notaView = new NotaView();
    private UsuarioView _usuarioView = new UsuarioView();
    private readonly NotaService _notaService;
    private readonly UsuarioService _usuarioService;

    public Controller(NotaService notaService, UsuarioService usuarioService)
    {
        _notaService = notaService;
        _usuarioService = usuarioService;
    }

    public void Run()
    {
        int opcao = 1;
        string usuario = string.Empty;

        while (opcao != 48)//48 é 0 na tabela ASCII
        {
            if (usuario == "")
            {
                var tempUsuario = LoginOuRegistro();
                usuario = _usuarioService.Login(tempUsuario) ? tempUsuario : string.Empty;

                if (usuario == "")
                {
                    _usuarioService.Registrar(tempUsuario);
                    usuario = tempUsuario;
                }
            }

            else
            {
                opcao = Menu(usuario);

                switch (opcao)
                {
                    case 49:
                        _notaView.ListarOpcoes();
                        opcao = _notaView.LerOpcao();
                        break;
                    case 50:
                        _usuarioView.ListarOpcoes();
                        opcao = _notaView.LerOpcao();
                        break;
                }

                ProcessarResposta(opcao, usuario);
            }
        }
    }


    string LoginOuRegistro()
    {
        int opcao;
        string usuario = string.Empty;
        _usuarioView.ListarOpcoesLogin();
        opcao = _usuarioView.LerOpcao(); //Retorna um valor ASCII

        switch (opcao)
        {
            case 49:
                _usuarioView.TelaLogin();
                usuario = _usuarioView.LerNomeUsuario();
                break;

            case 50:
                _usuarioView.TelaCadastrar();
                usuario = _usuarioView.LerNomeUsuario();
                break;
        }

        //Lógica para recuparar user
        return usuario;
    }

    int Menu(string usuario)
    {
        _usuarioView.TelaInicial();

        int opcao = _usuarioView.LerOpcao();

        return opcao;
    }

    public void ProcessarResposta(int opcao, string usuario)
    {
        int idNota = 0;
        (string, string) nota;
        (string, string, DateTime) notaLembrete;

        switch (opcao)
        {
            case 49:
               idNota = _notaView.ObterNotaPorId();
                nota = MapeamentoNota.
                    DesconstruirParaTupla(_usuarioService.ObterNotaPorId(idNota, usuario));

                break;
            case 50:
                nota = _notaView.CriarNota();
                _usuarioService.AdicionarNota(usuario, nota.Item1, nota.Item2);
                break;
            case 51:
                notaLembrete = _notaView.CriarNotaComLembrete();
                _usuarioService.AdicionarNota(usuario, notaLembrete.Item1, notaLembrete.Item2);
                break;
            case 52:
                List<Nota> notas = _usuarioService.ObterNotas(usuario);
                _notaView.ListarNotas(notas);
                break;
        }
    }
}