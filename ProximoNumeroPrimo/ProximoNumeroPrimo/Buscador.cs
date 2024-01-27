namespace ProximoNumeroPrimo;

public static class Buscador
{
    public static int BuscarPorNumeroPrimoMaisProximo(int numero)
    {
           bool ehNumeroPrimo;

           do
           {
               ehNumeroPrimo = verificarSeEPrimo(numero);

               if (!ehNumeroPrimo)
               {
                   numero += 1;
               }
           }
           while (!ehNumeroPrimo);

           return numero;
    }

    private static bool verificarSeEPrimo(int numero)
    {
        if (numero == 1) return false;
        if (numero == 2) return true;


        for (int i = 2; i <= Math.Ceiling(Math.Sqrt(numero)); i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }
}
