namespace TODO_List.ConsoleApp.GUI;

public class UsuarioView : View
{
    public void ListarOpcoes()
    {
        Console.Clear();
        Console.WriteLine("1 - Alterar nome");
        Console.WriteLine("2 - Excluir Usuario");
    }

    public void ListarOpcoesLogin()
    {
        Console.WriteLine("1 - Login");
        Console.WriteLine("2 - Cadastrar Usuario");
    }


    public void TelaLogin()
    {
        Console.Clear();
        Console.WriteLine("Digite o nome de usuário: ");
    }

    public void TelaCadastrar()
    {
        Console.Clear();
        Console.WriteLine("Digite o nome do novo usuario: ");
    }

    public string LerNomeUsuario()
    {
        var nome = Console.ReadLine();

        return nome;
    }
}