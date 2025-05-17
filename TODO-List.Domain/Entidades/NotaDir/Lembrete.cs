using TODO_List.Domain.DomainExceptions;

namespace TODO_List.Domain.Entidades.NotaDir;

public sealed class Lembrete : Nota
{
    public DateTime DataLembrete { get; private set; }

    public Lembrete(string titulo, string texto) : base(titulo, texto){}

    public void AdicionarLembrete(DateTime dataLembrete)
    {
        DataLembrete = dataLembrete;

        if (!ValidarEntrada(Texto))
            throw new DataIncorretaException();
    }

    public override bool ValidarEntrada(string texto)
    {
        if(DataLembrete < DateTime.Now)
            return false;
        
        return true; 
    }
    
}