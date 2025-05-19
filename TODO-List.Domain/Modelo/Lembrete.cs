using TODO_List.Domain.DomainExceptions;

namespace TODO_List.Domain.Modelo;

public sealed class Lembrete : Nota
{
    public DateTime DataLembrete { get; private set; }

    public Lembrete(int id, string titulo, string texto)
        : base(id, titulo, texto)
    {
    }



    public void AdicionarLembrete(DateTime dataLembrete)
    {
        if (dataLembrete < DateTime.Now)
            throw new DataIncorretaException();

        DataLembrete = dataLembrete;
    }

}