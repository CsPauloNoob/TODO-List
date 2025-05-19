using TODO_List.Domain.DomainExceptions;

namespace TODO_List.Domain.Modelo;

public class Usuario
{
    public string Nome { get; set; }

    private List<Nota> Notas { get;  set; } = [];

    public Usuario(string nome)
    {
        ValidarNome(nome);
        Nome = nome;
    }

    public void AdicionarNota(Nota nota)
    {
        Notas.Add(nota);
    }


    public List<Nota> RecuperarNotas()
    {
        return Notas;
    }

    public void RemoverNota(Nota nota)
    {
        Notas.Remove(nota);
    }

    public Nota? RecuperarNota(int id)
    {
        Nota? nota = Notas.FirstOrDefault(n => n.Id == id);

        return nota;
    }

    public List<Nota> FiltrarNotasPorTag(string tagName)
    {
        return Notas.Where(nota => nota.Tags.Any(tag => tag.Nome == tagName)).ToList();
    }

    private void ValidarNome(string nome)
    {
        if (string.IsNullOrEmpty(nome))
            throw new NomeInvalidoException();
    }
}