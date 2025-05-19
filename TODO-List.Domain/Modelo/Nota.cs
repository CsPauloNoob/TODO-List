using TODO_List.Domain.DomainExceptions;
using TODO_List.Domain.ValueObjects;

namespace TODO_List.Domain.Modelo;

public class Nota
{
    public int Id { get; private set; }
    public string Titulo { get; private set; }

    public string Texto { get; private set; }

    public List<Tag> Tags { get; private set; } = [];

    public Nota(int id, string titulo, string texto)
    {
        if (ValidarEntrada(texto))
        {
            Id = id;
            Titulo = titulo;
            Texto = texto;
        }

        else throw new TextoVazioOuNuloException();
    }


    public virtual bool ValidarEntrada(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return false;

        else return true;
    }

    public void AdicionarTag(Tag tag)
    {
        if (Tags.Exists(t => t.Nome == tag.Nome))
            return;

        Tags.Add(tag);
    }
}