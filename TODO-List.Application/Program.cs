using TODO_List.Application.AppServices;

namespace TODO_List.Application;

class Program
{
    static void Main(string[] args)
    {
        var controller = InicializaController();
        
        controller.Run();
    }

    static Controller InicializaController()
    {
        var notaService = new NotaService();
        var usuarioService = new UsuarioService();
        
        return new Controller(notaService, usuarioService);
    }
}