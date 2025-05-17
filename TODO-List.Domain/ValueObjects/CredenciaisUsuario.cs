namespace TODO_List.Domain.ValueObjects;

public class CredenciaisUsuario
{
    private string SenhaUsuario { get; set; }


    public void DefinirSenhaUsuario(string senhaUsuario)
    {
        SenhaUsuario = senhaUsuario;
    }
}