namespace TODO_List.Domain.ValueObjects;

public class Tag
{
    public string Nome { get; private set; }

    public Tag(string nome)
    {
        Nome = nome;
    }
}