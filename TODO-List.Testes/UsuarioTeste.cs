using TODO_List.Domain.DomainExceptions;
using TODO_List.Domain.Modelo;
using TODO_List.Domain.ValueObjects;

namespace TODO_List.Testes
{
    public class UsuarioTeste
    {
        [Fact]
        public void AdicionarNota_DeveAdicionarNotaNaLista()
        {
            var usuario = new Usuario("Maria");
            var nota = new Nota(1, "Titulo", "Texto");

            usuario.AdicionarNota(nota);

            Assert.Contains(nota, usuario.RecuperarNotas());
        }

        [Fact]
        public void RemoverNota_DeveRemoverNotaDaLista()
        {
            var usuario = new Usuario("Carlos");
            var nota = new Nota(1, "Titulo", "Texto");
            usuario.AdicionarNota(nota);

            usuario.RemoverNota(nota);

            Assert.DoesNotContain(nota, usuario.RecuperarNotas());
        }

        [Fact]
        public void RecuperarNota_NotaExistente_DeveRetornarNota()
        {
            var usuario = new Usuario("Ana");
            var nota = new Nota(1, "Titulo", "Texto");
            usuario.AdicionarNota(nota);

            var resultado = usuario.RecuperarNota(1);

            Assert.Equal(nota, resultado);
        }

        [Fact]
        public void RecuperarNota_NotaInexistente_DeveRetornarNull()
        {
            var usuario = new Usuario("Ana");
            var resultado = usuario.RecuperarNota(99);

            Assert.Null(resultado);
        }

        [Fact]
        public void FiltrarNotasPorTag_DeveRetornarNotasComTag()
        {
            var usuario = new Usuario("Pedro");
            var tagImportante = new Tag("Importante");
            var tagTrabalho = new Tag("Trabalho");

            var nota1 = new Nota(1, "Titulo1", "Texto1");
            nota1.AdicionarTag(tagImportante);

            var nota2 = new Nota(2, "Titulo2", "Texto2");
            nota2.AdicionarTag(tagTrabalho);

            usuario.AdicionarNota(nota1);
            usuario.AdicionarNota(nota2);

            var resultado = usuario.FiltrarNotasPorTag("Importante");

            Assert.Single(resultado);
            Assert.Contains(nota1, resultado);
        }

        [Fact]
        public void AdicionarNota_ComDadosInvalidos_DeveLancarExcecao()
        {
            var usuario = new Usuario("João");

            Assert.Throws<TextoVazioOuNuloException>(() =>
            {
                var notaInvalida = new Nota(1, "Titulo", "");
                usuario.AdicionarNota(notaInvalida);
            });
        }
    }
}