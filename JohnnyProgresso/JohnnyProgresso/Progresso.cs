namespace JohnnyProgresso;

public static class Progresso
{
    public static int GetDiasDeProgresso(int[] milhasPercorridas)
    {
        int diasDeProgresso = 0;

        if (milhasPercorridas.Length == 0)
        {
            diasDeProgresso = 0;
        }

        for (int i = 1; i < milhasPercorridas.Length; i++)
        {
               if (milhasPercorridas[i] > milhasPercorridas[i-1])
               {
                    diasDeProgresso += 1;
               }
        }

        return diasDeProgresso;
    }
}
