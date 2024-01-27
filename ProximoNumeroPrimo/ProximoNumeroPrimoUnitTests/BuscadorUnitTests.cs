using ProximoNumeroPrimo;

namespace ProximoNumeroPrimoUnitTests
{
    public class BuscadorUnitTests
    {
        [Fact]
        public void TestarNumero12()
        {
            int numero = 12;
            int expected = 13;

            int actual = Buscador.BuscarPorNumeroPrimoMaisProximo(numero);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestarNumero24()
        {
            int numero = 24; 
            int expected = 29;

            int actual = Buscador.BuscarPorNumeroPrimoMaisProximo(numero);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestarNumero11()
        {
            int numero = 11;
            int expected = 11;

            int actual = Buscador.BuscarPorNumeroPrimoMaisProximo(numero);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestarNumero200()
        {
            int numero = 200;
            int expected = 211;

            int actual = Buscador.BuscarPorNumeroPrimoMaisProximo(numero);
            
            Assert.Equal(expected, actual);
        }

    }
}