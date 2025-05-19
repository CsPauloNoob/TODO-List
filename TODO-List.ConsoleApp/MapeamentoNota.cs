
using TODO_List.Domain.Modelo;

namespace TODO_List.Application
{
    public static class MapeamentoNota
    {
        public static (string, string) DesconstruirParaTupla(Nota nota)
        {
            if (nota == null)
                throw new ArgumentNullException(nameof(nota));

            return (nota.Titulo, nota.Texto);
        }

        public static (string, string, DateTime) DesconstruirParaTuplaComLembrete(Lembrete nota)
        {
            if (nota == null)
                throw new ArgumentNullException(nameof(nota));
            return (nota.Titulo, nota.Texto, nota.DataLembrete);
        }
    }
}