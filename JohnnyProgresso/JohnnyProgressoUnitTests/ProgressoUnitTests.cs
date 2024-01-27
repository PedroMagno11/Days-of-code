using JohnnyProgresso;

namespace JohnnyProgressoUnitTests
{
    public class ProgressoUnitTests
    {
        [Fact]
        public void Tendo2Progressos()
        {
            int[] milhasPercorridas = { 3, 4, 1, 2 };
            int expected = 2;

            int actual = Progresso.GetDiasDeProgresso(milhasPercorridas);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Tendo3Progressos()
        {
            int[] milhasPercorridas = { 10, 11, 12, 9, 10 };
            int expected = 3;

            int actual = Progresso.GetDiasDeProgresso(milhasPercorridas);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Tendo1Progressos()
        {
            int[] milhasPercorridas = { 6, 5, 4, 3, 2, 9 };
            int expected = 1;

            int actual = Progresso.GetDiasDeProgresso(milhasPercorridas);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Tendo0Progressos()
        {
            int[] milhasPercorridas = { 9, 9 };
            int expected = 0;

            int actual = Progresso.GetDiasDeProgresso(milhasPercorridas);

            Assert.Equal(expected, actual);
        }
    }
}