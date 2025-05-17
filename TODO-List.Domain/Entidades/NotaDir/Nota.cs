using TODO_List.Domain.DomainExceptions;
using TODO_List.Domain.ValueObjects;

namespace TODO_List.Domain.Entidades.NotaDir;

public class Nota
{
    public int Id { get; set; }
    public string Titulo { get; private set; }
    
    public string Texto { get; private set; }
    
    public List<Tag> Tags { get; private set; }

    public Nota(string titulo, string texto)
    {
        if (ValidarEntrada(texto))
        {
            Titulo = titulo;
            Texto = texto;
        }

        else throw new TextoVazioOuNuloException("Texto não pode ser vazio!");
    }


    public virtual bool ValidarEntrada(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return false;

        else return true;
    }

    public void AdicionarTag(Tag tag)
    {
        if (Tags.Exists(t => t.Name == tag.Name))
            return;
        
        Tags.Add(tag);
    }
    
    
}