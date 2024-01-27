namespace ParDeMeias;

public static class Buscador
{

    public static int GetQuantidadeDePares(string conjuntoDeMeias)
    {
        int quantidadeDePares = 0;

        var conjuntoComUmPeDeMeia = new HashSet<char>(conjuntoDeMeias);

        foreach(char meia in conjuntoComUmPeDeMeia)
        {
            quantidadeDePares += BuscarQuantidadeDeParesDeMeias(meia, conjuntoDeMeias);
        }

        return quantidadeDePares;
    }
    private static int BuscarQuantidadeDeParesDeMeias(char meia, string conjuntoDeMeias)
    {
        int quantidadeDeMeiasIguais = conjuntoDeMeias.Count(item => item == meia);
        int quantidadeDeParesDeMeias = quantidadeDeMeiasIguais / 2;
        return quantidadeDeParesDeMeias;
    }

}
