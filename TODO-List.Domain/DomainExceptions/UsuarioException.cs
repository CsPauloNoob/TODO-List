using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO_List.Domain.DomainExceptions
{
    public class NomeInvalidoException : Exception
    {
        public NomeInvalidoException() : base("Nome inválido.")
        {
        }
    }
}