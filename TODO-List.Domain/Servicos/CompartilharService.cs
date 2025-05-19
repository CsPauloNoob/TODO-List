using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODO_List.Domain.Modelo;

namespace TODO_List.Domain.Servicos
{
    public class CompartilharService
    {
        public void CompartilharNota(Usuario usuarioDestino, Nota nota)
        {
            if(nota is null )
                throw new ArgumentNullException(nameof(nota), "Nota não pode ser nula.");

            if (usuarioDestino.RecuperarNota(nota.Id) is null)
            {
                usuarioDestino.AdicionarNota(nota);
            }
                
        }
    }
}
