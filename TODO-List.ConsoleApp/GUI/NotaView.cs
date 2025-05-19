using TODO_List.Domain.Modelo;
namespace TODO_List.ConsoleApp.GUI;

public class NotaView : View
{
    public void ListarOpcoes()
    {
        Console.Clear();
        Console.WriteLine("Opções:");
        Console.WriteLine("1 - Ver Nota");
        Console.WriteLine("2 - Criar Nota");
        Console.WriteLine("3 - Criar Nota com Lembrete");
        Console.WriteLine("4 - Listar todas as Notas");
        Console.WriteLine("5 - Excluir Notas");
        Console.Write("4 - Editar Notas");
    }

    public (string, string) CriarNota()
    {
        Console.Clear();
        Console.WriteLine("Criar Nota");

        Console.Write("Digite o título da nota: ");
        string titulo = Console.ReadLine() ?? string.Empty;

        Console.Clear();
        Console.WriteLine("Criar Nota");
        Console.Write("Digite o corpo da nota: ");
        string corpo = Console.ReadLine();

        return (titulo, corpo);
    }


    public (string, string, DateTime) CriarNotaComLembrete()
    {
        Console.Clear();
        Console.WriteLine("Criar Nota com Lembrete");
        Console.Write("Digite o título da nota: ");
        string titulo = Console.ReadLine() ?? string.Empty;
        Console.Clear();
        Console.WriteLine("Criar Nota com Lembrete");
        Console.Write("Digite o corpo da nota: ");
        string corpo = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Criar Nota com Lembrete");
        Console.Write("Digite a data do lembrete (dd/MM/yyyy): ");
        DateTime dataLembrete = DateTime.Parse(Console.ReadLine() ?? string.Empty);
        
        return (titulo, corpo, dataLembrete);
    }

    public int ObterNotaPorId()
    {
        Console.Clear();
        Console.WriteLine("Digite o ID da nota: ");
        int id = int.Parse(Console.ReadLine() ?? string.Empty);
        return id;
    }

    public void ListarNotas(List<Nota> notas)
    {
        int contador = 0;
        Console.Clear();
        Console.WriteLine("Notas:");
        foreach (var nota in notas)
        {
            Console.WriteLine($"{contador} - Título: {nota.Titulo}, Corpo: {nota.Texto}");
        }

        Console.ReadKey();
    }
}