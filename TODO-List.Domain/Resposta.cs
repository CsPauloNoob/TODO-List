namespace TODO_List.Domain;

public class Resposta<T>
{
    public T objeto;
    public Status status;
    
    
}


public enum Status
{
    Sucesso,
    Erro,
}