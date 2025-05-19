using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO_List.Domain.Modelo;

namespace TODO_List.Domain.Factory
{
    public static class NotaFactory
    {
        public static Nota CriarNota(string titulo, string texto, List<Nota> notasExistentes)
        {
            int novoId = 1;
            if (notasExistentes != null && notasExistentes.Any())
            {
                novoId = notasExistentes.Max(n => n.Id) + 1;
            }

            return new Nota(novoId, titulo, texto);
        }
    }
}