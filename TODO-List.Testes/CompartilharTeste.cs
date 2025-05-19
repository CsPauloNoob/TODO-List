using TODO_List.Domain.Modelo;
using TODO_List.Domain.Servicos;

namespace TODO_List.Testes
{
    public class CompartilharTeste
    {
        [Fact]
        public void CompartilharNota_DeveAdicionarNotaSeNaoExistir()
        {
            var usuarioOrigem = new Usuario("Origem");
            var usuarioDestino = new Usuario("Destino");
            var nota = new Nota(1, "Titulo", "Texto");

            usuarioOrigem.AdicionarNota(nota);

            var service = new CompartilharService();

            service.CompartilharNota(usuarioDestino, nota);

            Assert.Contains(nota, usuarioDestino.RecuperarNotas());
        }

        [Fact]
        public void CompartilharNota_NaoDeveAdicionarNotaSeJaExistir()
        {
            var usuarioDestino = new Usuario("Destino");
            var nota = new Nota(1, "Titulo", "Texto");
            usuarioDestino.AdicionarNota(nota);

            var service = new CompartilharService();

            service.CompartilharNota(usuarioDestino, nota);

            Assert.Single(usuarioDestino.RecuperarNotas(), n => n.Id == nota.Id);
        }

        [Fact]
        public void CompartilharNota_NotaNula_DeveLancarExcecao()
        {
            var usuarioDestino = new Usuario("Destino");
            var service = new CompartilharService();

            Assert.Throws<ArgumentNullException>(() => service.CompartilharNota(usuarioDestino, null));
        }
    }
}
