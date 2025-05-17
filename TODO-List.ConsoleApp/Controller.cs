using TODO_List.Application.AppServices;
using TODO_List.Application.GUI;

namespace TODO_List.ConsoleApp;

public class Controller
{
    private NotaView _notaView = new NotaView();
    private UsuarioView _usuarioView = new UsuarioView();
    private readonly NotaService _notaService;

    public Controller(NotaService notaService, UsuarioService usuarioService)
    {
        _notaService = notaService;
    }
    
    public void Run()
    {
        int opcao = 1;
        string usuario = String.Empty;
        
        while (opcao != 48)//48 é 0 na tabela ASCII
        {
            if (usuario == "")
            {
                usuario = LoginOuRegistro();
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
            }
            
        }
    }


    string LoginOuRegistro()
    {
        int opcao;
        string usuario;
        _usuarioView.ListarOpcoesLogin();
        opcao = _usuarioView.LerOpcao(); //Retorna um valor ASCII

        switch (opcao)
        {
            case 49: 
                _usuarioView.TelaLogin();
                usuario = _usuarioView.LerNomeUsuario();
                break;
            
            case 50: _usuarioView.TelaCadastrar();
                usuario = _usuarioView.LerNomeUsuario();
                break;
        }
        
        //Lógica para recuparar user
        return "teste";
    }

    int Menu(string usuario)
    {
        _usuarioView.TelaInicial();
        
        int opcao = _usuarioView.LerOpcao();

        return opcao;
    }

    public void ProcessarResposta(int opcao)
    {
        
    }
}