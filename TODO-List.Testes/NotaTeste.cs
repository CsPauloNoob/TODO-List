using TODO_List.Domain.DomainExceptions;
using TODO_List.Domain.Modelo;
using TODO_List.Domain.ValueObjects;

namespace TODO_List.Testes
{
    public class NotaTeste
    {
        [Fact]
        public void AdicionarTag_DeveAdicionarTagNaLista()
        {
            var nota = new Nota(1, "Titulo", "Texto");
            var tag = new Tag("Importante");

            nota.AdicionarTag(tag);

            Assert.Contains(tag, nota.Tags);
        }

        [Fact]
        public void AdicionarTag_Duplicada_NaoDeveAdicionarNovamente()
        {
            var nota = new Nota(1, "Titulo", "Texto");
            var tag = new Tag("Importante");

            nota.AdicionarTag(tag);
            nota.AdicionarTag(new Tag("Importante"));

            Assert.Single(nota.Tags);
        }

        [Fact]
        public void ValidarEntrada_TextoValido_DeveRetornarTrue()
        {
            var nota = new Nota(1, "Titulo", "Texto");
            Assert.True(nota.ValidarEntrada("Texto qualquer"));
        }

        [Fact]
        public void ValidarEntrada_TextoVazioOuNulo_DeveRetornarFalse()
        {
            var nota = new Nota(1, "Titulo", "Texto");
            Assert.False(nota.ValidarEntrada(""));
            Assert.False(nota.ValidarEntrada(null));
        }
    }
}
