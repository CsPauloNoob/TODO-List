using TODO_List.Domain.Entidades.NotaDir;

namespace TODO_List.Domain.Entidades.UsuarioDir;

public class Usuario
{
    public string Name { get; private set; }
    
    public List<Nota> Notas { get; private set; }
    
}