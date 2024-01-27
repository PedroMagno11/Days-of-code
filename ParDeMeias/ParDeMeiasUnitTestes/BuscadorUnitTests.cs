using ParDeMeias;

namespace ParDeMeiasUnitTestes;

public class BuscadorUnitTests
{ 
    [Fact]
    public void TestarUmParDeMeias()
    {
        //arrange
        string meias = "AA";
        int expected = 1;

        //act
        int actual = Buscador.GetQuantidadeDePares(meias);

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Testar2ParesDeMeias()
    {
        //arrange
        string meias = "ABABC";
        int expected = 2;

        //act
        int actual = Buscador.GetQuantidadeDePares(meias);

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Testar4ParesDeMeias()
    {
        //arrange
        string meias = "CABBACCC";
        int expected = 4;

        //act 
        int actual = Buscador.GetQuantidadeDePares(meias);

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Testar0ParesDeMeias()
    {
        //arrange
        string meias = string.Empty;
        int expected = 0;

        //act
        int actual = Buscador.GetQuantidadeDePares(meias);

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Testar6ParesDeMeias()
    {
        //arrange
        string meias = "CCABCBCCACCC";
        int expected = 6;

        //act
        int actual = Buscador.GetQuantidadeDePares(meias);

        //assert
        Assert.Equal(expected, actual);
    }
}