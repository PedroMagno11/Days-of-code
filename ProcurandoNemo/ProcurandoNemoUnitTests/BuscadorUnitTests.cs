using ProcurandoNemo;

namespace ProcurandoNemoUnitTests
{
    public class BuscadorUnitTests
    {
        [Fact]
        public void NemoSouEu()
        {
            string fraseBase = "Nemo sou eu";
            int expected =  1;

            int actual = Buscador.ProcurandoNemo(fraseBase);

            Assert.True(actual == expected);
        }

        [Fact]
        public void EstouProcurandoNemo()
        {
            string fraseBase = "Estou procurando nemo";
            int expected = 3;

            int actual = Buscador.ProcurandoNemo(fraseBase);

            Assert.True(actual == expected);
        }

        [Fact]
        public void EuSouONemo()
        {
            string fraseBase = "Eu sou o Nemo";
            int expected = 4;

            int actual = Buscador.ProcurandoNemo(fraseBase);

            Assert.True(actual == expected);
        }

        [Fact]
        public void ProcurandoDori()
        {
            string fraseBase = "Procurando Dori";
            int expected = 0;

            int actual = Buscador.ProcurandoNemo(fraseBase);
            Assert.True(actual == expected);
        }

        public void ProcurandoNemori()
        {
            string fraseBase = "Procurando Nemori";
            int expected = 0;

            int actual = Buscador.ProcurandoNemo(fraseBase);
            Assert.True(actual == expected);
        }
    }
}