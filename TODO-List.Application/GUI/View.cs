namespace TODO_List.Application.GUI;

public abstract class View
{
    public void TelaInicial()
    {
        Console.Clear();
        
        Console.WriteLine("Tela Inicial");
        
        Console.WriteLine("1 - Gerenciar Notas");
        Console.WriteLine("2 - Gerenciar Usuario");
    }


    public int LerOpcao()
    {
        Console.Write(" escolha uma opção: ");
        int opcao = Console.ReadKey().KeyChar;
        
        return opcao;
    }
}