using Espetos_de_Churrasco;

namespace EspetosDeChurrascoUnitTests
{
    public class ChurrasqueiraUnitTests
    {
        [Fact]
        public void Encontrar2EspetosVegetarianosE3EspetosDeCarne()
        {
            string[] espetos =
            {
                "--oooo-ooo--",
                "--xx--x--xx--",
                "--o---o--oo--",
                "--xx--x--ox--",
                "--xx--x--ox--"
            };

            int espetosDeCarne = 3;
            int espetosVegetarianos = 2;

            (int actualEspetosDeCarne, int actualEspetosVegetarianos) = Churrasqueira.QuantidadeDeTiposDeEspeto(espetos);

            bool resultCarne = (espetosDeCarne == actualEspetosDeCarne);
            bool resultVegetarianos = (espetosVegetarianos == actualEspetosVegetarianos);

            Assert.True(resultCarne == resultVegetarianos);
        }

        [Fact]
        public void Encontrar1EspetosVegetarianosE4EspetosDeCarne()
        {
            string[] espetos =
            {
                "--oooo-ooo--",
                "--xx--x--xx--",
                "--o---o--ox--",
                "--xx--x--ox--",
                "--xx--x--ox--"
            };

            int espetosDeCarne = 4;
            int espetosVegetarianos = 1;

            (int actualEspetosDeCarne, int actualEspetosVegetarianos) = Churrasqueira.QuantidadeDeTiposDeEspeto(espetos);

            bool resultCarne = (espetosDeCarne == actualEspetosDeCarne);
            bool resultVegetarianos = (espetosVegetarianos == actualEspetosVegetarianos);

            Assert.True(resultCarne == resultVegetarianos);
        }

        [Fact]
        public void Encontrar0EspetosVegetarianosE2EspetosDeCarne()
        {
            string[] espetos =
            {
                "--oooo-oxo--",
                "--xx--x--xx--"
            };

            int espetosDeCarne = 2;
            int espetosVegetarianos = 0;

            (int actualEspetosDeCarne, int actualEspetosVegetarianos) = Churrasqueira.QuantidadeDeTiposDeEspeto(espetos);

            bool resultCarne = (espetosDeCarne == actualEspetosDeCarne);
            bool resultVegetarianos = (espetosVegetarianos == actualEspetosVegetarianos);

            Assert.True(resultCarne == resultVegetarianos);
        }

        [Fact]
        public void Encontrar0EspetosVegetarianosE0EspetosDeCarne()
        {
            string[] espetos =
            {

            };

            int espetosDeCarne = 0;
            int espetosVegetarianos = 0;

            (int actualEspetosDeCarne, int actualEspetosVegetarianos) = Churrasqueira.QuantidadeDeTiposDeEspeto(espetos);

            bool resultCarne = (espetosDeCarne == actualEspetosDeCarne);
            bool resultVegetarianos = (espetosVegetarianos == actualEspetosVegetarianos);

            Assert.True(resultCarne == resultVegetarianos);
        }

        [Fact]
        public void Encontrar3EspetosVegetarianosE2EspetosDeCarne()
        {
            string[] espetos =
            {
                        "--oooo-ooo--",
                        "--xxxxxxxx--",
                        "--o---",
                        "-o-----o---x--",
                        "--o---o-----"
            };

            int espetosDeCarne = 2;
            int espetosVegetarianos = 3;

            (int actualEspetosDeCarne, int actualEspetosVegetarianos) = Churrasqueira.QuantidadeDeTiposDeEspeto(espetos);

            bool resultCarne = (espetosDeCarne == actualEspetosDeCarne);
            bool resultVegetarianos = (espetosVegetarianos == actualEspetosVegetarianos);

            Assert.True(resultCarne == resultVegetarianos);
        }


    }
}