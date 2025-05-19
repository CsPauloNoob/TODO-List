using TODO_List.Domain.DomainExceptions;
using TODO_List.Domain.Modelo;

namespace TODO_List.Testes
{
    public class LembreteTeste
    {
        [Fact]
        public void AdicionarLembrete_ComDataFutura_DeveDefinirDataLembrete()
        {
            var lembrete = new Lembrete(1, "Titulo", "Texto");
            var dataFutura = DateTime.Now.AddDays(1);

            lembrete.AdicionarLembrete(dataFutura);

            Assert.Equal(dataFutura, lembrete.DataLembrete);
        }

        [Fact]
        public void AdicionarLembrete_ComDataPassada_DeveLancarExcecao()
        {
            var lembrete = new Lembrete(1, "Titulo", "Texto");
            var dataPassada = DateTime.Now.AddDays(-1);

            Assert.Throws<DataIncorretaException>(() => lembrete.AdicionarLembrete(dataPassada));
        }

        [Fact]
        public void ValidarEntrada_DataFutura_DeveRetornarTrue()
        {
            var lembrete = new Lembrete(1, "Titulo", "Texto");
            var dataFutura = DateTime.Now.AddDays(2);
            lembrete.AdicionarLembrete(dataFutura);

            Assert.True(lembrete.ValidarEntrada("Texto"));
        }
    }
}
