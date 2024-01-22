using ConverterIdadeEmDias;

namespace ConverterIdadeEmDiasUnitTests
{
    public class ConverterIdadeEmDiasTest
    {
        [Fact]
        public void AnosEmDias30()
        {
            //arrange
            int idade = 30;
            int expected = 30 * 365;

            //act

            int actual = Conversor.IdadeEmDias(idade);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AnosEmDias78()
        {
            int expected = 78 * 365;
            int actual = Conversor.IdadeEmDias(78);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void AnosEmDias23()
        {
            int expected = 23 * 365;
            int actual = Conversor.IdadeEmDias(23);
            Assert.Equal(expected, actual);
        }
    }
}