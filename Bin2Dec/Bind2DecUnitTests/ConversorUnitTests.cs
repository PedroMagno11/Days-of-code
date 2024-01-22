using Bin2Dec.Entidades;

namespace Bind2DecUnitTests
{
    public class ConversorUnitTests
    {
        [Fact]
        public void BinarioParaDecimal()
        {
            //arrange
            string numeroBinario = "100101";
            int retornoEsperado = 37;

            //act
            int actual = Conversor.BinarioParaDecimal(numeroBinario);
        
            //assert
            Assert.Equal(retornoEsperado, actual);
        }

        [Fact]
        public void DecimalParaBinario()
        {
            //arrange
            string numeroDecimal = "12";
            string retornoEsperado = "1100";

            //act
            string actual = Conversor.DecimalParaBinario(numeroDecimal);

            //assert
            Assert.Equal(retornoEsperado, actual);
        }
    }
}