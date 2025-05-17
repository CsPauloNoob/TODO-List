namespace TODO_List.ConsoleApp.GUI;

public class NotaView : View
{
    public void ListarOpcoes()
    {
        Console.Clear();
        Console.WriteLine("Opções:");
        Console.WriteLine("1 - Ver Nota");
        Console.WriteLine("1 - Criar Nota");
        Console.WriteLine("2 - Listar todas as Notas");
        Console.WriteLine("3 - Excluir Notas");
        Console.Write("4 - Editar Notas");
    }
}